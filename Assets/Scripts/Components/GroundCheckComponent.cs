using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class GroundCheckComponent : BaseComponent
    {
        public float GroundDistance;
        public LayerMask GroundedMask;
    }
}