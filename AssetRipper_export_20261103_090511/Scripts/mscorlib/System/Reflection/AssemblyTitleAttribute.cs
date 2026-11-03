namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyTitleAttribute : Attribute
{
	private readonly string Title;

	public AssemblyTitleAttribute(string title)
	{
	}
}
