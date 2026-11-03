namespace java.lang;

public class JByte
{
	private sbyte value_;

	public const sbyte MAX_VALUE = sbyte.MaxValue;

	public const sbyte MIN_VALUE = sbyte.MinValue;

	public static implicit operator sbyte(JByte s)
	{
		return 0;
	}

	public static implicit operator JByte(sbyte s)
	{
		return null;
	}

	public JByte(sbyte value)
	{
	}

	public sbyte ByteValue()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public static sbyte ParseByte(string s)
	{
		return 0;
	}

	public static sbyte ParseByte(string s, int radix)
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
