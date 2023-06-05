using System;
using System.Collections.Generic;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class PlatformMovingSystem : BaseSystem, IFixedUpdatable
    {
        private Rigidbody2D rigidbody2D;
        private float offset;
        private float speed;

        private Vector2 initPosition;

        public override void InitSystem()
        {
            rigidbody2D = Owner.GetComponent<Rigidbody2DProviderComponent>().Rigidbody;
            var platform = Owner.GetComponent<MovingPlatformComponent>();
            offset = platform.Offset;
            speed = platform.Speed;
            initPosition = rigidbody2D.position;
            
            rigidbody2D.isKinematic = true;
        }

        public void FixedUpdateLocal()
        {
            Move();
        }

        private void Move()
        {
            var x = initPosition.x + Mathf.PingPong(Time.time *speed, offset * 2) - offset;
            rigidbody2D.velocity = new Vector2(x - rigidbody2D.position.x, rigidbody2D.velocity.y);
        }
    }
}