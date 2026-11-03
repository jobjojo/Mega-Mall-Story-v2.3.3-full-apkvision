using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public class ActivatedClientTypeEntry : TypeEntry
{
	private string applicationUrl;

	private Type obj_type;

	public string ApplicationUrl => null;

	public IContextAttribute[] ContextAttributes => null;

	public Type ObjectType => null;

	public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
