using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class PlatformCatchSystem : BaseSystem, IReactCommand<CatchCommand>
    {
        
        public override void InitSystem()
        {
            var character = Owner.GetComponent<CharacterComponent>();
        }

        public void CommandReact(CatchCommand command)
        {
            
        }
    }
}