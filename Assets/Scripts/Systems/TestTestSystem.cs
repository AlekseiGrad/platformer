using System;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class TestTestSystem : BaseSystem 
    {
        public override void InitSystem()
        {
        }
    }
}