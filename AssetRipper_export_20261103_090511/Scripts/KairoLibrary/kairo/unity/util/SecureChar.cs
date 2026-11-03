namespace kairo.unity.util;

public class SecureChar : SecureNumber
{
	public static implicit operator char(SecureChar s)
	{
		return '\0';
	}

	public static implicit operator SecureChar(char s)
	{
		return null;
	}

	public SecureChar()
	{
	}

	public SecureChar(char value)
	{
	}

	public SecureChar(SecureChar src)
	{
	}

	internal SecureChar Set(char value)
	{
		return null;
	}

	internal SecureChar Set(SecureChar value)
	{
		return null;
	}

	public char Get()
	{
		return '\0';
	}

	public static SecureChar[] Array(int n)
	{
		return null;
	}

	public static SecureChar[][] Array(int n1, int n2)
	{
		return null;
	}

	public static void Arraycopy(SecureChar[] srcArray, int srcIndex, SecureChar[] dstArray, int dstIndex, int length)
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
