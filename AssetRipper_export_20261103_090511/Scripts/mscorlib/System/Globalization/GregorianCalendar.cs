using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public class GregorianCalendar : Calendar
{
	public const int ADEra = 1;

	internal const int DatePartYear = 0;

	internal const int DatePartDayOfYear = 1;

	internal const int DatePartMonth = 2;

	internal const int DatePartDay = 3;

	internal const int MaxYear = 9999;

	internal const int MinYear = 1;

	internal GregorianCalendarTypes m_type;

	internal static readonly int[] DaysToMonth365;

	internal static readonly int[] DaysToMonth366;

	private static Calendar s_defaultInstance;

	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 2029;

	[ComVisible(false)]
	public override DateTime MinSupportedDateTime => default;

	[ComVisible(false)]
	public override DateTime MaxSupportedDateTime => default;

	[ComVisible(false)]
	public override CalendarAlgorithmType AlgorithmType => CalendarAlgorithmType.Unknown;

	public virtual GregorianCalendarTypes CalendarType
	{
		get
		{
			return (GregorianCalendarTypes)0;
		}
		set
		{
		}
	}

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

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	internal static Calendar GetDefaultInstance()
	{
		return null;
	}

	public GregorianCalendar()
	{
	}

	public GregorianCalendar(GregorianCalendarTypes type)
	{
	}

	internal virtual int GetDatePart(long ticks, int part)
	{
		return 0;
	}

	internal static long GetAbsoluteDate(int year, int month, int day)
	{
		return 0L;
	}

	internal virtual long DateToTicks(int year, int month, int day)
	{
		return 0L;
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

	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
	{
		result = default;
		return false;
	}

	public override int ToFourDigitYear(int year)
	{
		return 0;
	}
}
