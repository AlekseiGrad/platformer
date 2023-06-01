using System;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class EnemyBehaviourSystem : BaseSystem 
    {
        private MovementComponent movementComponent;
        private MoveVectorComponent moveVectorComponent;
        private EnemyComponent enemyComponent;

        public override void InitSystem()
        {
            var enemy = Owner.GetComponent<EnemyTagComponent>();
            movementComponent = Owner.GetComponent<MovementComponent>();
            moveVectorComponent = Owner.GetComponent<MoveVectorComponent>();
            enemyComponent = Owner.GetComponent<EnemyComponent>();
        }
        
        
    }
}