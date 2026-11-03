using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System;

[Serializable]
public readonly struct Double : IComparable, IConvertible, IFormattable, IComparable<double>, IEquatable<double>, ISpanFormattable
{
	private readonly double m_value;

	public const double MinValue = -1.7976931348623157E+308;

	public const double MaxValue = 1.7976931348623157E+308;

	public const double Epsilon = 5E-324;

	public const double NegativeInfinity = -1.0 / 0.0;

	public const double PositiveInfinity = 1.0 / 0.0;

	public const double NaN = 0.0 / 0.0;

	internal const double NegativeZero = -0.0;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[NonVersionable]
	public static bool IsFinite(double d)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[NonVersionable]
	public static bool IsInfinity(double d)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[NonVersionable]
	public static bool IsNaN(double d)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[NonVersionable]
	public static bool IsNegative(double d)
	{
		return false;
	}

	public int CompareTo(object value)
	{
		return 0;
	}

	public int CompareTo(double value)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(double obj)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(string format)
	{
		return null;
	}

	public string ToString(IFormatProvider provider)
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

	public static double Parse(string s)
	{
		return 0.0;
	}

	public static double Parse(string s, IFormatProvider provider)
	{
		return 0.0;
	}

	public static double Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		return 0.0;
	}

	public static bool TryParse(string s, out double result)
	{
		result = default;
		return false;
	}

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result)
	{
		result = default;
		return false;
	}

	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out double result)
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
