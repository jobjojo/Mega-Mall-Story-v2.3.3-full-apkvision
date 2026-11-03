using System.Runtime.InteropServices;

namespace System.Diagnostics;

[ComVisible(true)]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public sealed class DebuggerBrowsableAttribute : Attribute
{
	private DebuggerBrowsableState state;

	public DebuggerBrowsableAttribute(DebuggerBrowsableState state)
	{
	}
}
