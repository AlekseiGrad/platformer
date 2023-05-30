using Components;using System;using MessagePack;using HECSFramework.Serialize;using Commands;namespace HECSFramework.Core{	[MessagePackObject, Serializable]	public partial struct AnimatorStateComponentResolver : IResolver<AnimatorStateComponent>, IResolver<AnimatorStateComponentResolver,AnimatorStateComponent>, IData	{		[Key(0)]		public AnimatorStateResolver State;		public AnimatorStateComponentResolver In(ref AnimatorStateComponent animatorstatecomponent)		{			this.State = new AnimatorStateResolver().In(ref animatorstatecomponent.State);			return this;		}		public void Out(ref Entity entity)		{			var local = entity.GetComponent<AnimatorStateComponent>();			Out(ref local);		}		public void Out(ref AnimatorStateComponent animatorstatecomponent)		{			this.State.Out(ref animatorstatecomponent.State);		}	}}