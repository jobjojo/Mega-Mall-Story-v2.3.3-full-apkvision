using System.Collections.Generic;

namespace System.Globalization;

internal class DateTimeFormatInfoScanner
{
	private enum FoundDatePattern
	{
		None = 0,
		FoundYearPatternFlag = 1,
		FoundMonthPatternFlag = 2,
		FoundDayPatternFlag = 4,
		FoundYMDPatternFlag = 7
	}

	internal const char MonthPostfixChar = '\ue000';

	internal const char IgnorableSymbolChar = '\ue001';

	internal const string CJKYearSuff = "年";

	internal const string CJKMonthSuff = "月";

	internal const string CJKDaySuff = "日";

	internal const string KoreanYearSuff = "년";

	internal const string KoreanMonthSuff = "월";

	internal const string KoreanDaySuff = "일";

	internal const string KoreanHourSuff = "시";

	internal const string KoreanMinuteSuff = "분";

	internal const string KoreanSecondSuff = "초";

	internal const string CJKHourSuff = "時";

	internal const string ChineseHourSuff = "时";

	internal const string CJKMinuteSuff = "分";

	internal const string CJKSecondSuff = "秒";

	internal List<string> m_dateWords;

	private static Dictionary<string, string> s_knownWords;

	private FoundDatePattern _ymdFlags;

	private static Dictionary<string, string> KnownWords => null;

	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex)
	{
		return 0;
	}

	internal void AddDateWordOrPostfix(string formatPostfix, string str)
	{
	}

	internal int AddDateWords(string pattern, int index, string formatPostfix)
	{
		return 0;
	}

	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count)
	{
		count = default;
		return 0;
	}

	internal void AddIgnorableSymbols(string text)
	{
	}

	internal void ScanDateWord(string pattern)
	{
	}

	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi)
	{
		return null;
	}

	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames)
	{
		return FORMATFLAGS.None;
	}

	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames)
	{
		return FORMATFLAGS.None;
	}

	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames)
	{
		return FORMATFLAGS.None;
	}

	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID)
	{
		return FORMATFLAGS.None;
	}

	private static bool EqualStringArrays(string[] array1, string[] array2)
	{
		return false;
	}

	private static bool ArrayElementsHaveSpace(string[] array)
	{
		return false;
	}

	private static bool ArrayElementsBeginWithDigit(string[] array)
	{
		return false;
	}
}
