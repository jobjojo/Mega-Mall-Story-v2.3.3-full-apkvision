namespace System.Diagnostics;

[AttributeUsage(AttributeTargets.Class)]
public sealed class SwitchLevelAttribute : Attribute
{
	private Type type;

	public Type SwitchLevelType
	{
		set
		{
		}
	}

	public SwitchLevelAttribute(Type switchLevelType)
	{
	}
}
