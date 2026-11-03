using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public abstract class EastAsianLunisolarCalendar : Calendar
{
	internal const int LeapMonth = 0;

	internal const int Jan1Month = 1;

	internal const int Jan1Date = 2;

	internal const int nDaysPerMonth = 3;

	internal static readonly int[] DaysToMonth365;

	internal static readonly int[] DaysToMonth366;

	internal const int DatePartYear = 0;

	internal const int DatePartDayOfYear = 1;

	internal const int DatePartMonth = 2;

	internal const int DatePartDay = 3;

	internal const int MaxCalendarMonth = 13;

	internal const int MaxCalendarDay = 30;

	private const int DEFAULT_GREGORIAN_TWO_DIGIT_YEAR_MAX = 2029;

	public override CalendarAlgorithmType AlgorithmType => CalendarAlgorithmType.Unknown;

	internal abstract int MinCalendarYear { get; }

	internal abstract int MaxCalendarYear { get; }

	internal abstract EraInfo[] CalEraInfo { get; }

	internal abstract DateTime MinDate { get; }

	internal abstract DateTime MaxDate { get; }

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

	public virtual int GetSexagenaryYear(DateTime time)
	{
		return 0;
	}

	public int GetCelestialStem(int sexagenaryYear)
	{
		return 0;
	}

	public int GetTerrestrialBranch(int sexagenaryYear)
	{
		return 0;
	}

	internal abstract int GetYearInfo(int LunarYear, int Index);

	internal abstract int GetYear(int year, DateTime time);

	internal abstract int GetGregorianYear(int year, int era);

	internal int MinEraCalendarYear(int era)
	{
		return 0;
	}

	internal int MaxEraCalendarYear(int era)
	{
		return 0;
	}

	internal EastAsianLunisolarCalendar()
	{
	}

	internal void CheckTicksRange(long ticks)
	{
	}

	internal void CheckEraRange(int era)
	{
	}

	internal int CheckYearRange(int year, int era)
	{
		return 0;
	}

	internal int CheckYearMonthRange(int year, int month, int era)
	{
		return 0;
	}

	internal int InternalGetDaysInMonth(int year, int month)
	{
		return 0;
	}

	public override int GetDaysInMonth(int year, int month, int era)
	{
		return 0;
	}

	private static int GregorianIsLeapYear(int y)
	{
		return 0;
	}

	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
	{
		return default;
	}

	internal void GregorianToLunar(int nSYear, int nSMonth, int nSDate, ref int nLYear, ref int nLMonth, ref int nLDate)
	{
	}

	internal bool LunarToGregorian(int nLYear, int nLMonth, int nLDate, ref int nSolarYear, ref int nSolarMonth, ref int nSolarDay)
	{
		return false;
	}

	internal DateTime LunarToTime(DateTime time, int year, int month, int day)
	{
		return default;
	}

	internal void TimeToLunar(DateTime time, ref int year, ref int month, ref int day)
	{
	}

	public override DateTime AddMonths(DateTime time, int months)
	{
		return default;
	}

	public override DateTime AddYears(DateTime time, int years)
	{
		return default;
	}

	public override int GetDayOfYear(DateTime time)
	{
		return 0;
	}

	public override int GetDayOfMonth(DateTime time)
	{
		return 0;
	}

	public override int GetDaysInYear(int year, int era)
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

	public override DayOfWeek GetDayOfWeek(DateTime time)
	{
		return DayOfWeek.Sunday;
	}

	public override int GetMonthsInYear(int year, int era)
	{
		return 0;
	}

	public override bool IsLeapDay(int year, int month, int day, int era)
	{
		return false;
	}

	public override bool IsLeapMonth(int year, int month, int era)
	{
		return false;
	}

	public override int GetLeapMonth(int year, int era)
	{
		return 0;
	}

	internal bool InternalIsLeapYear(int year)
	{
		return false;
	}

	public override bool IsLeapYear(int year, int era)
	{
		return false;
	}

	public override int ToFourDigitYear(int year)
	{
		return 0;
	}
}
