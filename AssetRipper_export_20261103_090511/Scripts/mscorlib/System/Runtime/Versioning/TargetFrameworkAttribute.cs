namespace System.Runtime.Versioning;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
public sealed class TargetFrameworkAttribute : Attribute
{
	private string _frameworkName;

	private string _frameworkDisplayName;

	public string FrameworkDisplayName
	{
		set
		{
		}
	}

	public TargetFrameworkAttribute(string frameworkName)
	{
	}
}
