namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyFileVersionAttribute : Attribute
{
	private readonly string Version;

	public AssemblyFileVersionAttribute(string version)
	{
	}
}
