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
        private int direction;
        private float offset;
        private float speed;

        public override void InitSystem()
        {
            rigidbody2D = Owner.GetComponent<Rigidbody2DProviderComponent>().Rigidbody;
            var platform = Owner.GetComponent<MovingPlatformComponent>();
            direction = platform.Direction;
            offset = platform.Offset;
            speed = platform.Speed;
            rigidbody2D.isKinematic = true;
        }

        public void FixedUpdateLocal()
        {
            rigidbody2D.velocity = Vector2.right * direction * speed;
            UpdateDirection(rigidbody2D.position.x);

        }

        private void UpdateDirection(float x)
        {
            if (x + offset < 0 )
                    direction = 1;
            else if (x - offset > 0)
                    direction = -1;
        }
    }
}