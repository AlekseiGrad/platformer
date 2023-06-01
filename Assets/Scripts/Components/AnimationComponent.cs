using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class AnimationComponent : BaseComponent
    {
        public float MoveSpeed;
        public float JumpSpeed;
    }
}