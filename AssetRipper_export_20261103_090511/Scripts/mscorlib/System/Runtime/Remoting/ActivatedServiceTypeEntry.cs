using System.Runtime.InteropServices;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public class ActivatedServiceTypeEntry : TypeEntry
{
	private Type obj_type;

	public Type ObjectType => null;

	public ActivatedServiceTypeEntry(string typeName, string assemblyName)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
