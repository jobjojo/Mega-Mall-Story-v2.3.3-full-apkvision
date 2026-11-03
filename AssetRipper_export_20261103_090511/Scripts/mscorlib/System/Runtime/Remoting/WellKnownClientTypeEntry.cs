using System.Runtime.InteropServices;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public class WellKnownClientTypeEntry : TypeEntry
{
	private Type obj_type;

	private string obj_url;

	private string app_url;

	public string ApplicationUrl => null;

	public Type ObjectType => null;

	public string ObjectUrl => null;

	public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
