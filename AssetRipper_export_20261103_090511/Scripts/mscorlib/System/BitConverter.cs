using System.Runtime.CompilerServices;

namespace System;

public static class BitConverter
{
	[Intrinsic]
	public static readonly bool IsLittleEndian;

	public static byte[] GetBytes(short value)
	{
		return null;
	}

	public static byte[] GetBytes(int value)
	{
		return null;
	}

	public static byte[] GetBytes(long value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static byte[] GetBytes(ushort value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static byte[] GetBytes(uint value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static bool TryWriteBytes(Span<byte> destination, uint value)
	{
		return false;
	}

	[CLSCompliant(false)]
	public static byte[] GetBytes(ulong value)
	{
		return null;
	}

	public static byte[] GetBytes(float value)
	{
		return null;
	}

	public static byte[] GetBytes(double value)
	{
		return null;
	}

	public static short ToInt16(byte[] value, int startIndex)
	{
		return 0;
	}

	public static int ToInt32(byte[] value, int startIndex)
	{
		return 0;
	}

	public static long ToInt64(byte[] value, int startIndex)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(byte[] value, int startIndex)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(byte[] value, int startIndex)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(byte[] value, int startIndex)
	{
		return 0uL;
	}

	public static float ToSingle(byte[] value, int startIndex)
	{
		return 0f;
	}

	public static double ToDouble(byte[] value, int startIndex)
	{
		return 0.0;
	}

	public static string ToString(byte[] value, int startIndex, int length)
	{
		return null;
	}

	public static string ToString(byte[] value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long DoubleToInt64Bits(double value)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Int64BitsToDouble(long value)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int SingleToInt32Bits(float value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Int32BitsToSingle(int value)
	{
		return 0f;
	}

	static BitConverter()
	{
	}
}
