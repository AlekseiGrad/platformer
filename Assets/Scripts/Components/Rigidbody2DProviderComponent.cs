using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class Rigidbody2DProviderComponent : BaseComponent, IInitable, IHaveActor
    {

        public Rigidbody2D Rigidbody;
        public Actor Actor { get; set; }
        
        
        public void Init()
        {
            Rigidbody = Actor.GetComponent<Rigidbody2D>();
        }

        
    }
}