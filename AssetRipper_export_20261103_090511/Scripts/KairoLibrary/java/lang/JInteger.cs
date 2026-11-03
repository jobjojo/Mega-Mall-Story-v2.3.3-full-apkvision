namespace java.lang;

public class JInteger
{
	private int value_;

	public const int MAX_VALUE = int.MaxValue;

	public const int MIN_VALUE = int.MinValue;

	public static implicit operator int(JInteger s)
	{
		return 0;
	}

	public static implicit operator JInteger(int s)
	{
		return null;
	}

	public JInteger(int value)
	{
	}

	public int IntValue()
	{
		return 0;
	}

	public static JInteger ValueOf(string s)
	{
		return null;
	}

	public static JInteger ValueOf(string s, int radix)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public static string ToString(int i)
	{
		return null;
	}

	public static string ToString(int i, int radix)
	{
		return null;
	}

	public static string ToBinaryString(int i)
	{
		return null;
	}

	public static string ToHexString(int i)
	{
		return null;
	}

	public static string ToOctalString(int i)
	{
		return null;
	}

	public static int ParseInt(string s)
	{
		return 0;
	}

	public static int ParseInt(string s, int radix)
	{
		return 0;
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
