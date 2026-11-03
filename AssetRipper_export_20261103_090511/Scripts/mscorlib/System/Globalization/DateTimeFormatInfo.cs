using System.Runtime.CompilerServices;

namespace System.Globalization;

[Serializable]
public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable
{
	internal class TokenHashValue
	{
		internal string tokenString;

		internal TokenType tokenType;

		internal int tokenValue;

		internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue)
		{
		}
	}

	private static DateTimeFormatInfo s_invariantInfo;

	[NonSerialized]
	private CultureData _cultureData;

	private string _name;

	[NonSerialized]
	private string _langName;

	[NonSerialized]
	private CompareInfo _compareInfo;

	[NonSerialized]
	private CultureInfo _cultureInfo;

	private string amDesignator;

	private string pmDesignator;

	private string dateSeparator;

	private string generalShortTimePattern;

	private string generalLongTimePattern;

	private string timeSeparator;

	private string monthDayPattern;

	private string dateTimeOffsetPattern;

	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";

	private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss";

	private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";

	private Calendar calendar;

	private int firstDayOfWeek;

	private int calendarWeekRule;

	private string fullDateTimePattern;

	private string[] abbreviatedDayNames;

	private string[] m_superShortDayNames;

	private string[] dayNames;

	private string[] abbreviatedMonthNames;

	private string[] monthNames;

	private string[] genitiveMonthNames;

	private string[] m_genitiveAbbreviatedMonthNames;

	private string[] leapYearMonthNames;

	private string longDatePattern;

	private string shortDatePattern;

	private string yearMonthPattern;

	private string longTimePattern;

	private string shortTimePattern;

	private string[] allYearMonthPatterns;

	private string[] allShortDatePatterns;

	private string[] allLongDatePatterns;

	private string[] allShortTimePatterns;

	private string[] allLongTimePatterns;

	private string[] m_eraNames;

	private string[] m_abbrevEraNames;

	private string[] m_abbrevEnglishEraNames;

	private CalendarId[] optionalCalendars;

	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;

	internal bool _isReadOnly;

	private DateTimeFormatFlags formatFlags;

	private static readonly char[] s_monthSpaces;

	internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";

	internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz";

	private string _fullTimeSpanPositivePattern;

	private string _fullTimeSpanNegativePattern;

	internal const DateTimeStyles InvalidDateTimeStyles = ~(DateTimeStyles.AllowWhiteSpaces | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind);

	[NonSerialized]
	private TokenHashValue[] _dtfiTokenHash;

	private const int TOKEN_HASH_SIZE = 199;

	private const int SECOND_PRIME = 197;

	private const string dateSeparatorOrTimeZoneOffset = "-";

	private const string invariantDateSeparator = "/";

	private const string invariantTimeSeparator = ":";

	internal const string IgnorablePeriod = ".";

	internal const string IgnorableComma = ",";

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

	internal const string JapaneseEraStart = "元";

	internal const string LocalTimeMark = "T";

	internal const string GMTName = "GMT";

	internal const string ZuluName = "Z";

	internal const string KoreanLangName = "ko";

	internal const string JapaneseLangName = "ja";

	internal const string EnglishLangName = "en";

	private static DateTimeFormatInfo s_jajpDTFI;

	private static DateTimeFormatInfo s_zhtwDTFI;

	private string CultureName => null;

	private CultureInfo Culture => null;

	private string LanguageName => null;

	public static DateTimeFormatInfo InvariantInfo => null;

	public static DateTimeFormatInfo CurrentInfo => null;

	public string AMDesignator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Calendar Calendar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private CalendarId[] OptionalCalendars => null;

	internal string[] EraNames => null;

	internal string[] AbbreviatedEraNames => null;

	internal string[] AbbreviatedEnglishEraNames => null;

	public string DateSeparator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DayOfWeek FirstDayOfWeek
	{
		get
		{
			return DayOfWeek.Sunday;
		}
		set
		{
		}
	}

	public CalendarWeekRule CalendarWeekRule
	{
		get
		{
			return CalendarWeekRule.FirstDay;
		}
		set
		{
		}
	}

	public string FullDateTimePattern
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string LongDatePattern
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string LongTimePattern
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string MonthDayPattern
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string PMDesignator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string RFC1123Pattern => null;

	public string ShortDatePattern
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string ShortTimePattern
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string SortableDateTimePattern => null;

	internal string GeneralShortTimePattern => null;

	internal string GeneralLongTimePattern => null;

	internal string DateTimeOffsetPattern => null;

	public string TimeSeparator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string UniversalSortableDateTimePattern => null;

	public string YearMonthPattern
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string[] AbbreviatedDayNames
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string[] ShortestDayNames
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string[] DayNames
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string[] AbbreviatedMonthNames
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string[] MonthNames
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool HasSpacesInMonthNames => false;

	internal bool HasSpacesInDayNames => false;

	private string[] AllYearMonthPatterns => null;

	private string[] AllShortDatePatterns => null;

	private string[] AllShortTimePatterns => null;

	private string[] AllLongDatePatterns => null;

	private string[] AllLongTimePatterns => null;

	private string[] UnclonedYearMonthPatterns => null;

	private string[] UnclonedShortDatePatterns => null;

	private string[] UnclonedLongDatePatterns => null;

	private string[] UnclonedShortTimePatterns => null;

	private string[] UnclonedLongTimePatterns => null;

	public bool IsReadOnly => false;

	public string NativeCalendarName => null;

	public string[] AbbreviatedMonthGenitiveNames
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string[] MonthGenitiveNames
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string FullTimeSpanPositivePattern => null;

	internal string FullTimeSpanNegativePattern => null;

	internal CompareInfo CompareInfo => null;

	internal DateTimeFormatFlags FormatFlags => DateTimeFormatFlags.None;

	internal bool HasForceTwoDigitYears => false;

	internal bool HasYearMonthAdjustment => false;

	private string[] internalGetAbbreviatedDayOfWeekNames()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] internalGetAbbreviatedDayOfWeekNamesCore()
	{
		return null;
	}

	private string[] internalGetSuperShortDayNames()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] internalGetSuperShortDayNamesCore()
	{
		return null;
	}

	private string[] internalGetDayOfWeekNames()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] internalGetDayOfWeekNamesCore()
	{
		return null;
	}

	private string[] internalGetAbbreviatedMonthNames()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] internalGetAbbreviatedMonthNamesCore()
	{
		return null;
	}

	private string[] internalGetMonthNames()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] internalGetMonthNamesCore()
	{
		return null;
	}

	public DateTimeFormatInfo()
	{
	}

	internal DateTimeFormatInfo(CultureData cultureData, Calendar cal)
	{
	}

	private void InitializeOverridableProperties(CultureData cultureData, int calendarId)
	{
	}

	public static DateTimeFormatInfo GetInstance(IFormatProvider provider)
	{
		return null;
	}

	public object GetFormat(Type formatType)
	{
		return null;
	}

	public object Clone()
	{
		return null;
	}

	public int GetEra(string eraName)
	{
		return 0;
	}

	public string GetEraName(int era)
	{
		return null;
	}

	public string GetAbbreviatedEraName(int era)
	{
		return null;
	}

	private static void CheckNullValue(string[] values, int length)
	{
	}

	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
	{
		return null;
	}

	private string[] internalGetGenitiveMonthNames(bool abbreviated)
	{
		return null;
	}

	internal string[] internalGetLeapYearMonthNames()
	{
		return null;
	}

	public string GetAbbreviatedDayName(DayOfWeek dayofweek)
	{
		return null;
	}

	public string GetShortestDayName(DayOfWeek dayOfWeek)
	{
		return null;
	}

	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString)
	{
		return null;
	}

	public string[] GetAllDateTimePatterns()
	{
		return null;
	}

	public string[] GetAllDateTimePatterns(char format)
	{
		return null;
	}

	public string GetDayName(DayOfWeek dayofweek)
	{
		return null;
	}

	public string GetAbbreviatedMonthName(int month)
	{
		return null;
	}

	public string GetMonthName(int month)
	{
		return null;
	}

	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern)
	{
		return null;
	}

	public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi)
	{
		return null;
	}

	public void SetAllDateTimePatterns(string[] patterns, char format)
	{
	}

	internal static void ValidateStyles(DateTimeStyles style, string parameterName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DateTimeFormatFlags InitializeFormatFlags()
	{
		return DateTimeFormatFlags.None;
	}

	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName)
	{
		return false;
	}

	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI()
	{
		return null;
	}

	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI()
	{
		return null;
	}

	private void ClearTokenHashTable()
	{
	}

	internal TokenHashValue[] CreateTokenHashTable()
	{
		return null;
	}

	private void PopulateSpecialTokenHashTable(TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol)
	{
	}

	private static bool IsJapaneseCalendar(Calendar calendar)
	{
		return false;
	}

	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix)
	{
	}

	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number)
	{
		badFormat = default;
		number = default;
		return false;
	}

	private static bool IsHebrewChar(char ch)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh)
	{
		return false;
	}

	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str)
	{
		tokenType = default;
		tokenValue = default;
		return false;
	}

	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
	{
	}

	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue)
	{
	}

	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2)
	{
		return false;
	}
}
