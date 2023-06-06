using System;
using Commands;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class EnemyAnimationSystem : BaseSystem, IUpdatable
    {
        [Required] private AnimationComponent animationComponent;
        private SpriteRenderer spriteRenderer;
        private MoveVectorComponent moveVectorComponent;

        public override void InitSystem()
        {
            spriteRenderer = Owner.GetComponent<SpriteRendererProviderComponent>().SpriteRenderer;
            moveVectorComponent = Owner.GetComponent<MoveVectorComponent>();
            Owner.Command(new BoolAnimationCommand()
            {
                Index = AnimParametersMap.Grounded,
                Value = true
            });
        }

        public void UpdateLocal()
        {
            UpdateFacing();
            UpdateRunning();
        }

        private void UpdateRunning()
        {
            Owner.Command(new FloatAnimationCommand()
            {
                Index = AnimParametersMap.HorizontalSpeed, Value = moveVectorComponent.MoveVector.x
            });
        }

        private void UpdateFacing()
        {
            spriteRenderer.flipX = moveVectorComponent.MoveVector.x < 0;
        }
        
    }
}