using java.io;
using kairo.unity.m3d4.util3d;
using kairo.unity.util;

namespace kairo.unity.type;

public struct PointF : ISerializable
{
	public float X = 0f;

	public float Y = 0f;

	public float H = 0f;

	private bool empty_ = false;

	public static PointF Null;

	public float Length
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Length2 => 0f;

	public bool IsEmpty => false;

	public PointF Normalize()
	{
		return default;
	}

	public PointF(float x, float y, float h = 0f)
	{
	}

	internal PointF(float x, float y, float h, bool empty)
	{
	}

	public PointF(Vector3D vec)
	{
	}

	public void Set(float x, float y, float h = 0f)
	{
	}

	public static PointF operator +(PointF z, PointF w)
	{
		return default;
	}

	public static PointF operator -(PointF z, PointF w)
	{
		return default;
	}

	public static PointF operator *(PointF z, PointF w)
	{
		return default;
	}

	public static PointF operator /(PointF z, PointF w)
	{
		return default;
	}

	public static PointF operator +(PointF z, float w)
	{
		return default;
	}

	public static PointF operator -(PointF z, float w)
	{
		return default;
	}

	public static PointF operator *(PointF z, float w)
	{
		return default;
	}

	public static PointF operator /(PointF z, float w)
	{
		return default;
	}

	public static PointF operator ++(PointF z)
	{
		return default;
	}

	public static PointF operator --(PointF z)
	{
		return default;
	}

	public static PointF operator +(PointF z)
	{
		return default;
	}

	public static PointF operator -(PointF z)
	{
		return default;
	}

	public static explicit operator Point(PointF point)
	{
		return default;
	}

	public static bool operator ==(PointF a, object b)
	{
		return false;
	}

	public static bool operator !=(PointF a, object b)
	{
		return false;
	}

	public static bool operator ==(PointF a, PointF b)
	{
		return false;
	}

	public static bool operator !=(PointF a, PointF b)
	{
		return false;
	}

	public static bool operator true(PointF a)
	{
		return false;
	}

	public static bool operator false(PointF a)
	{
		return false;
	}

	public static bool operator !(PointF a)
	{
		return false;
	}

	public float Cross(PointF v)
	{
		return 0f;
	}

	public float Dot(PointF v)
	{
		return 0f;
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
}
