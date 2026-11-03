using System.Runtime.InteropServices;

namespace System.Reflection;

[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class LocalVariableInfo
{
	internal Type type;

	internal bool is_pinned;

	internal ushort position;

	protected LocalVariableInfo()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
