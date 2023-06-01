using System;
using Commands;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class CharacterCameraFollowingSystem : BaseSystem, ILateUpdatable,
        IReactGlobalCommand<DefaultCharacterSpawnCommand>
    {
        private Camera camera;
        private CameraComponent cameraComponent;
        private UnityTransformComponent target;
        private bool isTargetInitialized;

        public override void InitSystem()
        {
            camera = Owner.GetComponent<CameraProviderComponent>().Camera;
            cameraComponent = Owner.GetComponent<CameraComponent>();
        }

        public void UpdateLateLocal()
        {
            if (!isTargetInitialized) return;

            var currentPosition = camera.transform.position;
            var targetPosition = target.Transform.position + cameraComponent.Offset;
            camera.transform.position = 
                Vector3.SmoothDamp(currentPosition, targetPosition, 
                    ref cameraComponent.Velocity, cameraComponent.Smoothing * Time.deltaTime);
        }

        public void CommandGlobalReact(DefaultCharacterSpawnCommand command)
        { 
            isTargetInitialized = true;
            target = 
                Owner
                    .World.GetSingleComponent<CharacterTagComponent>()
                    .Owner.GetComponent<UnityTransformComponent>();
        }
    }
}