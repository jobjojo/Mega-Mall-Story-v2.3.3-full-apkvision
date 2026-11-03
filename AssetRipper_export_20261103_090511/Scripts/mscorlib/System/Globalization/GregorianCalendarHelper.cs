using System.Runtime.Serialization;

namespace System.Globalization;

[Serializable]
internal class GregorianCalendarHelper
{
	internal const long TicksPerMillisecond = 10000L;

	internal const long TicksPerSecond = 10000000L;

	internal const long TicksPerMinute = 600000000L;

	internal const long TicksPerHour = 36000000000L;

	internal const long TicksPerDay = 864000000000L;

	internal const int MillisPerSecond = 1000;

	internal const int MillisPerMinute = 60000;

	internal const int MillisPerHour = 3600000;

	internal const int MillisPerDay = 86400000;

	internal const int DaysPerYear = 365;

	internal const int DaysPer4Years = 1461;

	internal const int DaysPer100Years = 36524;

	internal const int DaysPer400Years = 146097;

	internal const int DaysTo10000 = 3652059;

	internal const long MaxMillis = 315537897600000L;

	internal const int DatePartYear = 0;

	internal const int DatePartDayOfYear = 1;

	internal const int DatePartMonth = 2;

	internal const int DatePartDay = 3;

	internal static readonly int[] DaysToMonth365;

	internal static readonly int[] DaysToMonth366;

	[OptionalField(VersionAdded = 1)]
	internal int m_maxYear;

	[OptionalField(VersionAdded = 1)]
	internal int m_minYear;

	internal Calendar m_Cal;

	[OptionalField(VersionAdded = 1)]
	internal EraInfo[] m_EraInfo;

	[OptionalField(VersionAdded = 1)]
	internal int[] m_eras;

	[OptionalField(VersionAdded = 1)]
	internal DateTime m_minDate;

	internal int MaxYear => 0;

	public int[] Eras => null;

	internal GregorianCalendarHelper(Calendar cal, EraInfo[] eraInfo)
	{
	}

	private int GetYearOffset(int year, int era, bool throwOnError)
	{
		return 0;
	}

	internal int GetGregorianYear(int year, int era)
	{
		return 0;
	}

	internal bool IsValidYear(int year, int era)
	{
		return false;
	}

	internal virtual int GetDatePart(long ticks, int part)
	{
		return 0;
	}

	internal static long GetAbsoluteDate(int year, int month, int day)
	{
		return 0L;
	}

	internal static long DateToTicks(int year, int month, int day)
	{
		return 0L;
	}

	internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
	{
		return 0L;
	}

	internal void CheckTicksRange(long ticks)
	{
	}

	public DateTime AddMonths(DateTime time, int months)
	{
		return default;
	}

	public DateTime AddYears(DateTime time, int years)
	{
		return default;
	}

	public int GetDayOfMonth(DateTime time)
	{
		return 0;
	}

	public DayOfWeek GetDayOfWeek(DateTime time)
	{
		return DayOfWeek.Sunday;
	}

	public int GetDayOfYear(DateTime time)
	{
		return 0;
	}

	public int GetDaysInMonth(int year, int month, int era)
	{
		return 0;
	}

	public int GetDaysInYear(int year, int era)
	{
		return 0;
	}

	public int GetEra(DateTime time)
	{
		return 0;
	}

	public int GetMonth(DateTime time)
	{
		return 0;
	}

	public int GetMonthsInYear(int year, int era)
	{
		return 0;
	}

	public int GetYear(DateTime time)
	{
		return 0;
	}

	public int GetYear(int year, DateTime time)
	{
		return 0;
	}

	public bool IsLeapDay(int year, int month, int day, int era)
	{
		return false;
	}

	public int GetLeapMonth(int year, int era)
	{
		return 0;
	}

	public bool IsLeapMonth(int year, int month, int era)
	{
		return false;
	}

	public bool IsLeapYear(int year, int era)
	{
		return false;
	}

	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
	{
		return default;
	}

	public virtual int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
	{
		return 0;
	}

	public int ToFourDigitYear(int year, int twoDigitYearMax)
	{
		return 0;
	}
}
