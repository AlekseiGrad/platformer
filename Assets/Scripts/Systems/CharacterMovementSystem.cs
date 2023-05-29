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
        

        public override void InitSystem()
        {
            rigidbody2D = Owner
                .GetComponent<Rigidbody2DProviderComponent>().Rigidbody;
            var character = Owner.GetComponent<CharacterComponent>();
            characterSpeed = character.Speed;
            groundDistance = character.GroundDistance;
            groundedMask = character.GroundMask;
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
            Owner.Command(new BoolAnimationCommand()
            {
                Index = AnimParametersMap.Crouching,
                Value = true
            });
            
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
    }
}