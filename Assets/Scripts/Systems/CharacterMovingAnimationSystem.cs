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
    public sealed class CharacterMovingAnimationSystem : BaseSystem, IReactCommand<InputCommand>
    {
        private CharacterComponent characterComponent;

        public override void InitSystem()
        {
            characterComponent = Owner.GetComponent<CharacterComponent>();
            Owner.Command(new TriggerAnimationCommand() { Index = AnimParametersMap.Respawn });
        }

        public void CommandReact(InputCommand command)
        {
            if (InputIdentifierMap.Move == command.Index)
            {
                var vector = command.Context.ReadValue<Vector2>().normalized;

                if (vector.y < 0)
                    Owner.Command(new BoolAnimationCommand() { Index = AnimParametersMap.Crouching, Value = true });
                else
                    Owner.Command(new BoolAnimationCommand() { Index = AnimParametersMap.Crouching, Value = false });

                if (vector.x != 0)
                {
                    Owner.Command((new FloatAnimationCommand()
                    {
                        Index = AnimParametersMap.HorizontalSpeed, Value = characterComponent.AnimRunSpeed
                    }));
                }
                else if (vector.x == 0)
                {
                    Owner.Command(new TriggerAnimationCommand() { Index = AnimParametersMap.Grounded });
                }
            }

            if (InputIdentifierMap.Jump == command.Index)
            {
                Owner.Command(new BoolAnimationCommand() { Index = AnimParametersMap.Grounded, Value = false });
            }
        }
    }
}