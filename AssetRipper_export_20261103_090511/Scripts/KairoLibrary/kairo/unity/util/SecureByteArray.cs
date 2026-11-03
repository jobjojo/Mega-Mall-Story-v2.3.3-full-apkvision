namespace kairo.unity.util;

public sealed class SecureByteArray : SecureNumber
{
	private new byte[] original_;

	private new byte[] value_;

	private byte[] buffer_;

	public int length;

	public byte this[int index] => 0;

	public static implicit operator byte[](SecureByteArray s)
	{
		return null;
	}

	public static implicit operator SecureByteArray(byte[] s)
	{
		return null;
	}

	public SecureByteArray()
	{
	}

	public SecureByteArray(byte[] ary)
	{
	}

	public SecureByteArray(SecureByteArray src)
	{
	}

	public SecureByteArray Set(byte[] ary)
	{
		return null;
	}

	public byte[] Get()
	{
		return null;
	}

	public byte[] ToArray()
	{
		return null;
	}

	private void Generate(byte[] from, byte[] to)
	{
	}

	private byte Generate(byte value)
	{
		return 0;
	}

	public static void Arraycopy(SecureByteArray srcArray, int srcIndex, SecureByteArray dstArray, int dstIndex, int length)
	{
	}

	public static SecureByteArray ValueOf(byte[] ary)
	{
		return null;
	}

	public static byte[] ToArray(SecureByteArray ary)
	{
		return null;
	}
}
