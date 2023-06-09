using HECSFramework.Core;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class MoveVectorComponent : BaseComponent
    {
        public Vector2 MoveVector;
        public Vector2 initialPosition;
        public bool IsGrounded;
    }
}