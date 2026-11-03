using java.io;

namespace kairo.unity.io;

public class ByteListOutputStream : OutputStream
{
	protected const int BUFFER_SIZE = 256;

	protected byte[][] list_;

	protected int count_;

	protected int clst_;

	protected int cidx_;

	public ByteListOutputStream()
	{
	}

	public ByteListOutputStream(int size)
	{
	}

	protected void _init(int listNum)
	{
	}

	public override void Close()
	{
	}

	public void Reset()
	{
	}

	public int Size()
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

	public override void Write(byte[] b, int off, int len)
	{
	}

	public override void Write(byte[] b)
	{
	}

	public override void Write(int b)
	{
	}

	public override void Flush()
	{
	}

	protected void _expand()
	{
	}
}
