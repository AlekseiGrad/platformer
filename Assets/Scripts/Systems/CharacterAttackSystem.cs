using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;
using Cysharp.Threading.Tasks;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class CharacterAttackSystem : BaseSystem, IReactCommand<InputCommand>, IReactCommand<AnimationEventCommand>
    {
        private AttackComponent attackComponent;
        private Rigidbody2D rigidbody2D;
        private MoveVectorComponent moveVectorComponent;
        
        
        public override void InitSystem()
        {
            attackComponent = Owner.GetComponent<AttackComponent>();
            moveVectorComponent = Owner.GetComponent<MoveVectorComponent>();
            rigidbody2D = Owner.GetComponent<Rigidbody2DProviderComponent>().Rigidbody;
        }

        public void CommandReact(InputCommand command)
        {
            if (InputIdentifierMap.Attack == command.Index)
            {
                TryAttack();
            }
        }
        
        public void CommandReact(AnimationEventCommand command)
        {
            if (AnimationEventIdentifierMap.AttackAnimationEventIdentifier == command.Id)
            {
                Attack();
            }
        }

        private void TryAttack()
        {
            if (attackComponent.IsCanAttack)
            {
                Owner.Command(new TriggerAnimationCommand()
                {
                    Index = AnimParametersMap.MeleeAttack
                });
                AttackCooldown();
            }
        }
        

        private void Attack()
        {
            UpdateAttackDirection();
            var targets = Physics2D.OverlapCircleAll(rigidbody2D.position , attackComponent.Distance, attackComponent.TargetMask);
            
            foreach (var target in targets)
            {
                target.GetComponent<Actor>().Command(new DealDamageCommand()
                {
                    Value = attackComponent.Value
                });
            }
        }

        private async void AttackCooldown()
        {
            attackComponent.IsCanAttack = false;
            await UniTask.Delay(attackComponent.Cooldown);
            attackComponent.IsCanAttack = true;
        }

        private void UpdateAttackDirection()
        {
            attackComponent.Direction = moveVectorComponent.MoveVector.x > 0 ? 1 : -1;
        }

       
    }
}