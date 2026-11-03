using System;
using System.Collections;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;

namespace kairo.unity.secure;

public sealed class XString : IComparable, ICloneable, IComparable<string>, IEnumerable, IEquatable<string>
{
	private int bitmask_;

	private string original_;

	private char[] value_;

	private char[] buffer_;

	private int hashCode_;

	internal string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public char this[int index] => '\0';

	public int Length => 0;

	private void Generate(char[] from, char[] to)
	{
	}

	private char Generate(char value)
	{
		return '\0';
	}

	public XString(string value)
	{
	}

	public XString(char[] value)
	{
	}

	public XString(char c, int count)
	{
	}

	public XString(char[] value, int startIndex, int length)
	{
	}

	public static implicit operator string(XString s)
	{
		return null;
	}

	public static implicit operator XString(string s)
	{
		return null;
	}

	public static XString operator +(XString z, string w)
	{
		return null;
	}

	public static XString operator +(string z, XString w)
	{
		return null;
	}

	public static XString operator +(XString z, XString w)
	{
		return null;
	}

	public static bool operator !=(XString a, XString b)
	{
		return false;
	}

	public static bool operator ==(XString a, XString b)
	{
		return false;
	}

	public object Clone()
	{
		return null;
	}

	public int CompareTo(object value)
	{
		return 0;
	}

	public int CompareTo(string strB)
	{
		return 0;
	}

	public bool Contains(string value)
	{
		return false;
	}

	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
	{
	}

	public bool EndsWith(string value)
	{
		return false;
	}

	[ComVisible(false)]
	public bool EndsWith(string value, StringComparison comparisonType)
	{
		return false;
	}

	public bool EndsWith(string value, bool ignoreCase, CultureInfo culture)
	{
		return false;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public bool Equals(string value)
	{
		return false;
	}

	public bool Equals(string value, StringComparison comparisonType)
	{
		return false;
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public override int GetHashCode()
	{
		return 0;
	}

	public TypeCode GetTypeCode()
	{
		return TypeCode.Empty;
	}

	public int IndexOf(char value)
	{
		return 0;
	}

	public int IndexOf(string value)
	{
		return 0;
	}

	public int IndexOf(char value, int startIndex)
	{
		return 0;
	}

	public int IndexOf(string value, int startIndex)
	{
		return 0;
	}

	public int IndexOf(string value, StringComparison comparisonType)
	{
		return 0;
	}

	public int IndexOf(char value, int startIndex, int count)
	{
		return 0;
	}

	public int IndexOf(string value, int startIndex, int count)
	{
		return 0;
	}

	public int IndexOf(string value, int startIndex, StringComparison comparisonType)
	{
		return 0;
	}

	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
	{
		return 0;
	}

	public int IndexOfAny(char[] anyOf)
	{
		return 0;
	}

	public int IndexOfAny(char[] anyOf, int startIndex)
	{
		return 0;
	}

	public int IndexOfAny(char[] anyOf, int startIndex, int count)
	{
		return 0;
	}

	public XString Insert(int startIndex, string value)
	{
		return null;
	}

	public bool IsNormalized()
	{
		return false;
	}

	public bool IsNormalized(NormalizationForm normalizationForm)
	{
		return false;
	}

	public int LastIndexOf(char value)
	{
		return 0;
	}

	public int LastIndexOf(string value)
	{
		return 0;
	}

	public int LastIndexOf(char value, int startIndex)
	{
		return 0;
	}

	public int LastIndexOf(string value, int startIndex)
	{
		return 0;
	}

	public int LastIndexOf(string value, StringComparison comparisonType)
	{
		return 0;
	}

	public int LastIndexOf(char value, int startIndex, int count)
	{
		return 0;
	}

	public int LastIndexOf(string value, int startIndex, int count)
	{
		return 0;
	}

	public int LastIndexOf(string value, int startIndex, StringComparison comparisonType)
	{
		return 0;
	}

	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
	{
		return 0;
	}

	public int LastIndexOfAny(char[] anyOf)
	{
		return 0;
	}

	public int LastIndexOfAny(char[] anyOf, int startIndex)
	{
		return 0;
	}

	public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
	{
		return 0;
	}

	public XString Normalize()
	{
		return null;
	}

	public XString Normalize(NormalizationForm normalizationForm)
	{
		return null;
	}

	public XString PadLeft(int totalWidth)
	{
		return null;
	}

	public XString PadLeft(int totalWidth, char paddingChar)
	{
		return null;
	}

	public XString PadRight(int totalWidth)
	{
		return null;
	}

	public XString PadRight(int totalWidth, char paddingChar)
	{
		return null;
	}

	public XString Remove(int startIndex)
	{
		return null;
	}

	public XString Remove(int startIndex, int count)
	{
		return null;
	}

	public XString Replace(char oldChar, char newChar)
	{
		return null;
	}

	public XString Replace(string oldValue, string newValue)
	{
		return null;
	}

	public XString[] Split(params char[] separator)
	{
		return null;
	}

	public XString[] Split(char[] separator, int count)
	{
		return null;
	}

	[ComVisible(false)]
	public XString[] Split(char[] separator, StringSplitOptions options)
	{
		return null;
	}

	[ComVisible(false)]
	public XString[] Split(string[] separator, StringSplitOptions options)
	{
		return null;
	}

	[ComVisible(false)]
	public XString[] Split(char[] separator, int count, StringSplitOptions options)
	{
		return null;
	}

	[ComVisible(false)]
	public XString[] Split(string[] separator, int count, StringSplitOptions options)
	{
		return null;
	}

	public bool StartsWith(string value)
	{
		return false;
	}

	[ComVisible(false)]
	public bool StartsWith(string value, StringComparison comparisonType)
	{
		return false;
	}

	public bool StartsWith(string value, bool ignoreCase, CultureInfo culture)
	{
		return false;
	}

	public XString Substring(int startIndex)
	{
		return null;
	}

	public XString Substring(int startIndex, int length)
	{
		return null;
	}

	public char[] ToCharArray()
	{
		return null;
	}

	public char[] ToCharArray(int startIndex, int length)
	{
		return null;
	}

	public XString ToLower()
	{
		return null;
	}

	public XString ToLower(CultureInfo culture)
	{
		return null;
	}

	public XString ToLowerInvariant()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public XString ToString(IFormatProvider provider)
	{
		return null;
	}

	public XString ToUpper()
	{
		return null;
	}

	public XString ToUpper(CultureInfo culture)
	{
		return null;
	}

	public XString ToUpperInvariant()
	{
		return null;
	}

	public XString Trim()
	{
		return null;
	}

	public XString Trim(params char[] trimChars)
	{
		return null;
	}

	public XString TrimEnd(params char[] trimChars)
	{
		return null;
	}

	public XString TrimStart(params char[] trimChars)
	{
		return null;
	}

	public char CharAt(int index)
	{
		return '\0';
	}

	public bool EqualsIgnoreCase(string anotherString)
	{
		return false;
	}

	public byte[] GetBytes()
	{
		return null;
	}

	public byte[] GetBytes(string enc)
	{
		return null;
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

	public bool StartsWith(string prefix, int toffset)
	{
		return false;
	}

	public XString ToLowerCase()
	{
		return null;
	}

	public XString ToUpperCase()
	{
		return null;
	}

	public XString SubstringJ(int beginIndex, int endIndex)
	{
		return null;
	}

	public XString SubstringJ(int beginIndex)
	{
		return null;
	}

	public static XString ValueOf(object obj)
	{
		return null;
	}

	public static XString ValueOf(char[] data)
	{
		return null;
	}

	public static XString ValueOf(char[] data, int offset, int count)
	{
		return null;
	}

	public static XString ValueOf(bool b)
	{
		return null;
	}

	public static XString ValueOf(char c)
	{
		return null;
	}

	public static XString ValueOf(int i)
	{
		return null;
	}

	public static XString ValueOf(long l)
	{
		return null;
	}

	public static XString ValueOf(string str)
	{
		return null;
	}

	public static XString ValueOf(byte[] bytes)
	{
		return null;
	}

	public static string[] ToArray(XString[] src)
	{
		return null;
	}

	public static string[][] ToArray(XString[][] src)
	{
		return null;
	}

	public static string[][][] ToArray(XString[][][] src)
	{
		return null;
	}

	public static string[][][][] ToArray(XString[][][][] src)
	{
		return null;
	}

	public static string[][][][][] ToArray(XString[][][][][] src)
	{
		return null;
	}

	public static XString[] ToArray(string[] src)
	{
		return null;
	}

	public static XString[][] ToArray(string[][] src)
	{
		return null;
	}

	public static XString[][][] ToArray(string[][][] src)
	{
		return null;
	}

	public static XString[][][][] ToArray(string[][][][] src)
	{
		return null;
	}

	public static XString[][][][][] ToArray(string[][][][][] src)
	{
		return null;
	}
}
