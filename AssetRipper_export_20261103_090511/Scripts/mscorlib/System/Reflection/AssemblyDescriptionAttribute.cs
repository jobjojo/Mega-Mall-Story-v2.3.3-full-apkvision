namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyDescriptionAttribute : Attribute
{
	private readonly string Description;

	public AssemblyDescriptionAttribute(string description)
	{
	}
}
