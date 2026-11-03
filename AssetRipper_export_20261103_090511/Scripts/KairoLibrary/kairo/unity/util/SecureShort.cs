namespace kairo.unity.util;

public class SecureShort : SecureNumber
{
	public static implicit operator short(SecureShort s)
	{
		return 0;
	}

	public static implicit operator SecureShort(short s)
	{
		return null;
	}

	public static implicit operator SecureShort(sbyte s)
	{
		return null;
	}

	public static implicit operator SecureShort(SecureByte s)
	{
		return null;
	}

	public static SecureShort operator ++(SecureShort z)
	{
		return null;
	}

	public static SecureShort operator --(SecureShort z)
	{
		return null;
	}

	public SecureShort()
	{
	}

	public SecureShort(short value)
	{
	}

	public SecureShort(SecureShort src)
	{
	}

	internal SecureShort Set(short value)
	{
		return null;
	}

	internal SecureShort Set(SecureShort value)
	{
		return null;
	}

	public short Get()
	{
		return 0;
	}

	public static SecureShort[] Array(int n)
	{
		return null;
	}

	public static SecureShort[][] Array(int n1, int n2)
	{
		return null;
	}

	public static void Arraycopy(SecureShort[] srcArray, int srcIndex, SecureShort[] dstArray, int dstIndex, int length)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
