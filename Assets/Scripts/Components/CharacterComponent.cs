using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class CharacterComponent : BaseComponent
    {
        public float RunSpeed;
        public float JumpSpeed;
        public LayerMask GroundMask;
        public float GroundDistance;


    }
}