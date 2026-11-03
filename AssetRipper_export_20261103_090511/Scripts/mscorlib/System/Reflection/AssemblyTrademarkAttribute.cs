namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyTrademarkAttribute : Attribute
{
	private readonly string Trademark;

	public AssemblyTrademarkAttribute(string trademark)
	{
	}
}
