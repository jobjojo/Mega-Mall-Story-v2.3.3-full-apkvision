using java.io;

namespace kairo.unity.util;

public class Property : PropertyBase
{
	public Property[] pros;

	public int[] ints;

	public long[] lngs;

	public string[] strs;

	public Property()
	{
	}

	public Property(Property[] pros, int[] ints, long[] lngs, string[] strs, byte[][] bins)
	{
	}

	public Property(Property property)
	{
	}

	public void SetData(int[] data)
	{
	}

	public void SetData(long[] data)
	{
	}

	public void SetData(string[] data)
	{
	}

	public void SetData(byte[][] data)
	{
	}

	public void SetData(Property[] data)
	{
	}

	public void Load(byte[] data)
	{
	}

	public void Load(InputStream stream)
	{
	}

	public void Load_iOS_OLD(byte[] data)
	{
	}

	public void Load_iOS_OLD(InputStream stream)
	{
	}

	protected void Read_iOS_OLD(InputStream stream, int type, int size, byte[] ids)
	{
	}

	public override byte[] ToByteArray()
	{
		return null;
	}

	public void ToByteArray(OutputStream os)
	{
	}

	protected void Read(InputStream stream, int type, int size, byte[] ids)
	{
	}

	protected void Write(OutputStream os, int type)
	{
	}

	public int Size(int type)
	{
		return 0;
	}

	public void DisposeBin()
	{
	}

	public override Property ToProperty()
	{
		return null;
	}
}
