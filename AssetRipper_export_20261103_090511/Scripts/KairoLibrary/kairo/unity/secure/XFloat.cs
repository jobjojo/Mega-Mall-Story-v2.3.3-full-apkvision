using System;
using System.Runtime.InteropServices;

namespace kairo.unity.secure;

[Serializable]
[ComVisible(true)]
public struct XFloat : IComparable, IComparable<float>, IEquatable<float>
{
	private int bitmask_ = 0;

	private FloatUnion original_ = default;

	private FloatUnion value_ = default;

	private object lock_ = null;

	internal float Value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static implicit operator float(XFloat s)
	{
		return 0f;
	}

	public static explicit operator XShort(XFloat s)
	{
		return default;
	}

	public static explicit operator XInt(XFloat s)
	{
		return default;
	}

	public static explicit operator XLong(XFloat s)
	{
		return default;
	}

	public static implicit operator XFloat(float s)
	{
		return default;
	}

	public static implicit operator XFloat(int s)
	{
		return default;
	}

	public static implicit operator XFloat(XShort s)
	{
		return default;
	}

	public static implicit operator XFloat(XInt s)
	{
		return default;
	}

	public static XFloat operator ++(XFloat z)
	{
		return default;
	}

	public static XFloat operator --(XFloat z)
	{
		return default;
	}

	public XFloat(float value)
	{
	}

	public XFloat(XFloat src)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(float obj)
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

	public int CompareTo(float value)
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

	public static float[] ToArray(XFloat[] src)
	{
		return null;
	}

	public static float[][] ToArray(XFloat[][] src)
	{
		return null;
	}

	public static float[][][] ToArray(XFloat[][][] src)
	{
		return null;
	}

	public static float[][][][] ToArray(XFloat[][][][] src)
	{
		return null;
	}

	public static float[][][][][] ToArray(XFloat[][][][][] src)
	{
		return null;
	}

	public static XFloat[] ToArray(float[] src)
	{
		return null;
	}

	public static XFloat[][] ToArray(float[][] src)
	{
		return null;
	}

	public static XFloat[][][] ToArray(float[][][] src)
	{
		return null;
	}

	public static XFloat[][][][] ToArray(float[][][][] src)
	{
		return null;
	}

	public static XFloat[][][][][] ToArray(float[][][][][] src)
	{
		return null;
	}
}
