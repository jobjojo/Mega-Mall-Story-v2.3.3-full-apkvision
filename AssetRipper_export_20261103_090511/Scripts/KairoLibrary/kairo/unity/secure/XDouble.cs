using System;
using System.Runtime.InteropServices;

namespace kairo.unity.secure;

[Serializable]
[ComVisible(true)]
public struct XDouble : IComparable, IComparable<double>, IEquatable<double>
{
	private long bitmask_ = 0L;

	private DoubleUnion original_ = default;

	private DoubleUnion value_ = default;

	private object lock_ = null;

	internal double Value
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public static implicit operator double(XDouble s)
	{
		return 0.0;
	}

	public static explicit operator XShort(XDouble s)
	{
		return default;
	}

	public static explicit operator XInt(XDouble s)
	{
		return default;
	}

	public static explicit operator XLong(XDouble s)
	{
		return default;
	}

	public static implicit operator XDouble(float s)
	{
		return default;
	}

	public static implicit operator XDouble(double s)
	{
		return default;
	}

	public static implicit operator XDouble(int s)
	{
		return default;
	}

	public static implicit operator XDouble(XFloat s)
	{
		return default;
	}

	public static implicit operator XDouble(XShort s)
	{
		return default;
	}

	public static implicit operator XDouble(XInt s)
	{
		return default;
	}

	public static XDouble operator ++(XDouble z)
	{
		return default;
	}

	public static XDouble operator --(XDouble z)
	{
		return default;
	}

	public XDouble(double value)
	{
	}

	public XDouble(XDouble src)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(double obj)
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

	public int CompareTo(double value)
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

	public static double[] ToArray(XDouble[] src)
	{
		return null;
	}

	public static double[][] ToArray(XDouble[][] src)
	{
		return null;
	}

	public static double[][][] ToArray(XDouble[][][] src)
	{
		return null;
	}

	public static double[][][][] ToArray(XDouble[][][][] src)
	{
		return null;
	}

	public static double[][][][][] ToArray(XDouble[][][][][] src)
	{
		return null;
	}

	public static XDouble[] ToArray(double[] src)
	{
		return null;
	}

	public static XDouble[][] ToArray(double[][] src)
	{
		return null;
	}

	public static XDouble[][][] ToArray(double[][][] src)
	{
		return null;
	}

	public static XDouble[][][][] ToArray(double[][][][] src)
	{
		return null;
	}

	public static XDouble[][][][][] ToArray(double[][][][][] src)
	{
		return null;
	}
}
