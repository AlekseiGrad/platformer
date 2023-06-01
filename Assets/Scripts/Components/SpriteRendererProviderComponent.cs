using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class SpriteRendererProviderComponent : BaseComponent, IHaveActor, IInitable
    {
        public SpriteRenderer SpriteRenderer;
        public Actor Actor { get; set; }
        public void Init()
        {
            SpriteRenderer = Actor.GetComponent<SpriteRenderer>();
        }
    }
}