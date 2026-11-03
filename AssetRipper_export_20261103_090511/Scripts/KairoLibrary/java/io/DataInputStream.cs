using System;
using System.IO;

namespace java.io;

public class DataInputStream : InputStream, IDisposable
{
	private BinaryReader br_;

	public DataInputStream(InputStream stream)
	{
	}

	public bool ReadBoolean()
	{
		return false;
	}

	public sbyte ReadByte()
	{
		return 0;
	}

	public byte ReadUnsignedByte()
	{
		return 0;
	}

	public char ReadChar()
	{
		return '\0';
	}

	public short ReadShort()
	{
		return 0;
	}

	public int ReadUnsignedShort()
	{
		return 0;
	}

	public int ReadInt()
	{
		return 0;
	}

	public int ReadIntLE()
	{
		return 0;
	}

	public long ReadLong()
	{
		return 0L;
	}

	public float ReadFloat()
	{
		return 0f;
	}

	public double ReadDouble()
	{
		return 0.0;
	}

	public string ReadUTF()
	{
		return null;
	}

	public int SkipBytes(int n)
	{
		return 0;
	}

	public void ReadFully(byte[] b)
	{
	}

	public void ReadFully(byte[] b, int off, int len)
	{
	}

	public override void Close()
	{
	}

	protected void Reverse(byte[] data)
	{
	}
}
