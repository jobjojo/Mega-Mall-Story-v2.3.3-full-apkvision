using System.Runtime.InteropServices;

namespace kairo.unity.secure;

[StructLayout((LayoutKind)2)]
internal struct DoubleUnion
{
	[FieldOffset(0)]
	public double Value;

	[FieldOffset(0)]
	public long Bits;
}
