using System;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class CharacterCameraFollowingSystem : BaseSystem, ILateUpdatable
    {
        private Vector3 targetPosition;
        private Vector3 offset;
        private Camera camera;
        private EntitiesFilter characterFilter;

        public override void InitSystem()
        {
            camera = Owner.GetComponent<CameraProviderComponent>().Camera;
            offset = Owner.GetComponent<CameraComponent>().Offset;
            characterFilter = Owner.World.GetFilter(Filter.Get<CharacterComponent>());
        }

        public void UpdateLateLocal()
        {
            if (characterFilter.Count == 0)
                return;

            foreach (var entity in characterFilter)
            {
                targetPosition = entity.GetComponent<UnityTransformComponent>().Transform.position;
                camera.transform.position = offset + targetPosition;
            }
        }
    }
}