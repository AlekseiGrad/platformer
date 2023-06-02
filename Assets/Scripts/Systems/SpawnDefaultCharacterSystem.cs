using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class SpawnDefaultCharacterSystem : BaseSystem, IUpdatable
    {
        [Required]
        private DefaultCharacterHolderComponent characterHolderComponent;
        
        public override async void InitSystem()
        {
            var spawnPointFilter = Owner.World.GetFilter(Filter.Get<SpawnPointTagComponent>());
            foreach (var e in spawnPointFilter)
            {
                if (e.GetComponent<SpawnPointTagComponent>().Id.Id == SpawnerIdentifiersMap.Character)
                {
                    var position = e.GetComponent<UnityTransformComponent>().Transform.position;
                    var character = await characterHolderComponent.Container.GetActor(Owner.World, position: position);
                    character.Init();
                    Owner.World.Command(new DefaultCharacterSpawnCommand());
                }
            }
        }

        public void UpdateLocal()
        {
            
        }
    }
}