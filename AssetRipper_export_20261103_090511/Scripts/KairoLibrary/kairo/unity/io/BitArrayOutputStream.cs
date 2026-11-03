namespace kairo.unity.io;

public class BitArrayOutputStream
{
	protected ByteListOutputStream blos_;

	protected int buf_;

	protected int len_;

	protected int count_;

	public void Close()
	{
	}

	public void Reset()
	{
	}

	public int Size()
	{
		return 0;
	}

	public int BitCount()
	{
		return 0;
	}

	public byte[] ToByteArray()
	{
		return null;
	}

	public byte[] ToByteArray(int index, int length)
	{
		return null;
	}

	public byte[] ToByteArray(int index, int length, byte[] dst)
	{
		return null;
	}

	public void Write(int b)
	{
	}

	public void Flush()
	{
	}
}
