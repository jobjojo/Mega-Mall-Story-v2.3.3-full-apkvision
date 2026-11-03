using System;
using System.Runtime.InteropServices;

namespace kairo.unity.secure;

[Serializable]
[ComVisible(true)]
public struct XByte : IComparable, IComparable<sbyte>, IEquatable<sbyte>
{
	private int bitmask_ = 0;

	private sbyte original_ = 0;

	private sbyte value_ = 0;

	private object lock_ = null;

	internal sbyte Value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static implicit operator sbyte(XByte s)
	{
		return 0;
	}

	public static implicit operator XByte(sbyte s)
	{
		return default;
	}

	public static implicit operator byte(XByte s)
	{
		return 0;
	}

	public static implicit operator XByte(byte s)
	{
		return default;
	}

	public static implicit operator XByte(int s)
	{
		return default;
	}

	public static XByte operator ++(XByte z)
	{
		return default;
	}

	public static XByte operator --(XByte z)
	{
		return default;
	}

	public static bool operator ==(XByte a, sbyte b)
	{
		return false;
	}

	public static bool operator !=(XByte a, sbyte b)
	{
		return false;
	}

	public static bool operator ==(sbyte a, XByte b)
	{
		return false;
	}

	public static bool operator !=(sbyte a, XByte b)
	{
		return false;
	}

	public XByte(sbyte value)
	{
	}

	public XByte(XByte src)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(sbyte obj)
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

	public int CompareTo(sbyte value)
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

	public static sbyte[] ToArray(XByte[] src)
	{
		return null;
	}

	public static sbyte[][] ToArray(XByte[][] src)
	{
		return null;
	}

	public static sbyte[][][] ToArray(XByte[][][] src)
	{
		return null;
	}

	public static sbyte[][][][] ToArray(XByte[][][][] src)
	{
		return null;
	}

	public static sbyte[][][][][] ToArray(XByte[][][][][] src)
	{
		return null;
	}

	public static XByte[] ToArray(sbyte[] src)
	{
		return null;
	}

	public static XByte[][] ToArray(sbyte[][] src)
	{
		return null;
	}

	public static XByte[][][] ToArray(sbyte[][][] src)
	{
		return null;
	}

	public static XByte[][][][] ToArray(sbyte[][][][] src)
	{
		return null;
	}

	public static XByte[][][][][] ToArray(sbyte[][][][][] src)
	{
		return null;
	}
}
