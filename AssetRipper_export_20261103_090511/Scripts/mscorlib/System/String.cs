using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

namespace System;

[Serializable]
public sealed class String : IComparable, IEnumerable, IEnumerable<char>, IComparable<string>, IEquatable<string>, IConvertible, ICloneable
{
	private enum TrimType
	{
		Head = 0,
		Tail = 1,
		Both = 2
	}

	[StructLayout((LayoutKind)2, Size = 32)]
	private struct ProbabilisticMap
	{
	}

	private const int StackallocIntBufferSizeLimit = 128;

	private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7;

	private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3;

	private const int PROBABILISTICMAP_SIZE = 8;

	[NonSerialized]
	private int _stringLength;

	[NonSerialized]
	private char _firstChar;

	public static readonly string Empty;

	public int Length => 0;

	[IndexerName("Chars")]
	public char this[int index]
	{
		[Intrinsic]
		get
		{
			return '\0';
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool EqualsHelper(string strA, string strB)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB)
	{
		return 0;
	}

	private static int CompareOrdinalHelper(string strA, string strB)
	{
		return 0;
	}

	public static int Compare(string strA, string strB, bool ignoreCase)
	{
		return 0;
	}

	public static int Compare(string strA, string strB, StringComparison comparisonType)
	{
		return 0;
	}

	public static int Compare(string strA, int indexA, string strB, int indexB, int length)
	{
		return 0;
	}

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase)
	{
		return 0;
	}

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
	{
		return 0;
	}

	public static int CompareOrdinal(string strA, string strB)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
	{
		return 0;
	}

	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
	{
		return 0;
	}

	public int CompareTo(object value)
	{
		return 0;
	}

	public int CompareTo(string strB)
	{
		return 0;
	}

	public bool EndsWith(string value)
	{
		return false;
	}

	public bool EndsWith(string value, StringComparison comparisonType)
	{
		return false;
	}

	public bool EndsWith(string value, bool ignoreCase, CultureInfo culture)
	{
		return false;
	}

	public bool EndsWith(char value)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(string value)
	{
		return false;
	}

	public bool Equals(string value, StringComparison comparisonType)
	{
		return false;
	}

	public static bool Equals(string a, string b)
	{
		return false;
	}

	public static bool Equals(string a, string b, StringComparison comparisonType)
	{
		return false;
	}

	public static bool operator ==(string a, string b)
	{
		return false;
	}

	public static bool operator !=(string a, string b)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal int GetLegacyNonRandomizedHashCode()
	{
		return 0;
	}

	public bool StartsWith(string value)
	{
		return false;
	}

	public bool StartsWith(string value, StringComparison comparisonType)
	{
		return false;
	}

	public bool StartsWith(string value, bool ignoreCase, CultureInfo culture)
	{
		return false;
	}

	internal static void CheckStringComparison(StringComparison comparisonType)
	{
	}

	private static void FillStringChecked(string dest, int destPos, string src)
	{
	}

	public static string Concat(string str0, string str1)
	{
		return null;
	}

	public static string Concat(string str0, string str1, string str2)
	{
		return null;
	}

	public static string Concat(string str0, string str1, string str2, string str3)
	{
		return null;
	}

	public static string Concat(params string[] values)
	{
		return null;
	}

	public static string Format(string format, object arg0)
	{
		return null;
	}

	public static string Format(string format, object arg0, object arg1)
	{
		return null;
	}

	public static string Format(string format, object arg0, object arg1, object arg2)
	{
		return null;
	}

	public static string Format(string format, params object[] args)
	{
		return null;
	}

	public static string Format(IFormatProvider provider, string format, object arg0)
	{
		return null;
	}

	public static string Format(IFormatProvider provider, string format, object arg0, object arg1)
	{
		return null;
	}

	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
	{
		return null;
	}

	public static string Format(IFormatProvider provider, string format, params object[] args)
	{
		return null;
	}

	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args)
	{
		return null;
	}

	public string Insert(int startIndex, string value)
	{
		return null;
	}

	public static string Join(string separator, params string[] value)
	{
		return null;
	}

	public static string Join<T>(string separator, IEnumerable<T> values)
	{
		return null;
	}

	public static string Join(string separator, IEnumerable<string> values)
	{
		return null;
	}

	public static string Join(string separator, string[] value, int startIndex, int count)
	{
		return null;
	}

	private unsafe static string JoinCore<T>(char* separator, int separatorLength, IEnumerable<T> values)
	{
		return null;
	}

	private unsafe static string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count)
	{
		return null;
	}

	public string PadLeft(int totalWidth)
	{
		return null;
	}

	public string PadLeft(int totalWidth, char paddingChar)
	{
		return null;
	}

	public string PadRight(int totalWidth)
	{
		return null;
	}

	public string PadRight(int totalWidth, char paddingChar)
	{
		return null;
	}

	public string Remove(int startIndex, int count)
	{
		return null;
	}

	public string Remove(int startIndex)
	{
		return null;
	}

	public string Replace(char oldChar, char newChar)
	{
		return null;
	}

	public string Replace(string oldValue, string newValue)
	{
		return null;
	}

	private string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices)
	{
		return null;
	}

	public string[] Split(char separator, StringSplitOptions options = StringSplitOptions.None)
	{
		return null;
	}

	public string[] Split(params char[] separator)
	{
		return null;
	}

	public string[] Split(char[] separator, int count)
	{
		return null;
	}

	public string[] Split(char[] separator, StringSplitOptions options)
	{
		return null;
	}

	public string[] Split(char[] separator, int count, StringSplitOptions options)
	{
		return null;
	}

	private string[] SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options)
	{
		return null;
	}

	public string[] Split(string[] separator, StringSplitOptions options)
	{
		return null;
	}

	public string[] Split(string[] separator, int count, StringSplitOptions options)
	{
		return null;
	}

	private string[] SplitInternal(string separator, string[] separators, int count, StringSplitOptions options)
	{
		return null;
	}

	private string[] SplitInternal(string separator, int count, StringSplitOptions options)
	{
		return null;
	}

	private string[] SplitKeepEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
	{
		return null;
	}

	private string[] SplitOmitEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
	{
		return null;
	}

	private void MakeSeparatorList(ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder)
	{
	}

	private void MakeSeparatorList(string separator, ref ValueListBuilder<int> sepListBuilder)
	{
	}

	private void MakeSeparatorList(string[] separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder)
	{
	}

	public string Substring(int startIndex)
	{
		return null;
	}

	public string Substring(int startIndex, int length)
	{
		return null;
	}

	private string InternalSubString(int startIndex, int length)
	{
		return null;
	}

	public string ToLower()
	{
		return null;
	}

	public string ToLower(CultureInfo culture)
	{
		return null;
	}

	public string ToLowerInvariant()
	{
		return null;
	}

	public string ToUpper()
	{
		return null;
	}

	public string ToUpper(CultureInfo culture)
	{
		return null;
	}

	public string ToUpperInvariant()
	{
		return null;
	}

	public string Trim()
	{
		return null;
	}

	public string Trim(char trimChar)
	{
		return null;
	}

	public string Trim(params char[] trimChars)
	{
		return null;
	}

	public string TrimStart()
	{
		return null;
	}

	public string TrimStart(params char[] trimChars)
	{
		return null;
	}

	public string TrimEnd()
	{
		return null;
	}

	public string TrimEnd(params char[] trimChars)
	{
		return null;
	}

	private string TrimWhiteSpaceHelper(TrimType trimType)
	{
		return null;
	}

	private unsafe string TrimHelper(char* trimChars, int trimCharsLength, TrimType trimType)
	{
		return null;
	}

	private string CreateTrimmedString(int start, int end)
	{
		return null;
	}

	public bool Contains(string value)
	{
		return false;
	}

	public bool Contains(string value, StringComparison comparisonType)
	{
		return false;
	}

	public bool Contains(char value)
	{
		return false;
	}

	public int IndexOf(char value)
	{
		return 0;
	}

	public int IndexOf(char value, int startIndex)
	{
		return 0;
	}

	public int IndexOf(char value, int startIndex, int count)
	{
		return 0;
	}

	public int IndexOfAny(char[] anyOf)
	{
		return 0;
	}

	public int IndexOfAny(char[] anyOf, int startIndex)
	{
		return 0;
	}

	public int IndexOfAny(char[] anyOf, int startIndex, int count)
	{
		return 0;
	}

	private int IndexOfAny(char value1, char value2, int startIndex, int count)
	{
		return 0;
	}

	private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count)
	{
		return 0;
	}

	private int IndexOfCharArray(char[] anyOf, int startIndex, int count)
	{
		return 0;
	}

	private unsafe static void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan<char> anyOf)
	{
	}

	private static bool ArrayContains(char searchChar, char[] anyOf)
	{
		return false;
	}

	private unsafe static bool IsCharBitSet(uint* charMap, byte value)
	{
		return false;
	}

	private unsafe static void SetCharBit(uint* charMap, byte value)
	{
	}

	public int IndexOf(string value)
	{
		return 0;
	}

	public int IndexOf(string value, int startIndex)
	{
		return 0;
	}

	public int IndexOf(string value, int startIndex, int count)
	{
		return 0;
	}

	public int IndexOf(string value, StringComparison comparisonType)
	{
		return 0;
	}

	public int IndexOf(string value, int startIndex, StringComparison comparisonType)
	{
		return 0;
	}

	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
	{
		return 0;
	}

	public int LastIndexOf(char value)
	{
		return 0;
	}

	public int LastIndexOf(char value, int startIndex)
	{
		return 0;
	}

	public int LastIndexOf(char value, int startIndex, int count)
	{
		return 0;
	}

	public int LastIndexOfAny(char[] anyOf)
	{
		return 0;
	}

	public int LastIndexOfAny(char[] anyOf, int startIndex)
	{
		return 0;
	}

	public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
	{
		return 0;
	}

	private int LastIndexOfCharArray(char[] anyOf, int startIndex, int count)
	{
		return 0;
	}

	public int LastIndexOf(string value)
	{
		return 0;
	}

	public int LastIndexOf(string value, int startIndex)
	{
		return 0;
	}

	public int LastIndexOf(string value, int startIndex, int count)
	{
		return 0;
	}

	public int LastIndexOf(string value, StringComparison comparisonType)
	{
		return 0;
	}

	public int LastIndexOf(string value, int startIndex, StringComparison comparisonType)
	{
		return 0;
	}

	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
	{
		return 0;
	}

	public String(char[] value)
	{
	}

	private static string Ctor(char[] value)
	{
		return null;
	}

	public String(char[] value, int startIndex, int length)
	{
	}

	private static string Ctor(char[] value, int startIndex, int length)
	{
		return null;
	}

	[CLSCompliant(false)]
	public unsafe String(char* value, int startIndex, int length)
	{
	}

	private unsafe static string Ctor(char* ptr, int startIndex, int length)
	{
		return null;
	}

	[CLSCompliant(false)]
	public unsafe String(sbyte* value, int startIndex, int length)
	{
	}

	private unsafe static string Ctor(sbyte* value, int startIndex, int length)
	{
		return null;
	}

	private unsafe static string CreateStringForSByteConstructor(byte* pb, int numBytes)
	{
		return null;
	}

	[CLSCompliant(false)]
	public unsafe String(sbyte* value, int startIndex, int length, Encoding enc)
	{
	}

	private unsafe static string Ctor(sbyte* value, int startIndex, int length, Encoding enc)
	{
		return null;
	}

	public String(char c, int count)
	{
	}

	private static string Ctor(char c, int count)
	{
		return null;
	}

	public String(ReadOnlySpan<char> value)
	{
	}

	private static string Ctor(ReadOnlySpan<char> value)
	{
		return null;
	}

	public static string Create<TState>(int length, TState state, SpanAction<char, TState> action)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator ReadOnlySpan<char>(string value)
	{
		return default;
	}

	public object Clone()
	{
		return null;
	}

	public static string Copy(string str)
	{
		return null;
	}

	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
	{
	}

	public char[] ToCharArray()
	{
		return null;
	}

	public char[] ToCharArray(int startIndex, int length)
	{
		return null;
	}

	[NonVersionable]
	public static bool IsNullOrEmpty(string value)
	{
		return false;
	}

	internal ref char GetRawStringData()
	{
		throw null;
	}

	internal unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding)
	{
		return null;
	}

	internal static string CreateFromChar(char c)
	{
		return null;
	}

	internal unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	public CharEnumerator GetEnumerator()
	{
		return null;
	}

	IEnumerator<char> IEnumerable<char>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	internal unsafe static int wcslen(char* ptr)
	{
		return 0;
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

	public bool IsNormalized()
	{
		return false;
	}

	public bool IsNormalized(NormalizationForm normalizationForm)
	{
		return false;
	}

	public string Normalize()
	{
		return null;
	}

	public string Normalize(NormalizationForm normalizationForm)
	{
		return null;
	}

	internal int IndexOfUnchecked(string value, int startIndex, int count)
	{
		return 0;
	}

	internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
	{
		return 0;
	}

	internal int LastIndexOfUnchecked(string value, int startIndex, int count)
	{
		return 0;
	}

	internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
	{
		return 0;
	}

	internal bool StartsWithOrdinalUnchecked(string value)
	{
		return false;
	}

	internal static string FastAllocateString(int length)
	{
		return null;
	}

	private static string InternalIntern(string str)
	{
		return null;
	}

	private unsafe static void memset(byte* dest, int val, int len)
	{
	}

	private unsafe static void memcpy(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void bzero(byte* dest, int len)
	{
	}

	internal unsafe static void bzero_aligned_1(byte* dest, int len)
	{
	}

	internal unsafe static void bzero_aligned_2(byte* dest, int len)
	{
	}

	internal unsafe static void bzero_aligned_4(byte* dest, int len)
	{
	}

	internal unsafe static void bzero_aligned_8(byte* dest, int len)
	{
	}

	internal unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
	{
	}

	private unsafe string CreateString(sbyte* value, int startIndex, int length)
	{
		return null;
	}

	private unsafe string CreateString(char* value, int startIndex, int length)
	{
		return null;
	}

	private string CreateString(char[] val, int startIndex, int length)
	{
		return null;
	}

	private string CreateString(char[] val)
	{
		return null;
	}

	private string CreateString(char c, int count)
	{
		return null;
	}

	private unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc)
	{
		return null;
	}

	private string CreateString(ReadOnlySpan<char> value)
	{
		return null;
	}

	public static string Intern(string str)
	{
		return null;
	}
}
