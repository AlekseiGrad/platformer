using System;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class CharacterCameraFollowingSystem : BaseSystem, ILateUpdatable
    {
        private Vector3 offset;
        private Vector3 velocity;
        private float smoothing;
        private Camera camera;
        private EntitiesFilter characterFilter;

        public override void InitSystem()
        {
            camera = Owner.GetComponent<CameraProviderComponent>().Camera;
            var cameraComponent = Owner.GetComponent<CameraComponent>();
            offset = cameraComponent.Offset;
            velocity = cameraComponent.Velocity;
            smoothing = cameraComponent.Smoothing;
            characterFilter = Owner.World.GetFilter(Filter.Get<CharacterComponent>());
        }

        public void UpdateLateLocal()
        {
            if (characterFilter.Count == 0)
                return;

            foreach (var entity in characterFilter)
            {
                var currentPosition = camera.transform.position;
                var targetPosition = entity.GetComponent<UnityTransformComponent>().Transform.position + offset;
                camera.transform.position = Vector3.SmoothDamp(currentPosition, targetPosition,ref velocity, smoothing * Time.deltaTime);
            }
        }
    }
}