using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class CameraComponent : BaseComponent
    {
        public Vector3 Offset;
        public Vector3 Velocity;
        public float Smoothing;
    }
}