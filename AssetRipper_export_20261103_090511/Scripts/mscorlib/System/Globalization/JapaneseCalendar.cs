using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public class JapaneseCalendar : Calendar
{
	internal static readonly DateTime calendarMinValue;

	internal static EraInfo[] japaneseEraInfo;

	private const string c_japaneseErasHive = "System\\CurrentControlSet\\Control\\Nls\\Calendars\\Japanese\\Eras";

	private const string c_japaneseErasHivePermissionList = "HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Nls\\Calendars\\Japanese\\Eras";

	internal static Calendar s_defaultInstance;

	internal GregorianCalendarHelper helper;

	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 99;

	[ComVisible(false)]
	public override DateTime MinSupportedDateTime => default;

	[ComVisible(false)]
	public override DateTime MaxSupportedDateTime => default;

	[ComVisible(false)]
	public override CalendarAlgorithmType AlgorithmType => CalendarAlgorithmType.Unknown;

	internal override int ID => 0;

	public override int[] Eras => null;

	public override int TwoDigitYearMax
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal static EraInfo[] GetEraInfo()
	{
		return null;
	}

	private static EraInfo[] GetErasFromRegistry()
	{
		return null;
	}

	private static int CompareEraRanges(EraInfo a, EraInfo b)
	{
		return 0;
	}

	private static EraInfo GetEraFromValue(string value, string data)
	{
		return null;
	}

	internal static Calendar GetDefaultInstance()
	{
		return null;
	}

	public override DateTime AddMonths(DateTime time, int months)
	{
		return default;
	}

	public override DateTime AddYears(DateTime time, int years)
	{
		return default;
	}

	public override int GetDaysInMonth(int year, int month, int era)
	{
		return 0;
	}

	public override int GetDaysInYear(int year, int era)
	{
		return 0;
	}

	public override int GetDayOfMonth(DateTime time)
	{
		return 0;
	}

	public override DayOfWeek GetDayOfWeek(DateTime time)
	{
		return DayOfWeek.Sunday;
	}

	public override int GetDayOfYear(DateTime time)
	{
		return 0;
	}

	public override int GetMonthsInYear(int year, int era)
	{
		return 0;
	}

	[ComVisible(false)]
	public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
	{
		return 0;
	}

	public override int GetEra(DateTime time)
	{
		return 0;
	}

	public override int GetMonth(DateTime time)
	{
		return 0;
	}

	public override int GetYear(DateTime time)
	{
		return 0;
	}

	public override bool IsLeapDay(int year, int month, int day, int era)
	{
		return false;
	}

	public override bool IsLeapYear(int year, int era)
	{
		return false;
	}

	[ComVisible(false)]
	public override int GetLeapMonth(int year, int era)
	{
		return 0;
	}

	public override bool IsLeapMonth(int year, int month, int era)
	{
		return false;
	}

	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
	{
		return default;
	}

	public override int ToFourDigitYear(int year)
	{
		return 0;
	}

	internal static string[] EraNames()
	{
		return null;
	}

	internal static string[] AbbrevEraNames()
	{
		return null;
	}

	internal static string[] EnglishEraNames()
	{
		return null;
	}

	internal override bool IsValidYear(int year, int era)
	{
		return false;
	}
}
