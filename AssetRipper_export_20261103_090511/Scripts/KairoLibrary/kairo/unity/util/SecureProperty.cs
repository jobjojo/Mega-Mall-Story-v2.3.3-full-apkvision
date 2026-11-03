using java.io;

namespace kairo.unity.util;

public class SecureProperty : PropertyBase
{
	public SecureProperty[] pros;

	public SecureInt[] ints;

	public SecureLong[] lngs;

	public SecureString[] strs;

	public SecureProperty()
	{
	}

	public SecureProperty(SecureProperty[] pros, int[] ints, long[] lngs, string[] strs, byte[][] bins)
	{
	}

	public SecureProperty(SecureProperty[] pros, SecureInt[] ints, SecureLong[] lngs, SecureString[] strs, byte[][] bins)
	{
	}

	public SecureProperty(SecureProperty property)
	{
	}

	public void SetData(SecureInt[] data)
	{
	}

	public void SetData(int[] data)
	{
	}

	public void SetData(SecureLong[] data)
	{
	}

	public void SetData(long[] data)
	{
	}

	public void SetData(SecureString[] data)
	{
	}

	public void SetData(string[] data)
	{
	}

	public void SetData(byte[][] data)
	{
	}

	public void SetData(SecureProperty[] data)
	{
	}

	public void Load(byte[] data)
	{
	}

	public void Load(InputStream stream)
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
