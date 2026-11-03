using System.Runtime.CompilerServices;

namespace System;

public static class Convert
{
	private static readonly sbyte[] s_decodingMap;

	internal static readonly Type[] ConvertTypes;

	private static readonly Type EnumType;

	internal static readonly char[] base64Table;

	public static readonly object DBNull;

	private static bool TryDecodeFromUtf16(ReadOnlySpan<char> utf16, Span<byte> bytes, out int consumed, out int written)
	{
		consumed = default;
		written = default;
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int Decode(ref char encodedChars, ref sbyte decodingMap)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void WriteThreeLowOrderBytes(ref byte destination, int value)
	{
	}

	public static TypeCode GetTypeCode(object value)
	{
		return TypeCode.Empty;
	}

	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider)
	{
		return null;
	}

	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider)
	{
		return null;
	}

	public static object ChangeType(object value, Type conversionType)
	{
		return null;
	}

	public static object ChangeType(object value, Type conversionType, IFormatProvider provider)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowCharOverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowByteOverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowSByteOverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowInt16OverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowUInt16OverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowInt32OverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowUInt32OverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowInt64OverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowUInt64OverflowException()
	{
	}

	public static bool ToBoolean(object value)
	{
		return false;
	}

	public static bool ToBoolean(object value, IFormatProvider provider)
	{
		return false;
	}

	[CLSCompliant(false)]
	public static bool ToBoolean(sbyte value)
	{
		return false;
	}

	public static bool ToBoolean(byte value)
	{
		return false;
	}

	public static bool ToBoolean(short value)
	{
		return false;
	}

	[CLSCompliant(false)]
	public static bool ToBoolean(ushort value)
	{
		return false;
	}

	public static bool ToBoolean(int value)
	{
		return false;
	}

	[CLSCompliant(false)]
	public static bool ToBoolean(uint value)
	{
		return false;
	}

	public static bool ToBoolean(long value)
	{
		return false;
	}

	[CLSCompliant(false)]
	public static bool ToBoolean(ulong value)
	{
		return false;
	}

	public static bool ToBoolean(string value)
	{
		return false;
	}

	public static bool ToBoolean(string value, IFormatProvider provider)
	{
		return false;
	}

	public static bool ToBoolean(float value)
	{
		return false;
	}

	public static bool ToBoolean(double value)
	{
		return false;
	}

	public static bool ToBoolean(decimal value)
	{
		return false;
	}

	public static char ToChar(object value)
	{
		return '\0';
	}

	public static char ToChar(object value, IFormatProvider provider)
	{
		return '\0';
	}

	[CLSCompliant(false)]
	public static char ToChar(sbyte value)
	{
		return '\0';
	}

	public static char ToChar(byte value)
	{
		return '\0';
	}

	public static char ToChar(short value)
	{
		return '\0';
	}

	[CLSCompliant(false)]
	public static char ToChar(ushort value)
	{
		return '\0';
	}

	public static char ToChar(int value)
	{
		return '\0';
	}

	[CLSCompliant(false)]
	public static char ToChar(uint value)
	{
		return '\0';
	}

	public static char ToChar(long value)
	{
		return '\0';
	}

	[CLSCompliant(false)]
	public static char ToChar(ulong value)
	{
		return '\0';
	}

	public static char ToChar(string value, IFormatProvider provider)
	{
		return '\0';
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(object value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(object value, IFormatProvider provider)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(bool value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(char value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(byte value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(short value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(ushort value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(int value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(uint value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(long value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(ulong value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(float value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(double value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(decimal value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(string value, IFormatProvider provider)
	{
		return 0;
	}

	public static byte ToByte(object value)
	{
		return 0;
	}

	public static byte ToByte(object value, IFormatProvider provider)
	{
		return 0;
	}

	public static byte ToByte(bool value)
	{
		return 0;
	}

	public static byte ToByte(char value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static byte ToByte(sbyte value)
	{
		return 0;
	}

	public static byte ToByte(short value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static byte ToByte(ushort value)
	{
		return 0;
	}

	public static byte ToByte(int value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static byte ToByte(uint value)
	{
		return 0;
	}

	public static byte ToByte(long value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static byte ToByte(ulong value)
	{
		return 0;
	}

	public static byte ToByte(float value)
	{
		return 0;
	}

	public static byte ToByte(double value)
	{
		return 0;
	}

	public static byte ToByte(decimal value)
	{
		return 0;
	}

	public static byte ToByte(string value)
	{
		return 0;
	}

	public static byte ToByte(string value, IFormatProvider provider)
	{
		return 0;
	}

	public static short ToInt16(object value)
	{
		return 0;
	}

	public static short ToInt16(object value, IFormatProvider provider)
	{
		return 0;
	}

	public static short ToInt16(bool value)
	{
		return 0;
	}

	public static short ToInt16(char value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static short ToInt16(sbyte value)
	{
		return 0;
	}

	public static short ToInt16(byte value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static short ToInt16(ushort value)
	{
		return 0;
	}

	public static short ToInt16(int value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static short ToInt16(uint value)
	{
		return 0;
	}

	public static short ToInt16(long value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static short ToInt16(ulong value)
	{
		return 0;
	}

	public static short ToInt16(float value)
	{
		return 0;
	}

	public static short ToInt16(double value)
	{
		return 0;
	}

	public static short ToInt16(decimal value)
	{
		return 0;
	}

	public static short ToInt16(string value, IFormatProvider provider)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(object value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(object value, IFormatProvider provider)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(bool value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(char value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(sbyte value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(byte value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(short value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(int value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(uint value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(long value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(ulong value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(float value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(double value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(decimal value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(string value, IFormatProvider provider)
	{
		return 0;
	}

	public static int ToInt32(object value)
	{
		return 0;
	}

	public static int ToInt32(object value, IFormatProvider provider)
	{
		return 0;
	}

	public static int ToInt32(bool value)
	{
		return 0;
	}

	public static int ToInt32(char value)
	{
		return 0;
	}

	public static int ToInt32(byte value)
	{
		return 0;
	}

	public static int ToInt32(short value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static int ToInt32(ushort value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static int ToInt32(uint value)
	{
		return 0;
	}

	public static int ToInt32(long value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static int ToInt32(ulong value)
	{
		return 0;
	}

	public static int ToInt32(float value)
	{
		return 0;
	}

	public static int ToInt32(double value)
	{
		return 0;
	}

	public static int ToInt32(decimal value)
	{
		return 0;
	}

	public static int ToInt32(string value, IFormatProvider provider)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(object value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(object value, IFormatProvider provider)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(bool value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(char value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(sbyte value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(byte value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(short value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(ushort value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(int value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(long value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(ulong value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(float value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(double value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(decimal value)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(string value, IFormatProvider provider)
	{
		return 0u;
	}

	public static long ToInt64(object value)
	{
		return 0L;
	}

	public static long ToInt64(object value, IFormatProvider provider)
	{
		return 0L;
	}

	public static long ToInt64(bool value)
	{
		return 0L;
	}

	public static long ToInt64(char value)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static long ToInt64(sbyte value)
	{
		return 0L;
	}

	public static long ToInt64(byte value)
	{
		return 0L;
	}

	public static long ToInt64(short value)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static long ToInt64(ushort value)
	{
		return 0L;
	}

	public static long ToInt64(int value)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static long ToInt64(uint value)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static long ToInt64(ulong value)
	{
		return 0L;
	}

	public static long ToInt64(float value)
	{
		return 0L;
	}

	public static long ToInt64(double value)
	{
		return 0L;
	}

	public static long ToInt64(decimal value)
	{
		return 0L;
	}

	public static long ToInt64(string value)
	{
		return 0L;
	}

	public static long ToInt64(string value, IFormatProvider provider)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(object value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(object value, IFormatProvider provider)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(bool value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(char value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(sbyte value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(byte value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(short value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(ushort value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(int value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(uint value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(long value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(float value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(double value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(decimal value)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(string value, IFormatProvider provider)
	{
		return 0uL;
	}

	public static float ToSingle(object value)
	{
		return 0f;
	}

	public static float ToSingle(object value, IFormatProvider provider)
	{
		return 0f;
	}

	[CLSCompliant(false)]
	public static float ToSingle(sbyte value)
	{
		return 0f;
	}

	public static float ToSingle(byte value)
	{
		return 0f;
	}

	public static float ToSingle(short value)
	{
		return 0f;
	}

	[CLSCompliant(false)]
	public static float ToSingle(ushort value)
	{
		return 0f;
	}

	public static float ToSingle(int value)
	{
		return 0f;
	}

	[CLSCompliant(false)]
	public static float ToSingle(uint value)
	{
		return 0f;
	}

	public static float ToSingle(long value)
	{
		return 0f;
	}

	[CLSCompliant(false)]
	public static float ToSingle(ulong value)
	{
		return 0f;
	}

	public static float ToSingle(double value)
	{
		return 0f;
	}

	public static float ToSingle(decimal value)
	{
		return 0f;
	}

	public static float ToSingle(string value)
	{
		return 0f;
	}

	public static float ToSingle(string value, IFormatProvider provider)
	{
		return 0f;
	}

	public static float ToSingle(bool value)
	{
		return 0f;
	}

	public static double ToDouble(object value)
	{
		return 0.0;
	}

	public static double ToDouble(object value, IFormatProvider provider)
	{
		return 0.0;
	}

	[CLSCompliant(false)]
	public static double ToDouble(sbyte value)
	{
		return 0.0;
	}

	public static double ToDouble(byte value)
	{
		return 0.0;
	}

	public static double ToDouble(short value)
	{
		return 0.0;
	}

	[CLSCompliant(false)]
	public static double ToDouble(ushort value)
	{
		return 0.0;
	}

	public static double ToDouble(int value)
	{
		return 0.0;
	}

	[CLSCompliant(false)]
	public static double ToDouble(uint value)
	{
		return 0.0;
	}

	public static double ToDouble(long value)
	{
		return 0.0;
	}

	[CLSCompliant(false)]
	public static double ToDouble(ulong value)
	{
		return 0.0;
	}

	public static double ToDouble(float value)
	{
		return 0.0;
	}

	public static double ToDouble(decimal value)
	{
		return 0.0;
	}

	public static double ToDouble(string value, IFormatProvider provider)
	{
		return 0.0;
	}

	public static double ToDouble(bool value)
	{
		return 0.0;
	}

	public static decimal ToDecimal(object value, IFormatProvider provider)
	{
		return 0m;
	}

	[CLSCompliant(false)]
	public static decimal ToDecimal(sbyte value)
	{
		return 0m;
	}

	public static decimal ToDecimal(byte value)
	{
		return 0m;
	}

	public static decimal ToDecimal(short value)
	{
		return 0m;
	}

	[CLSCompliant(false)]
	public static decimal ToDecimal(ushort value)
	{
		return 0m;
	}

	public static decimal ToDecimal(int value)
	{
		return 0m;
	}

	[CLSCompliant(false)]
	public static decimal ToDecimal(uint value)
	{
		return 0m;
	}

	public static decimal ToDecimal(long value)
	{
		return 0m;
	}

	[CLSCompliant(false)]
	public static decimal ToDecimal(ulong value)
	{
		return 0m;
	}

	public static decimal ToDecimal(float value)
	{
		return 0m;
	}

	public static decimal ToDecimal(double value)
	{
		return 0m;
	}

	public static decimal ToDecimal(string value, IFormatProvider provider)
	{
		return 0m;
	}

	public static decimal ToDecimal(bool value)
	{
		return 0m;
	}

	public static DateTime ToDateTime(string value, IFormatProvider provider)
	{
		return default;
	}

	public static string ToString(object value, IFormatProvider provider)
	{
		return null;
	}

	public static string ToString(char value, IFormatProvider provider)
	{
		return null;
	}

	public static string ToString(int value, IFormatProvider provider)
	{
		return null;
	}

	public static string ToString(int value, int toBase)
	{
		return null;
	}

	public static string ToBase64String(byte[] inArray)
	{
		return null;
	}

	public static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = Base64FormattingOptions.None)
	{
		return null;
	}

	private unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
	{
		return 0;
	}

	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
	{
		return 0;
	}

	public static byte[] FromBase64String(string s)
	{
		return null;
	}

	public static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten)
	{
		bytesWritten = default;
		return false;
	}

	private static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<char> chars, Span<char> tempBuffer, out int consumed, out int charsWritten)
	{
		consumed = default;
		charsWritten = default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool IsSpace(this char c)
	{
		return false;
	}

	private unsafe static byte[] FromBase64CharPtr(char* inputPtr, int inputLength)
	{
		return null;
	}

	private unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
	{
		return 0;
	}
}
