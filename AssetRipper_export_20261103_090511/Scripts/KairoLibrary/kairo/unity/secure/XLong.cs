using System;
using System.Runtime.InteropServices;

namespace kairo.unity.secure;

[Serializable]
[ComVisible(true)]
public struct XLong : IComparable, IComparable<long>, IEquatable<long>
{
	private long bitmask_ = 0L;

	private long original_ = 0L;

	private long value_ = 0L;

	private object lock_ = null;

	internal long Value
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static implicit operator long(XLong s)
	{
		return 0L;
	}

	public static implicit operator XLong(long s)
	{
		return default;
	}

	public static implicit operator XLong(XShort s)
	{
		return default;
	}

	public static implicit operator XLong(XInt s)
	{
		return default;
	}

	public static XLong operator ++(XLong z)
	{
		return default;
	}

	public static XLong operator --(XLong z)
	{
		return default;
	}

	public XLong(long value)
	{
	}

	public XLong(XLong src)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(long obj)
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

	public int CompareTo(long value)
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

	public static long[] ToArray(XLong[] src)
	{
		return null;
	}

	public static long[][] ToArray(XLong[][] src)
	{
		return null;
	}

	public static long[][][] ToArray(XLong[][][] src)
	{
		return null;
	}

	public static long[][][][] ToArray(XLong[][][][] src)
	{
		return null;
	}

	public static long[][][][][] ToArray(XLong[][][][][] src)
	{
		return null;
	}

	public static XLong[] ToArray(long[] src)
	{
		return null;
	}

	public static XLong[][] ToArray(long[][] src)
	{
		return null;
	}

	public static XLong[][][] ToArray(long[][][] src)
	{
		return null;
	}

	public static XLong[][][][] ToArray(long[][][][] src)
	{
		return null;
	}

	public static XLong[][][][][] ToArray(long[][][][][] src)
	{
		return null;
	}
}
