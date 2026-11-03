namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyDelaySignAttribute : Attribute
{
	private readonly bool DelaySign;

	public AssemblyDelaySignAttribute(bool delaySign)
	{
	}
}
