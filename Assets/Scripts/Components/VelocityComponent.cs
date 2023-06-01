using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class VelocityComponent : BaseComponent
    {
        public Vector3 Velocity;
    }
}