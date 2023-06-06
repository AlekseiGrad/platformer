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
    public sealed class CharacterMovingAnimationSystem : BaseSystem, IUpdatable
    {
        private AnimationComponent animationComponent;
        private MoveVectorComponent moveVectorComponent;
        private SpriteRenderer spriteRenderer;

        public override void InitSystem()
        {
            animationComponent = Owner.GetComponent<AnimationComponent>();
            moveVectorComponent = Owner.GetComponent<MoveVectorComponent>();
            spriteRenderer = Owner.GetComponent<SpriteRendererProviderComponent>().SpriteRenderer;
            Owner.Command(new TriggerAnimationCommand() { Index = AnimParametersMap.Respawn });
        }

        public void UpdateLocal()
        {
            UpdateGrounded();
            UpdateRunning();
            UpdateCrouching();
            UpdateJumping();
            UpdateFacing();
            
        }

        private void UpdateRunning()
        {
            if (moveVectorComponent.IsGrounded)
            {
                Owner.Command(new FloatAnimationCommand()
                {
                    Index = AnimParametersMap.HorizontalSpeed, Value = moveVectorComponent.MoveVector.x
                });
            }
        }

        private void UpdateCrouching()
        {
            Owner.Command(new BoolAnimationCommand()
                {
                    Index = AnimParametersMap.Crouching,
                    Value = moveVectorComponent.MoveVector.y < 0 && moveVectorComponent.IsGrounded
                });
        }

        private void UpdateJumping()
        {
            if (!moveVectorComponent.IsGrounded && moveVectorComponent.MoveVector.y != 0)
                Owner.Command(new FloatAnimationCommand()
                {
                    Index = AnimParametersMap.VerticalSpeed, Value = animationComponent.MoveSpeed
                });
            else
            {
                Owner.Command(new FloatAnimationCommand()
                {
                    Index = AnimParametersMap.VerticalSpeed, Value = 0
                });
            }
        }

        private void UpdateGrounded()
        {
            Owner.Command(new BoolAnimationCommand()
            {
                Index = AnimParametersMap.Grounded, Value = moveVectorComponent.IsGrounded
            });
        }

        private void UpdateFacing()
        {
            spriteRenderer.flipX = moveVectorComponent.MoveVector.x <= 0;
        }
    }
}