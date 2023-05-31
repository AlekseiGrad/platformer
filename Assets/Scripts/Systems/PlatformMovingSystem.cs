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
            direction = -1;
            offset = 12;
            speed = 2.0f;
            rigidbody2D = Owner.GetComponent<Rigidbody2DProviderComponent>().Rigidbody;
            rigidbody2D.isKinematic = true;
        }

        public void FixedUpdateLocal()
        {
           rigidbody2D.velocity = Vector2.right * direction * speed;
           Debug.Log(Mathf.Abs(rigidbody2D.position.x));
           if (Mathf.Abs(rigidbody2D.position.x) > offset)
               ChangeDirection();
        }

        private void ChangeDirection()
        {
            direction = (direction == 1) ? -1 : 1;
        }
        
    }
}