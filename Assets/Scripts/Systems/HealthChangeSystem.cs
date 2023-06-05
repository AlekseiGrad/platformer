using System;
using Commands;
using HECSFramework.Core;
using Components;
using UnityEngine;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class HealthChangeSystem : BaseSystem, IReactCommand<DealDamageCommand>
    {
        private HealthComponent healthComponent;

        public override void InitSystem()
        {
            healthComponent = Owner.GetComponent<HealthComponent>();
            healthComponent.HealthCurrentValue = healthComponent.HealthStartValue;
        }

        public void CommandReact(DealDamageCommand command)
        {
            Debug.Log("take dmg");
            healthComponent.HealthCurrentValue -= command.Value;
            
            if (healthComponent.HealthCurrentValue <= 0)
            {
                Owner.HecsDestroy();
            }
        }
    }
}