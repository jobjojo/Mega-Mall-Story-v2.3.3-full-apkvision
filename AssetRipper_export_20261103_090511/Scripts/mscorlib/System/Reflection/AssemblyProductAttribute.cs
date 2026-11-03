namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyProductAttribute : Attribute
{
	private readonly string Product;

	public AssemblyProductAttribute(string product)
	{
	}
}
