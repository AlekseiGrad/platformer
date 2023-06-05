using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class Collider2dProviderComponent : BaseComponent, IHaveActor, IInitable
    {
        public Collider2D Collider2D;
        public Actor Actor { get; set; }
        public void Init()
        {
            Collider2D = Actor.GetComponent<Collider2D>();
        }
    }
}