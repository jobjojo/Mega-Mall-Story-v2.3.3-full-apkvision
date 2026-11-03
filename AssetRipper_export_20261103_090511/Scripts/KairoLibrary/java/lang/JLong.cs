namespace java.lang;

public class JLong
{
	private long value_;

	public const long MAX_VALUE = long.MaxValue;

	public const long MIN_VALUE = long.MinValue;

	public static implicit operator long(JLong s)
	{
		return 0L;
	}

	public static implicit operator JLong(long s)
	{
		return null;
	}

	public JLong(long value)
	{
	}

	public long LongValue()
	{
		return 0L;
	}

	public override string ToString()
	{
		return null;
	}

	public static string ToString(long i)
	{
		return null;
	}

	public static string ToString(long i, int radix)
	{
		return null;
	}

	public static long ParseLong(string s)
	{
		return 0L;
	}

	public static long ParseLong(string s, int radix)
	{
		return 0L;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
