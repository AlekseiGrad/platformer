using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class CharacterMovingAnimationSystem : BaseSystem,IReactCommand<InputStartedCommand>
    {
        public override void InitSystem()
        {
            Owner.Command(new BoolAnimationCommand()
            {
                Index = AnimParametersMap.Normal,
                Value = true
            });
        }

        public void CommandReact(InputStartedCommand command)
        {
            if (InputIdentifierMap.Move == command.Index)
            {
                Owner.Command(new FloatAnimationCommand()
                {
                    Index = AnimParametersMap.VerticalSpeed,
                    Value = Owner.GetComponent<CharacterComponent>().MaxSpeed
                });
                Owner.Command(new FloatAnimationCommand()
                {
                    Index = AnimParametersMap.HorizontalSpeed,
                    Value = Owner.GetComponent<CharacterComponent>().MaxSpeed
                });
            } else if (InputIdentifierMap.Jump == command.Index)
            {
                Owner.Command(new BoolAnimationCommand()
                {
                    Index = AnimParametersMap.HorizontalSpeed,
                    Value = true
                });
            }
        }
    }
}