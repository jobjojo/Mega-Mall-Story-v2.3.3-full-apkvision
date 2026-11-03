using System.Text;

namespace System.Globalization;

public static class CharUnicodeInfo
{
	internal const char HIGH_SURROGATE_START = '\ud800';

	internal const char HIGH_SURROGATE_END = '\udbff';

	internal const char LOW_SURROGATE_START = '\udc00';

	internal const char LOW_SURROGATE_END = '\udfff';

	internal const int HIGH_SURROGATE_RANGE = 1023;

	internal const int UNICODE_CATEGORY_OFFSET = 0;

	internal const int BIDI_CATEGORY_OFFSET = 1;

	internal const int UNICODE_PLANE01_START = 65536;

	private static ReadOnlySpan<byte> CategoryLevel1Index => default;

	private static ReadOnlySpan<byte> CategoryLevel2Index => default;

	private static ReadOnlySpan<byte> CategoryLevel3Index => default;

	private static ReadOnlySpan<byte> CategoriesValue => default;

	private static ReadOnlySpan<byte> NumericLevel1Index => default;

	private static ReadOnlySpan<byte> NumericLevel2Index => default;

	private static ReadOnlySpan<byte> NumericLevel3Index => default;

	private static ReadOnlySpan<byte> NumericValues => default;

	private static ReadOnlySpan<byte> DigitValues => default;

	internal static int InternalConvertToUtf32(string s, int index)
	{
		return 0;
	}

	internal static int InternalConvertToUtf32(StringBuilder s, int index)
	{
		return 0;
	}

	internal static int InternalConvertToUtf32(string s, int index, out int charLength)
	{
		charLength = default;
		return 0;
	}

	internal static double InternalGetNumericValue(int ch)
	{
		return 0.0;
	}

	internal static byte InternalGetDigitValues(int ch, int offset)
	{
		return 0;
	}

	public static double GetNumericValue(char ch)
	{
		return 0.0;
	}

	public static double GetNumericValue(string s, int index)
	{
		return 0.0;
	}

	public static int GetDecimalDigitValue(char ch)
	{
		return 0;
	}

	public static int GetDecimalDigitValue(string s, int index)
	{
		return 0;
	}

	public static int GetDigitValue(char ch)
	{
		return 0;
	}

	public static int GetDigitValue(string s, int index)
	{
		return 0;
	}

	public static UnicodeCategory GetUnicodeCategory(char ch)
	{
		return UnicodeCategory.UppercaseLetter;
	}

	public static UnicodeCategory GetUnicodeCategory(string s, int index)
	{
		return UnicodeCategory.UppercaseLetter;
	}

	public static UnicodeCategory GetUnicodeCategory(int codePoint)
	{
		return UnicodeCategory.UppercaseLetter;
	}

	internal static byte InternalGetCategoryValue(int ch, int offset)
	{
		return 0;
	}

	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
	{
		return UnicodeCategory.UppercaseLetter;
	}

	internal static BidiCategory GetBidiCategory(string s, int index)
	{
		return BidiCategory.LeftToRight;
	}

	internal static BidiCategory GetBidiCategory(StringBuilder s, int index)
	{
		return BidiCategory.LeftToRight;
	}

	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength)
	{
		charLength = default;
		return UnicodeCategory.UppercaseLetter;
	}

	internal static bool IsCombiningCategory(UnicodeCategory uc)
	{
		return false;
	}

	internal static bool IsWhiteSpace(string s, int index)
	{
		return false;
	}

	internal static bool IsWhiteSpace(char c)
	{
		return false;
	}
}
