using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public class JulianCalendar : Calendar
{
	public static readonly int JulianEra;

	private const int DatePartYear = 0;

	private const int DatePartDayOfYear = 1;

	private const int DatePartMonth = 2;

	private const int DatePartDay = 3;

	private const int JulianDaysPerYear = 365;

	private const int JulianDaysPer4Years = 1461;

	private static readonly int[] DaysToMonth365;

	private static readonly int[] DaysToMonth366;

	internal int MaxYear;

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

	internal static void CheckEraRange(int era)
	{
	}

	internal void CheckYearEraRange(int year, int era)
	{
	}

	internal static void CheckMonthRange(int month)
	{
	}

	internal static void CheckDayRange(int year, int month, int day)
	{
	}

	internal static int GetDatePart(long ticks, int part)
	{
		return 0;
	}

	internal static long DateToTicks(int year, int month, int day)
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

	public override int ToFourDigitYear(int year)
	{
		return 0;
	}
}
