using System.Runtime.InteropServices;

namespace System;

[ComVisible(true)]
public static class Buffer
{
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount)
	{
		return false;
	}

	internal unsafe static int IndexOfByte(byte* src, byte value, int index, int count)
	{
		return 0;
	}

	private static int _ByteLength(Array array)
	{
		return 0;
	}

	internal unsafe static void ZeroMemory(byte* src, long len)
	{
	}

	internal unsafe static void InternalMemcpy(byte* dest, byte* src, int count)
	{
	}

	public static int ByteLength(Array array)
	{
		return 0;
	}

	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count)
	{
	}

	[CLSCompliant(false)]
	public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy)
	{
	}

	internal unsafe static void memcpy4(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void memcpy2(byte* dest, byte* src, int size)
	{
	}

	private unsafe static void memcpy1(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void Memcpy(byte* dest, byte* src, int len)
	{
	}

	internal unsafe static void Memmove(byte* dest, byte* src, uint len)
	{
	}

	internal static void Memmove<T>(ref T destination, ref T source, ulong elementCount)
	{
	}
}
