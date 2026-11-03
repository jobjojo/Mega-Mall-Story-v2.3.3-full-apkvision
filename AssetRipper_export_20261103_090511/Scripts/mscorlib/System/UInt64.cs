using System.Globalization;
using System.Runtime.Versioning;

namespace System;

[Serializable]
[CLSCompliant(false)]
public readonly struct UInt64 : IComparable, IConvertible, IFormattable, IComparable<ulong>, IEquatable<ulong>, ISpanFormattable
{
	private readonly ulong m_value;

	public const ulong MaxValue = 18446744073709551615uL;

	public const ulong MinValue = 0uL;

	public int CompareTo(object value)
	{
		return 0;
	}

	public int CompareTo(ulong value)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	[NonVersionable]
	public bool Equals(ulong obj)
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

	[CLSCompliant(false)]
	public static ulong Parse(string s, IFormatProvider provider)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		return 0uL;
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
