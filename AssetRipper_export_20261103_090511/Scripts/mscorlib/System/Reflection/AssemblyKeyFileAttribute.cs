namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyKeyFileAttribute : Attribute
{
	private readonly string KeyFile;

	public AssemblyKeyFileAttribute(string keyFile)
	{
	}
}
