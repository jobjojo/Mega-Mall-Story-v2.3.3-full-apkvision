namespace System.Globalization;

public static class ISOWeek
{
	private const int WeeksInLongYear = 53;

	private const int WeeksInShortYear = 52;

	private const int MinWeek = 1;

	private const int MaxWeek = 53;

	public static int GetWeekOfYear(DateTime date)
	{
		return 0;
	}

	public static int GetYear(DateTime date)
	{
		return 0;
	}

	public static DateTime GetYearStart(int year)
	{
		return default;
	}

	public static DateTime GetYearEnd(int year)
	{
		return default;
	}

	public static int GetWeeksInYear(int year)
	{
		return 0;
	}

	public static DateTime ToDateTime(int year, int week, DayOfWeek dayOfWeek)
	{
		return default;
	}

	private static int GetWeekNumber(DateTime date)
	{
		return 0;
	}

	private static int GetWeekday(DayOfWeek dayOfWeek)
	{
		return 0;
	}
}
