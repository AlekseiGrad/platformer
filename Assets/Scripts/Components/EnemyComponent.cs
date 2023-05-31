using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class EnemyComponent : BaseComponent
    {
        public float Speed;
        public float Offset;
        public int Direction;
    }
}