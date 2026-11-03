using System.Text;

namespace kairo.unity.util;

public class SecureString : SecureNumber
{
	private new string original_;

	private new char[] value_;

	private char[] buffer_;

	private int hashCode_;

	public char this[int index] => '\0';

	public static implicit operator string(SecureString s)
	{
		return null;
	}

	public static implicit operator SecureString(string s)
	{
		return null;
	}

	public static SecureString operator +(SecureString z, string w)
	{
		return null;
	}

	public static SecureString operator +(string z, SecureString w)
	{
		return null;
	}

	public static SecureString operator +(SecureString z, SecureString w)
	{
		return null;
	}

	public SecureString()
	{
	}

	public SecureString(string value)
	{
	}

	public SecureString(char[] value)
	{
	}

	public SecureString(char[] value, int offset, int count)
	{
	}

	public SecureString(byte[] bytes, int offset, int count, string enc)
	{
	}

	public SecureString(byte[] bytes, string enc)
	{
	}

	public SecureString(byte[] bytes, int offset, int count)
	{
	}

	public SecureString(byte[] bytes)
	{
	}

	public SecureString(StringBuilder buffer)
	{
	}

	public SecureString(SecureString src)
	{
	}

	internal SecureString Set(string value)
	{
		return null;
	}

	internal SecureString Set(SecureString value)
	{
		return null;
	}

	public string Get()
	{
		return null;
	}

	private void Generate(char[] from, char[] to)
	{
	}

	private char Generate(char value)
	{
		return '\0';
	}

	public override string ToString()
	{
		return null;
	}

	public static SecureString[] Array(int n)
	{
		return null;
	}

	public static SecureString[][] Array(int n1, int n2)
	{
		return null;
	}

	public static void Arraycopy(SecureString[] srcArray, int srcIndex, SecureString[] dstArray, int dstIndex, int length)
	{
	}

	public int Length()
	{
		return 0;
	}

	public char CharAt(int index)
	{
		return '\0';
	}

	public void GetChars(int srcBegin, int srcEnd, char[] dst, int dstBegin)
	{
	}

	public byte[] GetBytes(string enc)
	{
		return null;
	}

	public byte[] GetBytes()
	{
		return null;
	}

	public bool Equals(string anObject)
	{
		return false;
	}

	public bool Equals(SecureString anObject)
	{
		return false;
	}

	public int CompareTo(string anotherString)
	{
		return 0;
	}

	public bool RegionMatches(bool ignoreCase, int toffset, string other, int ooffset, int len)
	{
		return false;
	}

	public bool StartsWith(string prefix, int toffset)
	{
		return false;
	}

	public bool StartsWith(string prefix)
	{
		return false;
	}

	public bool EndsWith(string suffix)
	{
		return false;
	}

	public int IndexOf(int ch)
	{
		return 0;
	}

	public int IndexOf(int ch, int fromIndex)
	{
		return 0;
	}

	public int LastIndexOf(int ch)
	{
		return 0;
	}

	public int LastIndexOf(int ch, int fromIndex)
	{
		return 0;
	}

	public int IndexOf(string str)
	{
		return 0;
	}

	public int IndexOf(string str, int fromIndex)
	{
		return 0;
	}

	public SecureString Substring(int beginIndex)
	{
		return null;
	}

	public SecureString Substring(int beginIndex, int length)
	{
		return null;
	}

	public SecureString SubstringJ(int beginIndex)
	{
		return null;
	}

	public SecureString SubstringJ(int beginIndex, int endIndex)
	{
		return null;
	}

	public SecureString Concat(string str)
	{
		return null;
	}

	public SecureString Replace(char oldChar, char newChar)
	{
		return null;
	}

	public SecureString ToLowerCase()
	{
		return null;
	}

	public SecureString ToUpperCase()
	{
		return null;
	}

	public SecureString Trim()
	{
		return null;
	}

	public char[] ToCharArray()
	{
		return null;
	}

	public static SecureString ValueOf(object obj)
	{
		return null;
	}

	public static SecureString ValueOf(char[] data)
	{
		return null;
	}

	public static SecureString ValueOf(char[] data, int offset, int count)
	{
		return null;
	}

	public static SecureString ValueOf(bool b)
	{
		return null;
	}

	public static SecureString ValueOf(char c)
	{
		return null;
	}

	public static SecureString ValueOf(int i)
	{
		return null;
	}

	public static SecureString ValueOf(long l)
	{
		return null;
	}

	public static SecureString ValueOf(string str)
	{
		return null;
	}

	public static SecureString ValueOf(byte[] bytes)
	{
		return null;
	}

	public static string ToString(SecureString str)
	{
		return null;
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
