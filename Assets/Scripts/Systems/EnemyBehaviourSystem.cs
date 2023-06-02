using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
    [Serializable]
    [Documentation(Doc.NONE, "")]
    public sealed class EnemyBehaviourSystem : BaseSystem, IFixedUpdatable, IReactGlobalCommand<EnemySpawnCommand>,
        IReactGlobalCommand<DefaultCharacterSpawnCommand>
    {
        private MovementComponent movementComponent;
        private MoveVectorComponent moveVectorComponent;
        private EnemyComponent enemyComponent;
        private EnemyBehaviourComponent enemyBehaviourComponent;
        private Rigidbody2D rigidbody2D;
        public float patrolRadius = 4f;
        public float chaseDistance = 4f;
        public float attackDistance = 1f;
        public float moveSpeed = 3f;
        private Vector2 startingPosition;
        private UnityTransformComponent enemyTransformComponent;

        private State currentState;
        private UnityTransformComponent targetTransformComponent;
        private bool isCharacterInitialized;

        private enum State
        {
            NonInitialized,
            Patrol,
            Chase,
            Attack
        }

        public override void InitSystem()
        {
            currentState = State.NonInitialized;
            rigidbody2D = Owner.GetComponent<Rigidbody2DProviderComponent>().Rigidbody;
            movementComponent = Owner.GetComponent<MovementComponent>();
            moveVectorComponent = Owner.GetComponent<MoveVectorComponent>();
            enemyComponent = Owner.GetComponent<EnemyComponent>();
            enemyBehaviourComponent = Owner.GetComponent<EnemyBehaviourComponent>();
            enemyTransformComponent = Owner.GetComponent<UnityTransformComponent>();
        }

        public void FixedUpdateLocal()
        {
            switch (currentState)
            {
                case State.NonInitialized:
                    break;
                case State.Patrol:
                    Patrol();
                    break;
                case State.Chase:
                    ChasePlayer();
                    break;
                case State.Attack:
                    Attack();
                    break;
            }
        }
        
        public void CommandGlobalReact(EnemySpawnCommand command)
        {
            startingPosition = Owner.GetComponent<UnityTransformComponent>().Transform.position;
            currentState = State.Patrol;
        }

        public void CommandGlobalReact(DefaultCharacterSpawnCommand command)
        {
            isCharacterInitialized = true;
            targetTransformComponent = Owner.World.GetSingleComponent<CharacterTagComponent>()
                .Owner.GetComponent<UnityTransformComponent>();
        }

        private void Patrol()
        {
            var x = startingPosition.x + Mathf.PingPong(Time.time *moveSpeed, patrolRadius * 2) - patrolRadius;
            rigidbody2D.velocity = new Vector2(x - enemyTransformComponent.Transform.position.x, rigidbody2D.velocity.y);

            if (isCharacterInitialized)
            {
                var distanceToPlayer = Vector2.Distance(enemyTransformComponent.Transform.position, targetTransformComponent.Transform.position);

                if (distanceToPlayer < chaseDistance)
                {
                    currentState = State.Chase;
                }
            }
        }

        private void ChasePlayer()
        {
            var distanceToPlayer = Vector2.Distance(enemyTransformComponent.Transform.position, targetTransformComponent.Transform.position);
            var distanceToStart = Vector2.Distance(enemyTransformComponent.Transform.position, startingPosition);

            if (distanceToPlayer > chaseDistance && distanceToStart < patrolRadius)
            {
                currentState = State.Patrol;
                return;
            }

            rigidbody2D.velocity = new Vector2(Mathf.Sign(targetTransformComponent.Transform.position.x - enemyTransformComponent.Transform.position.x) * moveSpeed,
                rigidbody2D.velocity.y);

            if (distanceToPlayer < attackDistance)
            {
                //currentState = State.Attack;
            }
        }

        private void Attack()
        {
            Debug.Log("attack");
        }
    }
}