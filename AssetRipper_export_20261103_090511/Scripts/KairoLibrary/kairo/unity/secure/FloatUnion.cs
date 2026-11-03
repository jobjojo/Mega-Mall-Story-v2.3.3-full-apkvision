using System.Runtime.InteropServices;

namespace kairo.unity.secure;

[StructLayout((LayoutKind)2)]
internal struct FloatUnion
{
	[FieldOffset(0)]
	public float Value;

	[FieldOffset(0)]
	public int Bits;
}
