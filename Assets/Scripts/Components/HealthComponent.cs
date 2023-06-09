using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class HealthComponent : BaseComponent
    {
        public float HealthMaxValue;
        public float HealthCurrentValue;
        public float HealthStartValue;
    }
}