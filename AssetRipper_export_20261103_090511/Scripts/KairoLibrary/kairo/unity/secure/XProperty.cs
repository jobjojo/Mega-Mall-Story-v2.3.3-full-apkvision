using java.io;
using kairo.unity.util;

namespace kairo.unity.secure;

public class XProperty : PropertyBase
{
	public XProperty[] pros;

	public XInt[] ints;

	public XLong[] lngs;

	public XString[] strs;

	public static implicit operator Property(XProperty s)
	{
		return null;
	}

	public static implicit operator XProperty(Property s)
	{
		return null;
	}

	public XProperty()
	{
	}

	public XProperty(Property[] pros, int[] ints, long[] lngs, string[] strs, byte[][] bins)
	{
	}

	public XProperty(XProperty[] pros, XInt[] ints, XLong[] lngs, XString[] strs, byte[][] bins)
	{
	}

	public XProperty(XProperty property)
	{
	}

	public XProperty(Property property)
	{
	}

	public void SetData(int[] data)
	{
	}

	public void SetData(XInt[] data)
	{
	}

	public void SetData(long[] data)
	{
	}

	public void SetData(XLong[] data)
	{
	}

	public void SetData(string[] data)
	{
	}

	public void SetData(XString[] data)
	{
	}

	public void SetData(byte[][] data)
	{
	}

	public void SetData(Property[] data)
	{
	}

	public void SetData(XProperty[] data)
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

	public Property Get()
	{
		return null;
	}

	public override Property ToProperty()
	{
		return null;
	}
}
