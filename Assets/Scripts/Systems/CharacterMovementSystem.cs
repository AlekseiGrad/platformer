using System;
using Commands;
using Components;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

namespace Systems
{
    [Serializable]
    [Documentation(Doc.NONE, "")]
    public sealed class CharacterMovementSystem : BaseSystem, IReactCommand<InputCommand>, IFixedUpdatable
    {
        private Rigidbody2D rigidbody2D;
        private MovementComponent movementComponent;
        private GroundCheckComponent groundCheckComponent;

        private MoveVectorComponent moveVectorComponent;

        public override void InitSystem()
        {
            rigidbody2D = Owner.GetComponent<Rigidbody2DProviderComponent>().Rigidbody;
            movementComponent = Owner.GetComponent<MovementComponent>();
            moveVectorComponent = Owner.GetComponent<MoveVectorComponent>();
            groundCheckComponent = Owner.GetComponent<GroundCheckComponent>();
        }

        public void FixedUpdateLocal()
        {
            rigidbody2D.velocity = moveVectorComponent.MoveVector;
            ReduceSpeed();
            IsGrounded();
            UpdateJump();
        }

        public void CommandReact(InputCommand command)
        {
            if (InputIdentifierMap.Move == command.Index)
            {
                var vector = command.Context.ReadValue<Vector2>();

                if (vector.y > 0) return;
                
                if (moveVectorComponent.IsGrounded)
                {
                    moveVectorComponent.MoveVector.x = vector.normalized.x * movementComponent.MoveSpeed;
                }
            }

            if (InputIdentifierMap.Jump == command.Index)
            {
                if (moveVectorComponent.IsGrounded)
                {
                    moveVectorComponent.MoveVector =
                        (Vector2.up + moveVectorComponent.MoveVector.normalized) *
                        movementComponent.JumpSpeed;
                }
            }
        }

        private void ReduceSpeed()
        {
            if (moveVectorComponent.MoveVector.x > 0)
            {
                moveVectorComponent.MoveVector.x -= movementComponent.Deceleration * Time.fixedDeltaTime;
                if (moveVectorComponent.MoveVector.x < 0) moveVectorComponent.MoveVector.x = 0;
            }
            else if (moveVectorComponent.MoveVector.x < 0)
            {
                moveVectorComponent.MoveVector.x += movementComponent.Deceleration * Time.fixedDeltaTime;
                if (moveVectorComponent.MoveVector.x > 0)
                {
                    moveVectorComponent.MoveVector.x = 0;
                }
            }
        }

        private void IsGrounded()
        {
            moveVectorComponent.IsGrounded = Physics2D.Raycast(rigidbody2D.position, Vector2.down,
                groundCheckComponent.GroundDistance, groundCheckComponent.GroundedMask);
        }

        private void UpdateJump()
        {
            if (moveVectorComponent.MoveVector.y > 0) moveVectorComponent.MoveVector.y -= movementComponent.JumpAbort;
        }
    }
}