namespace kairo.unity.util;

public class CRC64
{
	public const int SIZE = 8;

	private static long[] crcTable_;

	private CRC64()
	{
	}

	private static void MakeCrcTable()
	{
	}

	private static long Update(long crc, byte[] buf, int len)
	{
		return 0L;
	}

	public static long GetValue(byte[] buf)
	{
		return 0L;
	}
}
