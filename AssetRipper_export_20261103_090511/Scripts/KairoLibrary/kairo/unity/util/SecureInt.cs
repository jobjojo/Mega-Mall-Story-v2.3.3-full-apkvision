namespace kairo.unity.util;

public class SecureInt : SecureNumber
{
	public static implicit operator int(SecureInt s)
	{
		return 0;
	}

	public static implicit operator SecureInt(int s)
	{
		return null;
	}

	public static implicit operator SecureInt(short s)
	{
		return null;
	}

	public static implicit operator SecureInt(sbyte s)
	{
		return null;
	}

	public static implicit operator SecureInt(SecureShort s)
	{
		return null;
	}

	public static implicit operator SecureInt(SecureByte s)
	{
		return null;
	}

	public static SecureInt operator ++(SecureInt z)
	{
		return null;
	}

	public static SecureInt operator --(SecureInt z)
	{
		return null;
	}

	public SecureInt()
	{
	}

	public SecureInt(int value)
	{
	}

	public SecureInt(SecureInt src)
	{
	}

	internal SecureInt Set(int value)
	{
		return null;
	}

	internal SecureInt Set(SecureInt value)
	{
		return null;
	}

	public int Get()
	{
		return 0;
	}

	public static SecureInt[] Array(int n)
	{
		return null;
	}

	public static SecureInt[][] Array(int n1, int n2)
	{
		return null;
	}

	public static void Arraycopy(SecureInt[] srcArray, int srcIndex, SecureInt[] dstArray, int dstIndex, int length)
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
