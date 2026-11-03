namespace kairo.unity.util;

public class SecureByte : SecureNumber
{
	public static implicit operator sbyte(SecureByte s)
	{
		return 0;
	}

	public static implicit operator SecureByte(sbyte s)
	{
		return null;
	}

	public static SecureByte operator ++(SecureByte z)
	{
		return null;
	}

	public static SecureByte operator --(SecureByte z)
	{
		return null;
	}

	public SecureByte()
	{
	}

	public SecureByte(sbyte value)
	{
	}

	public SecureByte(SecureByte src)
	{
	}

	internal SecureByte Set(sbyte value)
	{
		return null;
	}

	internal SecureByte Set(SecureByte value)
	{
		return null;
	}

	public sbyte Get()
	{
		return 0;
	}

	public static SecureByte[] Array(int n)
	{
		return null;
	}

	public static SecureByte[][] Array(int n1, int n2)
	{
		return null;
	}

	public static void Arraycopy(SecureByte[] srcArray, int srcIndex, SecureByte[] dstArray, int dstIndex, int length)
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
