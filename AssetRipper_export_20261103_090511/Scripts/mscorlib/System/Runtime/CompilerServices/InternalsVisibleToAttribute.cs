namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
public sealed class InternalsVisibleToAttribute : Attribute
{
	private string _assemblyName;

	private bool _allInternalsVisible;

	public bool AllInternalsVisible
	{
		set
		{
		}
	}

	public InternalsVisibleToAttribute(string assemblyName)
	{
	}
}
