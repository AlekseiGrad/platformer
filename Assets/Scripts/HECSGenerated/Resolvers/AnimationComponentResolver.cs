using Components;using System;using MessagePack;using HECSFramework.Serialize;using Commands;namespace HECSFramework.Core{	[MessagePackObject, Serializable]	public partial struct AnimationComponentResolver : IResolver<AnimationComponent>, IResolver<AnimationComponentResolver,AnimationComponent>, IData	{		public AnimationComponentResolver In(ref AnimationComponent animationcomponent)		{			return this;		}		public void Out(ref Entity entity)		{			var local = entity.GetComponent<AnimationComponent>();			Out(ref local);		}		public void Out(ref AnimationComponent animationcomponent)		{		}	}}