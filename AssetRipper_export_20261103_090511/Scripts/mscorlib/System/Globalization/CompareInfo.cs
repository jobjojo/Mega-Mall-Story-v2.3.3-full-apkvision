using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace System.Globalization;

[Serializable]
public class CompareInfo : IDeserializationCallback
{
	private const CompareOptions ValidIndexMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

	private const CompareOptions ValidCompareMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

	private const CompareOptions ValidSortkeyCtorMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

	internal static readonly CompareInfo Invariant;

	[OptionalField(VersionAdded = 2)]
	private string m_name;

	[NonSerialized]
	private string _sortName;

	[OptionalField(VersionAdded = 3)]
	private SortVersion m_SortVersion;

	private int culture;

	[NonSerialized]
	private ISimpleCollator collator;

	private static Dictionary<string, ISimpleCollator> collators;

	private static bool managedCollation;

	private static bool managedCollationChecked;

	public virtual string Name => null;

	public SortVersion Version => null;

	public int LCID => 0;

	private static bool UseManagedCollation => false;

	internal static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	internal static int InvariantIndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, bool ignoreCase)
	{
		return 0;
	}

	internal static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	private unsafe static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start)
	{
		return 0;
	}

	private static char InvariantToUpper(char c)
	{
		return '\0';
	}

	private SortKey InvariantCreateSortKey(string source, CompareOptions options)
	{
		return null;
	}

	internal CompareInfo(CultureInfo culture)
	{
	}

	public static CompareInfo GetCompareInfo(int culture, Assembly assembly)
	{
		return null;
	}

	public static CompareInfo GetCompareInfo(string name, Assembly assembly)
	{
		return null;
	}

	public static CompareInfo GetCompareInfo(int culture)
	{
		return null;
	}

	public static CompareInfo GetCompareInfo(string name)
	{
		return null;
	}

	public static bool IsSortable(char ch)
	{
		return false;
	}

	public static bool IsSortable(string text)
	{
		return false;
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	private void OnDeserialized()
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	public virtual int Compare(string string1, string string2)
	{
		return 0;
	}

	public virtual int Compare(string string1, string string2, CompareOptions options)
	{
		return 0;
	}

	internal int Compare(ReadOnlySpan<char> string1, string string2, CompareOptions options)
	{
		return 0;
	}

	internal int CompareOptionNone(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2)
	{
		return 0;
	}

	internal int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2)
	{
		return 0;
	}

	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2)
	{
		return 0;
	}

	public virtual int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options)
	{
		return 0;
	}

	public virtual int Compare(string string1, int offset1, string string2, int offset2)
	{
		return 0;
	}

	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
	{
		return 0;
	}

	internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB)
	{
		return 0;
	}

	internal static int CompareOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
	{
		return 0;
	}

	public virtual bool IsPrefix(string source, string prefix, CompareOptions options)
	{
		return false;
	}

	internal bool IsPrefix(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options)
	{
		return false;
	}

	public virtual bool IsPrefix(string source, string prefix)
	{
		return false;
	}

	public virtual bool IsSuffix(string source, string suffix, CompareOptions options)
	{
		return false;
	}

	internal bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
	{
		return false;
	}

	public virtual bool IsSuffix(string source, string suffix)
	{
		return false;
	}

	public virtual int IndexOf(string source, char value)
	{
		return 0;
	}

	public virtual int IndexOf(string source, string value)
	{
		return 0;
	}

	public virtual int IndexOf(string source, char value, CompareOptions options)
	{
		return 0;
	}

	public virtual int IndexOf(string source, string value, CompareOptions options)
	{
		return 0;
	}

	public virtual int IndexOf(string source, char value, int startIndex)
	{
		return 0;
	}

	public virtual int IndexOf(string source, string value, int startIndex)
	{
		return 0;
	}

	public virtual int IndexOf(string source, char value, int startIndex, CompareOptions options)
	{
		return 0;
	}

	public virtual int IndexOf(string source, string value, int startIndex, CompareOptions options)
	{
		return 0;
	}

	public virtual int IndexOf(string source, char value, int startIndex, int count)
	{
		return 0;
	}

	public virtual int IndexOf(string source, string value, int startIndex, int count)
	{
		return 0;
	}

	public virtual int IndexOf(string source, char value, int startIndex, int count, CompareOptions options)
	{
		return 0;
	}

	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
	{
		return 0;
	}

	internal int IndexOfOrdinal(ReadOnlySpan<char> source, ReadOnlySpan<char> value, bool ignoreCase)
	{
		return 0;
	}

	internal int IndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, CompareOptions options)
	{
		return 0;
	}

	internal unsafe int IndexOf(string source, string value, int startIndex, int count, CompareOptions options, int* matchLengthPtr)
	{
		return 0;
	}

	internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, char value)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, string value)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, char value, CompareOptions options)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, string value, CompareOptions options)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, char value, int startIndex)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, string value, int startIndex)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, char value, int startIndex, CompareOptions options)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, string value, int startIndex, CompareOptions options)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, char value, int startIndex, int count)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, string value, int startIndex, int count)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, char value, int startIndex, int count, CompareOptions options)
	{
		return 0;
	}

	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
	{
		return 0;
	}

	internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	public virtual SortKey GetSortKey(string source, CompareOptions options)
	{
		return null;
	}

	public virtual SortKey GetSortKey(string source)
	{
		return null;
	}

	public override bool Equals(object value)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal static int GetIgnoreCaseHash(string source)
	{
		return 0;
	}

	internal int GetHashCodeOfString(string source, CompareOptions options)
	{
		return 0;
	}

	public virtual int GetHashCode(string source, CompareOptions options)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	private ISimpleCollator GetCollator()
	{
		return null;
	}

	private SortKey CreateSortKeyCore(string source, CompareOptions options)
	{
		return null;
	}

	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
	{
		return 0;
	}

	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
	{
		return 0;
	}

	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
	{
		return 0;
	}

	private int internal_index_managed(string s, int sindex, int count, char c, CompareOptions opt, bool first)
	{
		return 0;
	}

	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
	{
		return 0;
	}

	private unsafe static int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options)
	{
		return 0;
	}

	private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
	{
		return 0;
	}

	private unsafe static int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first)
	{
		return 0;
	}

	private static int internal_index(string source, int sindex, int count, string value, bool first)
	{
		return 0;
	}

	private void InitSort(CultureInfo culture)
	{
	}

	private unsafe static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2)
	{
		return 0;
	}

	internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options)
	{
		return 0;
	}

	private unsafe int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr)
	{
		return 0;
	}

	private unsafe int IndexOfCore(ReadOnlySpan<char> source, ReadOnlySpan<char> target, CompareOptions options, int* matchLengthPtr)
	{
		return 0;
	}

	private int IndexOfOrdinalCore(ReadOnlySpan<char> source, ReadOnlySpan<char> value, bool ignoreCase)
	{
		return 0;
	}

	private int CompareString(ReadOnlySpan<char> string1, string string2, CompareOptions options)
	{
		return 0;
	}

	private int CompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options)
	{
		return 0;
	}

	private unsafe static bool IsSortable(char* text, int length)
	{
		return false;
	}

	private SortKey CreateSortKey(string source, CompareOptions options)
	{
		return null;
	}

	private bool StartsWith(string source, string prefix, CompareOptions options)
	{
		return false;
	}

	private bool StartsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options)
	{
		return false;
	}

	private bool EndsWith(string source, string suffix, CompareOptions options)
	{
		return false;
	}

	private bool EndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
	{
		return false;
	}

	internal int GetHashCodeOfStringCore(string source, CompareOptions options)
	{
		return 0;
	}

	private SortVersion GetSortVersion()
	{
		return null;
	}

	internal CompareInfo()
	{
	}
}
