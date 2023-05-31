using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class CharacterDamageSystem : BaseSystem, IReactCommand<InputCommand>
    {
        private EntitiesFilter characterFilter;

        public override void InitSystem()
        {
            characterFilter = Owner.World.GetFilter(Filter.Get<CharacterComponent, AttackComponent>());
        }

        public void CommandReact(InputCommand command)
        {
            
            foreach (var entity in characterFilter)
            {
                if (InputIdentifierMap.Attack == command.Index)
                {
                    
                }
            }
        }
    }
}