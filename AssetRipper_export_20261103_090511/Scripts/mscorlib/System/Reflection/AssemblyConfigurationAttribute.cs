namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyConfigurationAttribute : Attribute
{
	private readonly string Configuration;

	public AssemblyConfigurationAttribute(string configuration)
	{
	}
}
