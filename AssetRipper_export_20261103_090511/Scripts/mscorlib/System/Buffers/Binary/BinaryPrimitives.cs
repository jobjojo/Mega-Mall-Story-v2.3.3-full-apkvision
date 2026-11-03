using System.Runtime.CompilerServices;

namespace System.Buffers.Binary;

public static class BinaryPrimitives
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short ReverseEndianness(short value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int ReverseEndianness(int value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long ReverseEndianness(long value)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[CLSCompliant(false)]
	public static ushort ReverseEndianness(ushort value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[CLSCompliant(false)]
	public static uint ReverseEndianness(uint value)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[CLSCompliant(false)]
	public static ulong ReverseEndianness(ulong value)
	{
		return 0uL;
	}
}
