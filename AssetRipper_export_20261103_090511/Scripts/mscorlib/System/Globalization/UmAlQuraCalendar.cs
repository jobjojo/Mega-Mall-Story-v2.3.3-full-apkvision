namespace System.Globalization;

[Serializable]
public class UmAlQuraCalendar : Calendar
{
	internal struct DateMapping
	{
		internal int HijriMonthsLengthFlags = 0;

		internal DateTime GregorianDate = default;

		internal DateMapping(int MonthsLengthFlags, int GYear, int GMonth, int GDay)
		{
		}
	}

	internal const int MinCalendarYear = 1318;

	internal const int MaxCalendarYear = 1500;

	private static readonly DateMapping[] HijriYearInfo;

	public const int UmAlQuraEra = 1;

	internal const int DateCycle = 30;

	internal const int DatePartYear = 0;

	internal const int DatePartDayOfYear = 1;

	internal const int DatePartMonth = 2;

	internal const int DatePartDay = 3;

	internal static DateTime minDate;

	internal static DateTime maxDate;

	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 1451;

	public override DateTime MinSupportedDateTime => default;

	public override DateTime MaxSupportedDateTime => default;

	public override CalendarAlgorithmType AlgorithmType => CalendarAlgorithmType.Unknown;

	internal override int BaseCalendarID => 0;

	internal override int ID => 0;

	protected override int DaysInYearBeforeMinSupportedYear => 0;

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

	private static DateMapping[] InitDateMapping()
	{
		return null;
	}

	private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg)
	{
	}

	private static long GetAbsoluteDateUmAlQura(int year, int month, int day)
	{
		return 0L;
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

	private static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay)
	{
	}

	internal virtual int GetDatePart(DateTime time, int part)
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

	internal static int RealGetDaysInYear(int year)
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

	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
	{
		return default;
	}

	public override int ToFourDigitYear(int year)
	{
		return 0;
	}
}
