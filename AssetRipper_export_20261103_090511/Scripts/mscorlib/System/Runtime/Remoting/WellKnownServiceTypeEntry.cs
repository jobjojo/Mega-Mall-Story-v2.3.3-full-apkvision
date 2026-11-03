using System.Runtime.InteropServices;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public class WellKnownServiceTypeEntry : TypeEntry
{
	private Type obj_type;

	private string obj_uri;

	private WellKnownObjectMode obj_mode;

	public WellKnownObjectMode Mode => (WellKnownObjectMode)0;

	public Type ObjectType => null;

	public string ObjectUri => null;

	public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
