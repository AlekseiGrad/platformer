using System;
using Commands;
using Components;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    
    public sealed class CharacterMovementSystem : BaseSystem, IReactCommand<InputStartedCommand>
    {
        private Rigidbody2D rigidbody2D;
        private float characterSpeed;
        private float groundDistance;
        private LayerMask groundedMask;
        

        private Vector2 moveVector;
        private float gravity;
        private float jumpReduction;
        

        public override void InitSystem()
        {
            rigidbody2D = Owner
                .GetComponent<Rigidbody2DProviderComponent>().Rigidbody;
            var character = Owner.GetComponent<CharacterComponent>();
            characterSpeed = character.MaxSpeed;
            groundDistance = character.GroundDistance;
            groundedMask = character.GroundMask;
            gravity = character.Gravity;
        }


        public void CommandReact(InputStartedCommand command)
        {
            if (InputIdentifierMap.Move == command.Index)
            {
                moveVector = command.Context.ReadValue<Vector2>().normalized;
                Move(moveVector);
            }
            if (InputIdentifierMap.Jump == command.Index)
            {
                Jump();
            }
        }

        private void Move(Vector2 vector)
        {
            if (vector.y > 0) return;

            
            if (IsGrounded())
                rigidbody2D.AddForce(vector*characterSpeed, ForceMode2D.Impulse);
        }

        private void Jump()
        {
            if(IsGrounded())
                rigidbody2D.AddForce(Vector2.up*characterSpeed, ForceMode2D.Impulse);
        }

        private bool IsGrounded()
        {
            return Physics2D.Raycast(rigidbody2D.position, Vector2.down, groundDistance, groundedMask);
        }

        private void SetMoveVector(Vector2 vector)
        {
            moveVector = vector;
        }

        private void GroundedMovement()
        {
            moveVector.y -= gravity * Time.deltaTime;
        }

        private bool IsFalling()
        {
            return moveVector.y < 0.0f;
        }

        private void UpdateJump()
        {
            if (moveVector.y > 0.0f)
            {
                moveVector.y -= jumpReduction * Time.deltaTime;
            }
        }
    }
}