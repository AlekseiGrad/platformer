using Components;using System;using MessagePack;using HECSFramework.Serialize;using Commands;namespace HECSFramework.Core{	[MessagePackObject, Serializable]	public partial struct Rigidbody2DProviderComponentResolver : IResolver<Rigidbody2DProviderComponent>, IResolver<Rigidbody2DProviderComponentResolver,Rigidbody2DProviderComponent>, IData	{		public Rigidbody2DProviderComponentResolver In(ref Rigidbody2DProviderComponent rigidbody2dprovidercomponent)		{			return this;		}		public void Out(ref Entity entity)		{			var local = entity.GetComponent<Rigidbody2DProviderComponent>();			Out(ref local);		}		public void Out(ref Rigidbody2DProviderComponent rigidbody2dprovidercomponent)		{		}	}}