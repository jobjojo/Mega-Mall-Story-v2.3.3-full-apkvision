namespace kairo.unity.io;

public class BitArrayInputStream
{
	protected byte[] buf_;

	protected int index_;

	protected int bit_;

	public BitArrayInputStream(byte[] buf)
	{
	}

	public BitArrayInputStream(byte[] buf, int offset)
	{
	}

	public int Read()
	{
		return 0;
	}

	public void Close()
	{
	}

	public long Skip(long n)
	{
		return 0L;
	}
}
