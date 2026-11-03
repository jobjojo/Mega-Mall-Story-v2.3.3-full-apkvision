using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public class HijriCalendar : Calendar
{
	public static readonly int HijriEra;

	internal const int DatePartYear = 0;

	internal const int DatePartDayOfYear = 1;

	internal const int DatePartMonth = 2;

	internal const int DatePartDay = 3;

	internal const int MinAdvancedHijri = -2;

	internal const int MaxAdvancedHijri = 2;

	internal static readonly int[] HijriMonthDays;

	private const string HijriAdvanceRegKeyEntry = "AddHijriDate";

	private int m_HijriAdvance;

	internal const int MaxCalendarYear = 9666;

	internal const int MaxCalendarMonth = 4;

	internal const int MaxCalendarDay = 3;

	internal static readonly DateTime calendarMinValue;

	internal static readonly DateTime calendarMaxValue;

	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 1451;

	[ComVisible(false)]
	public override DateTime MinSupportedDateTime => default;

	[ComVisible(false)]
	public override DateTime MaxSupportedDateTime => default;

	[ComVisible(false)]
	public override CalendarAlgorithmType AlgorithmType => CalendarAlgorithmType.Unknown;

	internal override int ID => 0;

	protected override int DaysInYearBeforeMinSupportedYear => 0;

	public int HijriAdjustment
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

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

	private long GetAbsoluteDateHijri(int y, int m, int d)
	{
		return 0L;
	}

	private long DaysUpToHijriYear(int HijriYear)
	{
		return 0L;
	}

	private static int GetAdvanceHijriDate()
	{
		return 0;
	}

	internal static void CheckTicksRange(long ticks)
	{
	}

	internal static void CheckEraRange(int era)
	{
	}

	internal static void CheckYearRange(int year, int era)
	{
	}

	internal static void CheckYearMonthRange(int year, int month, int era)
	{
	}

	internal virtual int GetDatePart(long ticks, int part)
	{
		return 0;
	}

	public override DateTime AddMonths(DateTime time, int months)
	{
		return default;
	}

	public override DateTime AddYears(DateTime time, int years)
	{
		return default;
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

	public override int GetDaysInMonth(int year, int month, int era)
	{
		return 0;
	}

	public override int GetDaysInYear(int year, int era)
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

	public override int GetMonthsInYear(int year, int era)
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

	[ComVisible(false)]
	public override int GetLeapMonth(int year, int era)
	{
		return 0;
	}

	public override bool IsLeapMonth(int year, int month, int era)
	{
		return false;
	}

	public override bool IsLeapYear(int year, int era)
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
}
