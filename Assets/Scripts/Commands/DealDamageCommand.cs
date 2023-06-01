using HECSFramework.Core;

namespace Commands
{
    [Documentation(Doc.NONE, "")]
	public struct DealDamageCommand : ICommand
	{
		public float Value;
	}
}