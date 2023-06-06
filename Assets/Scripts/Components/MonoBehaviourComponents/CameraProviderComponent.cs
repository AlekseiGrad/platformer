using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class CameraProviderComponent : BaseComponent, IInitable, IHaveActor
    {
        public Camera Camera;
        public Actor Actor { get; set; }
        public void Init()
        {
            Camera = Actor.GetComponent<Camera>();
        }
    }
}