using System.Runtime.Versioning;

namespace System;

[Serializable]
public readonly struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool>
{
	private readonly bool m_value;

	internal const int True = 1;

	internal const int False = 0;

	internal const string TrueLiteral = "True";

	internal const string FalseLiteral = "False";

	public static readonly string TrueString;

	public static readonly string FalseString;

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

	public override bool Equals(object obj)
	{
		return false;
	}

	[NonVersionable]
	public bool Equals(bool obj)
	{
		return false;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public int CompareTo(bool value)
	{
		return 0;
	}

	public static bool Parse(string value)
	{
		return false;
	}

	public static bool Parse(ReadOnlySpan<char> value)
	{
		return false;
	}

	public static bool TryParse(ReadOnlySpan<char> value, out bool result)
	{
		result = default;
		return false;
	}

	private static ReadOnlySpan<char> TrimWhiteSpaceAndNull(ReadOnlySpan<char> value)
	{
		return default;
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
