using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class CharacterDamageSystem : BaseSystem
    {
        public override void InitSystem()
        {
        }
        
    }
}