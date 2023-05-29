using System;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class SpawnDefaultCharacterSystem : BaseSystem
    {
        [Required]
        private DefaultCharacterHolderComponent characterHolderComponent;

        private SpawnPointTagComponent spawnPoint;
        
        public override async void InitSystem()
        {
            spawnPoint = Owner.World.GetSingleComponent<SpawnPointTagComponent>();
            var position = spawnPoint.Owner.GetComponent<UnityTransformComponent>().Transform.position;
            var character = await characterHolderComponent.Container.GetActor(Owner.World, position: position);
            character.Init(); 
        }
    }
}