using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class MovementComponent : BaseComponent
    {
        public float MoveSpeed;
        public float JumpSpeed;
        public float JumpAbort;
        public float Deceleration;
    }
}