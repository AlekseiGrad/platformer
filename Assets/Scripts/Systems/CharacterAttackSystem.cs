using System;
using System.Threading.Tasks;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;
using Cysharp.Threading.Tasks;
using Helpers;
using Unity.VisualScripting;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class CharacterAttackSystem : BaseSystem, IReactCommand<InputCommand>, IReactCommand<AnimationEventCommand>
    {
        private AttackComponent attackComponent;
        private Rigidbody2D rigidbody2D;
        
        public override void InitSystem()
        {
            attackComponent = Owner.GetComponent<AttackComponent>();
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
                At();
            }
        }

        private void TryAttack()
        {
            if (attackComponent.IsCanAttack)
            {
                Attack();
                AttackCooldown();
            }
        }

        private void Attack()
        {
            Owner.Command(new TriggerAnimationCommand()
            {
                Index = AnimParametersMap.MeleeAttack
            });
        }

        private void At()
        {
            var targets = Physics2D.OverlapCircleAll(rigidbody2D.position, attackComponent.Distance, attackComponent.AttackTargetMask);

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

       
    }
}