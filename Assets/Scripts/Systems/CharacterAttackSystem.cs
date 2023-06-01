using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class CharacterAttackSystem : BaseSystem, IReactCommand<InputCommand>
    {
        private AttackComponent attackComponent;

        public override void InitSystem()
        {
            attackComponent = Owner.GetComponent<AttackComponent>();
        }

        public void CommandReact(InputCommand command)
        {
            if (InputIdentifierMap.Attack == command.Index)
            {
                TryAttack();
            }
        }

        private void TryAttack()
        {
            
        }
    }
}