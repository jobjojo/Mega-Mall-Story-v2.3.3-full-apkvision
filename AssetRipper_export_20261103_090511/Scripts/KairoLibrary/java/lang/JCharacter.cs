namespace java.lang;

public class JCharacter
{
	private char value_;

	public const char MAX_VALUE = '\uffff';

	public const char MIN_VALUE = '\0';

	public static implicit operator char(JCharacter s)
	{
		return '\0';
	}

	public static implicit operator JCharacter(char s)
	{
		return null;
	}

	public JCharacter(char value)
	{
	}

	public char CharValue()
	{
		return '\0';
	}

	public override string ToString()
	{
		return null;
	}

	public static bool IsDigit(char ch)
	{
		return false;
	}

	public static bool IsLowerCase(char ch)
	{
		return false;
	}

	public static bool IsUpperCase(char ch)
	{
		return false;
	}

	public static char ToLowerCase(char ch)
	{
		return '\0';
	}

	public static char ToUpperCase(char ch)
	{
		return '\0';
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
