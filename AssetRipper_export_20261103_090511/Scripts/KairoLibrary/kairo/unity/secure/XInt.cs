using System;
using System.Runtime.InteropServices;

namespace kairo.unity.secure;

[Serializable]
[ComVisible(true)]
public struct XInt : IComparable, IComparable<int>, IEquatable<int>
{
	private int bitmask_ = 0;

	private int original_ = 0;

	private int value_ = 0;

	private object lock_ = null;

	internal int Value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static implicit operator int(XInt s)
	{
		return 0;
	}

	public static implicit operator XInt(int s)
	{
		return default;
	}

	public static implicit operator XInt(XShort s)
	{
		return default;
	}

	public static XInt operator ++(XInt z)
	{
		return default;
	}

	public static XInt operator --(XInt z)
	{
		return default;
	}

	public XInt(int value)
	{
	}

	public XInt(XInt src)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(int obj)
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

	public int CompareTo(int value)
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

	public static int[] ToArray(XInt[] src)
	{
		return null;
	}

	public static int[][] ToArray(XInt[][] src)
	{
		return null;
	}

	public static int[][][] ToArray(XInt[][][] src)
	{
		return null;
	}

	public static int[][][][] ToArray(XInt[][][][] src)
	{
		return null;
	}

	public static int[][][][][] ToArray(XInt[][][][][] src)
	{
		return null;
	}

	public static XInt[] ToArray(int[] src)
	{
		return null;
	}

	public static XInt[][] ToArray(int[][] src)
	{
		return null;
	}

	public static XInt[][][] ToArray(int[][][] src)
	{
		return null;
	}

	public static XInt[][][][] ToArray(int[][][][] src)
	{
		return null;
	}

	public static XInt[][][][][] ToArray(int[][][][][] src)
	{
		return null;
	}
}
