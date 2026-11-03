using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public class HebrewCalendar : Calendar
{
	internal class __DateBuffer
	{
		internal int year;

		internal int month;

		internal int day;
	}

	public static readonly int HebrewEra;

	internal const int DatePartYear = 0;

	internal const int DatePartDayOfYear = 1;

	internal const int DatePartMonth = 2;

	internal const int DatePartDay = 3;

	internal const int DatePartDayOfWeek = 4;

	private const int HebrewYearOf1AD = 3760;

	private const int FirstGregorianTableYear = 1583;

	private const int LastGregorianTableYear = 2239;

	private const int TABLESIZE = 656;

	private const int MinHebrewYear = 5343;

	private const int MaxHebrewYear = 5999;

	private static readonly int[] HebrewTable;

	private static readonly int[,] LunarMonthLen;

	internal static readonly DateTime calendarMinValue;

	internal static readonly DateTime calendarMaxValue;

	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 5790;

	public override DateTime MinSupportedDateTime => default;

	public override DateTime MaxSupportedDateTime => default;

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

	private static void CheckHebrewYearValue(int y, int era, string varName)
	{
	}

	private void CheckHebrewMonthValue(int year, int month, int era)
	{
	}

	private void CheckHebrewDayValue(int year, int month, int day, int era)
	{
	}

	internal static void CheckEraRange(int era)
	{
	}

	private static void CheckTicksRange(long ticks)
	{
	}

	internal static int GetResult(__DateBuffer result, int part)
	{
		return 0;
	}

	internal static int GetLunarMonthDay(int gregorianYear, __DateBuffer lunarDate)
	{
		return 0;
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

	internal static int GetHebrewYearType(int year, int era)
	{
		return 0;
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

	private static int GetDayDifference(int lunarYearType, int month1, int day1, int month2, int day2)
	{
		return 0;
	}

	private static DateTime HebrewToGregorian(int hebrewYear, int hebrewMonth, int hebrewDay, int hour, int minute, int second, int millisecond)
	{
		return default;
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
