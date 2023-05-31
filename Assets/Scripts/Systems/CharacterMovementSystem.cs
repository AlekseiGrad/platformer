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
    
    public sealed class CharacterMovementSystem : BaseSystem, IReactCommand<InputCommand>
    {
        private Rigidbody2D rigidbody2D;
        private float runSpeed;
        private float jumpSpeed;
        private float groundDistance;
        private LayerMask groundedMask;


        public override void InitSystem()
        {
            rigidbody2D = Owner
                .GetComponent<Rigidbody2DProviderComponent>()
                .Rigidbody;
            var character = Owner.GetComponent<CharacterComponent>();
            runSpeed = character.RunSpeed;
            jumpSpeed = character.JumpSpeed;
            groundDistance = character.GroundDistance;
            groundedMask = character.GroundMask;
        }


        public void CommandReact(InputCommand command)
        {
            {
                if (InputIdentifierMap.Move == command.Index)
                {
                    var vector = command.Context.ReadValue<Vector2>().normalized;
                    if (IsGrounded())
                        rigidbody2D.velocity = vector * runSpeed;
                }

                if (InputIdentifierMap.Jump == command.Index)
                {
                    if (IsGrounded())
                        rigidbody2D.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
                }
            }
        }

        private bool IsGrounded()
        {
            return Physics2D.Raycast(rigidbody2D.position, Vector2.down, groundDistance, groundedMask);
        }
    }
}