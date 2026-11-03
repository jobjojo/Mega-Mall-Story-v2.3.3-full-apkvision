using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

[StructLayout((LayoutKind)0)]
public sealed class LocalBuilder : LocalVariableInfo
{
	private string name;

	internal ILGenerator ilgen;

	private int startOffset;

	private int endOffset;
}
