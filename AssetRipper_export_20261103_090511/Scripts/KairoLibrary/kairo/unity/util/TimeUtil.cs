using System.Diagnostics;
using java.util;

namespace kairo.unity.util;

public class TimeUtil
{
	private static JTimeZone timezone_;

	private static long tickOffset_;

	private static Stopwatch stopwatch_;

	private static int[] GetTimeTextUnit_Cal;

	private static long[] GetTimeTextUnit_Times;

	private static long[] GetTimeTextUnit_Mul;

	private static string[] GetTimeTextUnit_Unit;

	public static JTimeZone TimeZone
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static long TimeOffset { get; set; }

	public static long GetTimeMillis()
	{
		return 0L;
	}

	public static float GetTimeMillisF()
	{
		return 0f;
	}

	public static string GetTimeText(long time)
	{
		return null;
	}

	public static string GetTimeText(long time, bool digital)
	{
		return null;
	}

	public static string GetTimeDigital(long time, bool hour = true, bool minute = true)
	{
		return null;
	}

	public static string GetTimeTextUnit(long time, bool useDay = false, int unitMax = 1, bool fig = false, char fill = ' ')
	{
		return null;
	}

	public static TimeElements GetTimeElements(long time)
	{
		return default;
	}

	public static Calendar GetCalendar()
	{
		return default;
	}

	public static Calendar GetCalendar(long time)
	{
		return default;
	}

	public static long GetCalendarTime(int year, int month = 1, int day = 1, int hour = 0, int minute = 0, int second = 0, int ms = 0)
	{
		return 0L;
	}
}
