using java.util;

namespace kairo.unity.util;

public abstract class SecureNumber
{
	protected static JRandom random_;

	protected static long hacking_;

	protected long bitmask_;

	protected long original_;

	protected long value_;

	private object lock_set_long;

	private object lock_get_long;

	public SecureNumber()
	{
	}

	public SecureNumber(long value)
	{
	}

	public SecureNumber(SecureNumber src)
	{
	}

	protected SecureNumber SetLong(long value)
	{
		return null;
	}

	protected byte GetByte()
	{
		return 0;
	}

	protected short GetShort()
	{
		return 0;
	}

	protected int GetInt()
	{
		return 0;
	}

	protected long GetLong()
	{
		return 0L;
	}

	private long Generate(long value)
	{
		return 0L;
	}

	public override string ToString()
	{
		return null;
	}

	public static long GetHackingCount()
	{
		return 0L;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
