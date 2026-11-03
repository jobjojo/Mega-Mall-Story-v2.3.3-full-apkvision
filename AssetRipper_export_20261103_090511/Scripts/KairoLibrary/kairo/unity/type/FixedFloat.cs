using System;
using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct FixedFloat : ISerializable, IComparable
{
	private long value_ = 0L;

	public int Integer
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Decimal
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public long Value
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static explicit operator int(FixedFloat v)
	{
		return 0;
	}

	public static implicit operator float(FixedFloat v)
	{
		return 0f;
	}

	public static implicit operator FixedFloat(int v)
	{
		return default;
	}

	public static implicit operator FixedFloat(float v)
	{
		return default;
	}

	public FixedFloat(int value)
	{
	}

	public FixedFloat(float value)
	{
	}

	public FixedFloat(int intValue, int decimalValue)
	{
	}

	public static int operator +(int z, FixedFloat w)
	{
		return 0;
	}

	public static long operator +(long z, FixedFloat w)
	{
		return 0L;
	}

	public static float operator +(float z, FixedFloat w)
	{
		return 0f;
	}

	public static FixedFloat operator +(FixedFloat z, int w)
	{
		return default;
	}

	public static FixedFloat operator +(FixedFloat z, long w)
	{
		return default;
	}

	public static FixedFloat operator +(FixedFloat z, float w)
	{
		return default;
	}

	public static FixedFloat operator +(FixedFloat z, FixedFloat w)
	{
		return default;
	}

	public static int operator -(int z, FixedFloat w)
	{
		return 0;
	}

	public static long operator -(long z, FixedFloat w)
	{
		return 0L;
	}

	public static float operator -(float z, FixedFloat w)
	{
		return 0f;
	}

	public static FixedFloat operator -(FixedFloat z, int w)
	{
		return default;
	}

	public static FixedFloat operator -(FixedFloat z, long w)
	{
		return default;
	}

	public static FixedFloat operator -(FixedFloat z, float w)
	{
		return default;
	}

	public static FixedFloat operator -(FixedFloat z, FixedFloat w)
	{
		return default;
	}

	public static int operator *(int z, FixedFloat w)
	{
		return 0;
	}

	public static long operator *(long z, FixedFloat w)
	{
		return 0L;
	}

	public static float operator *(float z, FixedFloat w)
	{
		return 0f;
	}

	public static FixedFloat operator *(FixedFloat z, int w)
	{
		return default;
	}

	public static FixedFloat operator *(FixedFloat z, long w)
	{
		return default;
	}

	public static FixedFloat operator *(FixedFloat z, float w)
	{
		return default;
	}

	public static FixedFloat operator *(FixedFloat z, FixedFloat w)
	{
		return default;
	}

	public static int operator /(int z, FixedFloat w)
	{
		return 0;
	}

	public static long operator /(long z, FixedFloat w)
	{
		return 0L;
	}

	public static float operator /(float z, FixedFloat w)
	{
		return 0f;
	}

	public static FixedFloat operator /(FixedFloat z, int w)
	{
		return default;
	}

	public static FixedFloat operator /(FixedFloat z, long w)
	{
		return default;
	}

	public static FixedFloat operator /(FixedFloat z, float w)
	{
		return default;
	}

	public static FixedFloat operator /(FixedFloat z, FixedFloat w)
	{
		return default;
	}

	public static FixedFloat operator ++(FixedFloat z)
	{
		return default;
	}

	public static FixedFloat operator --(FixedFloat z)
	{
		return default;
	}

	public static bool operator ==(FixedFloat a, int b)
	{
		return false;
	}

	public static bool operator !=(FixedFloat a, int b)
	{
		return false;
	}

	public static bool operator ==(FixedFloat a, long b)
	{
		return false;
	}

	public static bool operator !=(FixedFloat a, long b)
	{
		return false;
	}

	public static bool operator ==(FixedFloat a, float b)
	{
		return false;
	}

	public static bool operator !=(FixedFloat a, float b)
	{
		return false;
	}

	public static bool operator ==(FixedFloat a, FixedFloat b)
	{
		return false;
	}

	public static bool operator !=(FixedFloat a, FixedFloat b)
	{
		return false;
	}

	public static bool operator <(FixedFloat a, int b)
	{
		return false;
	}

	public static bool operator <(FixedFloat a, long b)
	{
		return false;
	}

	public static bool operator <(FixedFloat a, float b)
	{
		return false;
	}

	public static bool operator <(FixedFloat a, FixedFloat b)
	{
		return false;
	}

	public static bool operator >(FixedFloat a, int b)
	{
		return false;
	}

	public static bool operator >(FixedFloat a, long b)
	{
		return false;
	}

	public static bool operator >(FixedFloat a, float b)
	{
		return false;
	}

	public static bool operator >(FixedFloat a, FixedFloat b)
	{
		return false;
	}

	public static bool operator <=(FixedFloat a, int b)
	{
		return false;
	}

	public static bool operator <=(FixedFloat a, long b)
	{
		return false;
	}

	public static bool operator <=(FixedFloat a, float b)
	{
		return false;
	}

	public static bool operator <=(FixedFloat a, FixedFloat b)
	{
		return false;
	}

	public static bool operator >=(FixedFloat a, int b)
	{
		return false;
	}

	public static bool operator >=(FixedFloat a, long b)
	{
		return false;
	}

	public static bool operator >=(FixedFloat a, float b)
	{
		return false;
	}

	public static bool operator >=(FixedFloat a, FixedFloat b)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public void Serialize(OutputStream stream)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public int CompareTo(FixedFloat obj)
	{
		return 0;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public static FixedFloat Parse(string s)
	{
		return default;
	}

	public static bool TryParse(string s, out FixedFloat result)
	{
		result = default;
		return false;
	}
}
