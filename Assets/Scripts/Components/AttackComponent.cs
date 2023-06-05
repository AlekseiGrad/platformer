using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class AttackComponent : BaseComponent
    {
        public bool IsCanAttack;
        public float Distance;
        public float Speed;
        public int Cooldown;
        public float Value;
        public LayerMask AttackTargetMask;

    }
}