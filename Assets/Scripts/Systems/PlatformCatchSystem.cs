using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class PlatformCatchSystem : BaseSystem, IReactCommand<IsDeadCommand>
    {
        public override void InitSystem()
        {
        }

        public void CommandReact(IsDeadCommand command)
        {
            
        }
    }
}