using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class CollisionTargetsComponent : BaseComponent
    {
        public Collider2D[] Targets;
        public int Count;
    }
}