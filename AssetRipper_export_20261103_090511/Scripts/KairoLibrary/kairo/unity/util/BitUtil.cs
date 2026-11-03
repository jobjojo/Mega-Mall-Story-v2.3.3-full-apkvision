namespace kairo.unity.util;

public class BitUtil
{
	private static sbyte[] split_tmpB;

	private static short[] split_tmpS;

	private static int[] split_tmpI;

	private BitUtil()
	{
	}

	public static bool Check(long v, long bit)
	{
		return false;
	}

	public static bool CheckAll(long v, long bit)
	{
		return false;
	}

	public static long On(long v, long bit)
	{
		return 0L;
	}

	public static long Off(long v, long bit)
	{
		return 0L;
	}

	public static bool Check(int v, int bit)
	{
		return false;
	}

	public static bool CheckAll(int v, int bit)
	{
		return false;
	}

	public static int On(int v, int bit)
	{
		return 0;
	}

	public static int Off(int v, int bit)
	{
		return 0;
	}

	public static int On(byte v, byte bit)
	{
		return 0;
	}

	public static byte Off(byte v, byte bit)
	{
		return 0;
	}

	public static int On(sbyte v, sbyte bit)
	{
		return 0;
	}

	public static sbyte Off(sbyte v, sbyte bit)
	{
		return 0;
	}

	public static short On(short v, short bit)
	{
		return 0;
	}

	public static short Off(short v, short bit)
	{
		return 0;
	}

	public static short Join(byte high, byte low)
	{
		return 0;
	}

	public static short Join(sbyte high, sbyte low)
	{
		return 0;
	}

	public static sbyte[] Split(short value)
	{
		return null;
	}

	public static int Join(short high, short low)
	{
		return 0;
	}

	public static short[] Split(int value)
	{
		return null;
	}

	public static long Join(int high, int low)
	{
		return 0L;
	}

	public static int[] Split(long value)
	{
		return null;
	}

	private static int EncodeInt(params int[] values)
	{
		return 0;
	}
}
