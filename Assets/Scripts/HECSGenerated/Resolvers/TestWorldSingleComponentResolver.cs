using Components;using System;using MessagePack;using HECSFramework.Serialize;using Commands;namespace HECSFramework.Core{	[MessagePackObject, Serializable]	public partial struct TestWorldSingleComponentResolver : IResolver<TestWorldSingleComponent>, IResolver<TestWorldSingleComponentResolver,TestWorldSingleComponent>, IData	{		public TestWorldSingleComponentResolver In(ref TestWorldSingleComponent testworldsinglecomponent)		{			return this;		}		public void Out(ref Entity entity)		{			var local = entity.GetComponent<TestWorldSingleComponent>();			Out(ref local);		}		public void Out(ref TestWorldSingleComponent testworldsinglecomponent)		{		}	}}