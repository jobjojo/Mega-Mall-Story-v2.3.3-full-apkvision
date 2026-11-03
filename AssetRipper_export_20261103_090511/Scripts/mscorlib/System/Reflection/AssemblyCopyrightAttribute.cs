namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyCopyrightAttribute : Attribute
{
	private readonly string Copyright;

	public AssemblyCopyrightAttribute(string copyright)
	{
	}
}
