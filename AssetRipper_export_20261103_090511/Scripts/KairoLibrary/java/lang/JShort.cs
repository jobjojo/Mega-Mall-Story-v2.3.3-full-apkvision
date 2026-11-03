namespace java.lang;

public class JShort
{
	private short value_;

	public const short MAX_VALUE = short.MaxValue;

	public const short MIN_VALUE = short.MinValue;

	public static implicit operator short(JShort s)
	{
		return 0;
	}

	public static implicit operator JShort(short s)
	{
		return null;
	}

	public JShort(short value)
	{
	}

	public short ShortValue()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public static short ParseShort(string s)
	{
		return 0;
	}

	public static short ParseShort(string s, int radix)
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
