using System.Globalization;
using System.Runtime.Versioning;

namespace System;

[Serializable]
public readonly struct Char : IComparable, IComparable<char>, IEquatable<char>, IConvertible
{
	private readonly char m_value;

	public const char MaxValue = '\uffff';

	public const char MinValue = '\0';

	private static readonly byte[] s_categoryForLatin1;

	internal const int UNICODE_PLANE00_END = 65535;

	internal const int UNICODE_PLANE01_START = 65536;

	internal const int UNICODE_PLANE16_END = 1114111;

	internal const int HIGH_SURROGATE_START = 55296;

	internal const int LOW_SURROGATE_END = 57343;

	private static bool IsLatin1(char ch)
	{
		return false;
	}

	private static bool IsAscii(char ch)
	{
		return false;
	}

	private static UnicodeCategory GetLatin1UnicodeCategory(char ch)
	{
		return UnicodeCategory.UppercaseLetter;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	[NonVersionable]
	public bool Equals(char obj)
	{
		return false;
	}

	public int CompareTo(object value)
	{
		return 0;
	}

	public int CompareTo(char value)
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

	public static string ToString(char c)
	{
		return null;
	}

	public static char Parse(string s)
	{
		return '\0';
	}

	public static bool IsDigit(char c)
	{
		return false;
	}

	internal static bool CheckLetter(UnicodeCategory uc)
	{
		return false;
	}

	public static bool IsLetter(char c)
	{
		return false;
	}

	private static bool IsWhiteSpaceLatin1(char c)
	{
		return false;
	}

	public static bool IsWhiteSpace(char c)
	{
		return false;
	}

	public static bool IsUpper(char c)
	{
		return false;
	}

	public static bool IsLower(char c)
	{
		return false;
	}

	internal static bool CheckLetterOrDigit(UnicodeCategory uc)
	{
		return false;
	}

	public static bool IsLetterOrDigit(char c)
	{
		return false;
	}

	public static char ToUpper(char c)
	{
		return '\0';
	}

	public static char ToUpperInvariant(char c)
	{
		return '\0';
	}

	public static char ToLower(char c)
	{
		return '\0';
	}

	public static char ToLowerInvariant(char c)
	{
		return '\0';
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

	public static bool IsControl(char c)
	{
		return false;
	}

	public static bool IsLetterOrDigit(string s, int index)
	{
		return false;
	}

	public static bool IsSurrogate(char c)
	{
		return false;
	}

	public static bool IsSurrogate(string s, int index)
	{
		return false;
	}

	public static bool IsWhiteSpace(string s, int index)
	{
		return false;
	}

	public static UnicodeCategory GetUnicodeCategory(char c)
	{
		return UnicodeCategory.UppercaseLetter;
	}

	public static UnicodeCategory GetUnicodeCategory(string s, int index)
	{
		return UnicodeCategory.UppercaseLetter;
	}

	public static bool IsHighSurrogate(char c)
	{
		return false;
	}

	public static bool IsHighSurrogate(string s, int index)
	{
		return false;
	}

	public static bool IsLowSurrogate(char c)
	{
		return false;
	}

	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
	{
		return false;
	}

	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
	{
		return 0;
	}
}
