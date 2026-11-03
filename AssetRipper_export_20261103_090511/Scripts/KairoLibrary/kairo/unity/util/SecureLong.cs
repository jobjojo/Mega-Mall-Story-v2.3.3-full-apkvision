namespace kairo.unity.util;

public class SecureLong : SecureNumber
{
	public static implicit operator long(SecureLong s)
	{
		return 0L;
	}

	public static implicit operator SecureLong(long s)
	{
		return null;
	}

	public static implicit operator SecureLong(int s)
	{
		return null;
	}

	public static implicit operator SecureLong(short s)
	{
		return null;
	}

	public static implicit operator SecureLong(sbyte s)
	{
		return null;
	}

	public static implicit operator SecureLong(SecureInt s)
	{
		return null;
	}

	public static implicit operator SecureLong(SecureShort s)
	{
		return null;
	}

	public static implicit operator SecureLong(SecureByte s)
	{
		return null;
	}

	public static SecureLong operator ++(SecureLong z)
	{
		return null;
	}

	public static SecureLong operator --(SecureLong z)
	{
		return null;
	}

	public SecureLong()
	{
	}

	public SecureLong(long value)
	{
	}

	public SecureLong(SecureLong src)
	{
	}

	internal SecureLong Set(long value)
	{
		return null;
	}

	internal SecureLong Set(SecureLong value)
	{
		return null;
	}

	public long Get()
	{
		return 0L;
	}

	public static SecureLong[] Array(int n)
	{
		return null;
	}

	public static SecureLong[][] Array(int n1, int n2)
	{
		return null;
	}

	public static void Arraycopy(SecureLong[] srcArray, int srcIndex, SecureLong[] dstArray, int dstIndex, int length)
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
