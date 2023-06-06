using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;
using Cysharp.Threading.Tasks;

namespace Systems
{
    [Serializable]
    [Documentation(Doc.NONE, "")]
    public sealed class EnemyBehaviourSystem : BaseSystem,IUpdatable, IFixedUpdatable, IReactGlobalCommand<EnemySpawnCommand>,
        IReactGlobalCommand<DefaultCharacterSpawnCommand>, IReactCommand<AnimationEventCommand>
    {
        private MovementComponent movementComponent;
        private MoveVectorComponent moveVectorComponent;
        private EnemyComponent enemyComponent;
        private AttackComponent attackComponent;
        private Rigidbody2D rigidbody2D;
        private UnityTransformComponent enemyTransformComponent;
        private UnityTransformComponent targetTransformComponent;

        private State currentState;
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
            enemyTransformComponent = Owner.GetComponent<UnityTransformComponent>();
            attackComponent = Owner.GetComponent<AttackComponent>();
        }

        public void FixedUpdateLocal()
        {
            rigidbody2D.velocity = moveVectorComponent.MoveVector;
        }
        
        public void CommandGlobalReact(EnemySpawnCommand command)
        {
            moveVectorComponent.initialPosition = Owner.GetComponent<UnityTransformComponent>().Transform.position;
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
            var x = moveVectorComponent.initialPosition.x + Mathf.PingPong(Time.time * movementComponent.MoveSpeed, enemyComponent.PatrolRadius * 2) - enemyComponent.PatrolRadius;
            moveVectorComponent.MoveVector.x = x - enemyTransformComponent.Transform.position.x;

            if (isCharacterInitialized)
            {
                var distanceToPlayer = Vector2.Distance(enemyTransformComponent.Transform.position, targetTransformComponent.Transform.position);

                if (distanceToPlayer < enemyComponent.ChaseRadius)
                {
                    currentState = State.Chase;
                }
            }
        }

        private void ChasePlayer()
        {
            var distanceToPlayer = Vector2.Distance(enemyTransformComponent.Transform.position, targetTransformComponent.Transform.position);
            var distanceToStart = Vector2.Distance(enemyTransformComponent.Transform.position, moveVectorComponent.initialPosition);

            if (distanceToPlayer > enemyComponent.ChaseRadius && distanceToStart < enemyComponent.PatrolRadius)
            {
                currentState = State.Patrol;
                return;
            }

            moveVectorComponent.MoveVector.x =
                Mathf.Sign(targetTransformComponent.Transform.position.x -
                           enemyTransformComponent.Transform.position.x) * movementComponent.MoveSpeed;

            if (distanceToPlayer < attackComponent.Distance)
            {
                currentState = State.Attack;
            }
        }

        private void TryAttack()
        {
            moveVectorComponent.MoveVector = Vector2.zero;
            
            if (attackComponent.IsCanAttack)
            {
                Owner.Command(new TriggerAnimationCommand()
                {
                    Index = AnimParametersMap.MeleeAttack
                });
                ReloadAttack();
            }

            currentState = State.Chase;
        }

        private void Attack()
        {
            var targets = Physics2D.OverlapCircleAll(rigidbody2D.position + attackComponent.Offset, attackComponent.Distance, attackComponent.TargetMask);

            foreach (var target in targets)
            {
                target.GetComponent<Actor>().Command(new DealDamageCommand()
                {
                    Value = attackComponent.Value
                });
            }
        }

        private async void ReloadAttack()
        {
            attackComponent.IsCanAttack = false;
            await UniTask.Delay(attackComponent.Cooldown);
            attackComponent.IsCanAttack = true;
        }

        public void CommandReact(AnimationEventCommand command)
        {
            if (command.Id == AnimationEventIdentifierMap.EnemyAttackAnimationEventIdentifier)
            {
                Attack();
            }
            if (command.Id == AnimationEventIdentifierMap.EnemyEndAttackAnimationEventIdentifier)
            {
                currentState = State.Chase;
            }
        }

        public void UpdateLocal()
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
                    TryAttack();
                    break;
            }
        }
    }
}