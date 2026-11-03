namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyInformationalVersionAttribute : Attribute
{
	private readonly string InformationalVersion;

	public AssemblyInformationalVersionAttribute(string informationalVersion)
	{
	}
}
