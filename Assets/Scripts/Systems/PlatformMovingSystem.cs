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
        private EntitiesFilter platformfilter;
        private int direction;
        private Vector2 initPosition;
        private float offset;

        public override void InitSystem()
        {
            direction = -1;
            platformfilter = Owner.World.GetFilter(Filter.Get<MovingPlatformComponent>());
            foreach (var entity in platformfilter)
            {
                initPosition = entity.GetComponent<UnityTransformComponent>().Transform.position;
                offset = entity.GetComponent<MovingPlatformComponent>().Offset *
                         entity.GetComponent<MovingPlatformComponent>().Offset;
            }
        }

        public void FixedUpdateLocal()
        {
            foreach (var entity in platformfilter)
            {
               var rb = entity.GetComponent<Rigidbody2DProviderComponent>().Rigidbody;
               rb.AddForce(Vector2.right * (direction * entity.GetComponent<MovingPlatformComponent>().Speed), ForceMode2D.Force);
               
               if (GetDistance(rb) >= offset)
                   ChangeDirection();
            }
        }

        private void ChangeDirection()
        {
            direction = (direction == 1) ? -1 : 1;
        }

        private float GetDistance(Rigidbody2D rb)
        {
            if (direction == -1)
            {
                return (initPosition - rb.position).sqrMagnitude;
            }
            else
            {
                return (rb.position - initPosition).sqrMagnitude;
            }
        }
    }
}