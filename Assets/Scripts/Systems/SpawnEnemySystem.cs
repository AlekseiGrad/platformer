using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class SpawnEnemySystem : BaseSystem
    {
        [Required] private EnemyHolderComponent enemyHolderComponent;
        private EntitiesFilter spawnPointTagFilter;

        public override async void InitSystem()
        {
            spawnPointTagFilter = Owner.World.GetFilter(Filter.Get<SpawnPointTagComponent>());
            foreach (var entity in spawnPointTagFilter)
            {
                if (entity.GetComponent<SpawnPointTagComponent>().Id.Id == SpawnerIdentifiersMap.Enemy)
                {
                    var position = entity.GetComponent<UnityTransformComponent>().Transform.position;
                    var enemy = await enemyHolderComponent.Container.GetActor(Owner.World, position: position);
                    enemy.Init();
                    Owner.World.Command(new EnemySpawnCommand());
                }
            }
        }
    }
}