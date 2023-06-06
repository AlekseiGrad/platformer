using System;
using Commands;
using Components;
using HECSFramework.Core;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

namespace Systems
{
    [Serializable]
    [Documentation(Doc.NONE, "")]
    public sealed class CharacterMovementSystem : BaseSystem, IFixedUpdatable, IReactCommand<InputCommand>
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
                var vector = command.Context.ReadValue<Vector2>().normalized;

                moveVectorComponent.MoveVector = vector;

                if (moveVectorComponent.MoveVector.y > 0) return;

                if (moveVectorComponent.IsGrounded)
                {
                    moveVectorComponent.MoveVector.x *= movementComponent.MoveSpeed;
                }
            }

            if (InputIdentifierMap.Jump == command.Index)
            {
                if (moveVectorComponent.IsGrounded)
                {
                    moveVectorComponent.MoveVector =
                        new Vector2(moveVectorComponent.MoveVector.x, movementComponent.JumpSpeed);
                }
            }
        }

        private void ReduceSpeed()
        {
            if (moveVectorComponent.MoveVector.x > 0)
            {
                moveVectorComponent.MoveVector.x -= movementComponent.Deceleration * Time.fixedDeltaTime;
                if (moveVectorComponent.MoveVector.x < 0)
                {
                    moveVectorComponent.MoveVector.x = 0;
                }
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
            if (moveVectorComponent.MoveVector.y > 0)
            {
                moveVectorComponent.MoveVector.y -= movementComponent.JumpAbort * Time.fixedDeltaTime;
                if (moveVectorComponent.MoveVector.y < 0)
                {
                    moveVectorComponent.MoveVector.y = 0;
                }
            }
        }
    }
}