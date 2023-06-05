using System;
using Commands;
using HECSFramework.Unity;
using HECSFramework.Core;
using UnityEngine;
using Components;
using Helpers;

namespace Systems
{
	[Serializable][Documentation(Doc.NONE, "")]
    public sealed class DealDamageSystemSystem : BaseSystem, IReactCommand<Collision2dCommand>
    {
        private AttackComponent attackComponent;
        private CollisionTargetsComponent tgComponent;

        public override void InitSystem()
        {
            attackComponent = Owner.GetComponent<AttackComponent>();
            tgComponent = Owner.GetComponent<CollisionTargetsComponent>();
        }

        public void CommandReact(Collision2dCommand command)
        {

            if (command.Collision.collider.TryGetActorFromCollision(out Actor actor)
                &&
                actor.Entity.ContainsMask<CharacterTagComponent>())
            {
                foreach(var t in tgComponent.Targets)
                {
                   
                }
            }
        }
    }
}