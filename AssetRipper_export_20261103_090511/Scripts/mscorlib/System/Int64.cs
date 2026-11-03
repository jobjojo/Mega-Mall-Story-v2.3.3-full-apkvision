using System.Globalization;
using System.Runtime.Versioning;

namespace System;

[Serializable]
public readonly struct Int64 : IComparable, IConvertible, IFormattable, IComparable<long>, IEquatable<long>, ISpanFormattable
{
	private readonly long m_value;

	public const long MaxValue = 9223372036854775807L;

	public const long MinValue = -9223372036854775808L;

	public int CompareTo(object value)
	{
		return 0;
	}

	public int CompareTo(long value)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	[NonVersionable]
	public bool Equals(long obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	public string ToString(string format)
	{
		return null;
	}

	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
	{
		charsWritten = default;
		return false;
	}

	public static long Parse(string s)
	{
		return 0L;
	}

	public static long Parse(string s, NumberStyles style)
	{
		return 0L;
	}

	public static long Parse(string s, IFormatProvider provider)
	{
		return 0L;
	}

	public static long Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		return 0L;
	}

	public static bool TryParse(string s, out long result)
	{
		result = default;
		return false;
	}

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result)
	{
		result = default;
		return false;
	}

	public TypeCode GetTypeCode()
	{
		return TypeCode.Empty;
	}

	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	char IConvertible.ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return 0;
	}

	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return 0;
	}

	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}

	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}

	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return 0f;
	}

	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return 0m;
	}

	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return default;
	}

	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}
}
