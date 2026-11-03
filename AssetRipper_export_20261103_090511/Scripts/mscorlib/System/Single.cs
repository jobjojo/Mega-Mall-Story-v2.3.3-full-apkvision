using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System;

[Serializable]
public readonly struct Single : IComparable, IConvertible, IFormattable, IComparable<float>, IEquatable<float>, ISpanFormattable
{
	private readonly float m_value;

	public const float MinValue = -3.4028235E+38f;

	public const float Epsilon = 1E-45f;

	public const float MaxValue = 3.4028235E+38f;

	public const float PositiveInfinity = 1f / 0f;

	public const float NegativeInfinity = -1f / 0f;

	public const float NaN = 0f / 0f;

	internal const float NegativeZero = 0f;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[NonVersionable]
	public static bool IsInfinity(float f)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[NonVersionable]
	public static bool IsNaN(float f)
	{
		return false;
	}

	public int CompareTo(object value)
	{
		return 0;
	}

	public int CompareTo(float value)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(float obj)
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

	public static float Parse(string s, IFormatProvider provider)
	{
		return 0f;
	}

	public static float Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		return 0f;
	}

	public static bool TryParse(string s, out float result)
	{
		result = default;
		return false;
	}

	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out float result)
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
