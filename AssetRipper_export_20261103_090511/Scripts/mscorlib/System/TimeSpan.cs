namespace System;

[Serializable]
public readonly struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable
{
	public const long TicksPerMillisecond = 10000L;

	private const double MillisecondsPerTick = 0.0001;

	public const long TicksPerSecond = 10000000L;

	private const double SecondsPerTick = 1E-07;

	public const long TicksPerMinute = 600000000L;

	private const double MinutesPerTick = 1.6666666666666667E-09;

	public const long TicksPerHour = 36000000000L;

	private const double HoursPerTick = 2.7777777777777777E-11;

	public const long TicksPerDay = 864000000000L;

	private const double DaysPerTick = 1.1574074074074074E-12;

	private const int MillisPerSecond = 1000;

	private const int MillisPerMinute = 60000;

	private const int MillisPerHour = 3600000;

	private const int MillisPerDay = 86400000;

	internal const long MaxSeconds = 922337203685L;

	internal const long MinSeconds = -922337203685L;

	internal const long MaxMilliSeconds = 922337203685477L;

	internal const long MinMilliSeconds = -922337203685477L;

	internal const long TicksPerTenthSecond = 1000000L;

	public static readonly TimeSpan Zero;

	public static readonly TimeSpan MaxValue;

	public static readonly TimeSpan MinValue;

	internal readonly long _ticks = 0L;

	public long Ticks => 0L;

	public int Hours => 0;

	public int Minutes => 0;

	public int Seconds => 0;

	public double TotalDays => 0.0;

	public double TotalHours => 0.0;

	public double TotalMilliseconds => 0.0;

	public TimeSpan(long ticks)
	{
	}

	public TimeSpan(int hours, int minutes, int seconds)
	{
	}

	public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
	{
	}

	public TimeSpan Add(TimeSpan ts)
	{
		return default;
	}

	public int CompareTo(object value)
	{
		return 0;
	}

	public int CompareTo(TimeSpan value)
	{
		return 0;
	}

	public static TimeSpan FromDays(double value)
	{
		return default;
	}

	public override bool Equals(object value)
	{
		return false;
	}

	public bool Equals(TimeSpan obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static TimeSpan FromHours(double value)
	{
		return default;
	}

	private static TimeSpan Interval(double value, int scale)
	{
		return default;
	}

	public static TimeSpan FromMilliseconds(double value)
	{
		return default;
	}

	public static TimeSpan FromMinutes(double value)
	{
		return default;
	}

	public TimeSpan Negate()
	{
		return default;
	}

	public static TimeSpan FromSeconds(double value)
	{
		return default;
	}

	public TimeSpan Subtract(TimeSpan ts)
	{
		return default;
	}

	public static TimeSpan FromTicks(long value)
	{
		return default;
	}

	internal static long TimeToTicks(int hour, int minute, int second)
	{
		return 0L;
	}

	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, out TimeSpan result)
	{
		result = default;
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(string format)
	{
		return null;
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider formatProvider = null)
	{
		charsWritten = default;
		return false;
	}

	public static TimeSpan operator -(TimeSpan t)
	{
		return default;
	}

	public static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
	{
		return default;
	}

	public static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
	{
		return default;
	}

	public static bool operator ==(TimeSpan t1, TimeSpan t2)
	{
		return false;
	}

	public static bool operator !=(TimeSpan t1, TimeSpan t2)
	{
		return false;
	}

	public static bool operator <(TimeSpan t1, TimeSpan t2)
	{
		return false;
	}

	public static bool operator <=(TimeSpan t1, TimeSpan t2)
	{
		return false;
	}

	public static bool operator >(TimeSpan t1, TimeSpan t2)
	{
		return false;
	}

	public static bool operator >=(TimeSpan t1, TimeSpan t2)
	{
		return false;
	}
}
