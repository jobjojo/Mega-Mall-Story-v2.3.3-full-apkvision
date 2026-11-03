namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyCompanyAttribute : Attribute
{
	private readonly string Company;

	public AssemblyCompanyAttribute(string company)
	{
	}
}
