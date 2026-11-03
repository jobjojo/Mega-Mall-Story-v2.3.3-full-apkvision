namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyDefaultAliasAttribute : Attribute
{
	private readonly string DefaultAlias;

	public AssemblyDefaultAliasAttribute(string defaultAlias)
	{
	}
}
