using System;
using Commands;
using HECSFramework.Core;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class HealthChangeSystem : BaseSystem, IReactCommand<DealDamageCommand>
    {
        private HealthComponent healthComponent;

        public override void InitSystem()
        {
            healthComponent = Owner.GetComponent<HealthComponent>();
        }

        public void CommandReact(DealDamageCommand command)
        {
            healthComponent.HealthCurrentValue -= command.Value;
            if (healthComponent.HealthCurrentValue < 0)
            {
                Owner.Command(new IsDeadCommand());
            }
        }
    }
}