using System;
using System.Runtime.InteropServices;

namespace kairo.unity.secure;

[Serializable]
[ComVisible(true)]
public struct XShort : IComparable, IComparable<short>, IEquatable<short>
{
	private int bitmask_ = 0;

	private short original_ = 0;

	private short value_ = 0;

	private object lock_ = null;

	internal short Value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static implicit operator short(XShort s)
	{
		return 0;
	}

	public static implicit operator XShort(short s)
	{
		return default;
	}

	public static XShort operator ++(XShort z)
	{
		return default;
	}

	public static XShort operator --(XShort z)
	{
		return default;
	}

	public XShort(short value)
	{
	}

	public XShort(XShort src)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(short obj)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	public string ToString(string format)
	{
		return null;
	}

	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	public int CompareTo(short value)
	{
		return 0;
	}

	public int CompareTo(object value)
	{
		return 0;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static short[] ToArray(XShort[] src)
	{
		return null;
	}

	public static short[][] ToArray(XShort[][] src)
	{
		return null;
	}

	public static short[][][] ToArray(XShort[][][] src)
	{
		return null;
	}

	public static short[][][][] ToArray(XShort[][][][] src)
	{
		return null;
	}

	public static short[][][][][] ToArray(XShort[][][][][] src)
	{
		return null;
	}

	public static XShort[] ToArray(short[] src)
	{
		return null;
	}

	public static XShort[][] ToArray(short[][] src)
	{
		return null;
	}

	public static XShort[][][] ToArray(short[][][] src)
	{
		return null;
	}

	public static XShort[][][][] ToArray(short[][][][] src)
	{
		return null;
	}

	public static XShort[][][][][] ToArray(short[][][][][] src)
	{
		return null;
	}
}
