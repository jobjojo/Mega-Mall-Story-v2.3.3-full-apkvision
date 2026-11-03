using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct Point : ISerializable
{
	public int X = 0;

	public int Y = 0;

	public int H = 0;

	private bool empty_ = false;

	public static Point Null;

	public bool IsEmpty => false;

	public float Length => 0f;

	public float Length2 => 0f;

	public Point(int x, int y, int h = 0)
	{
	}

	internal Point(int x, int y, int h, bool empty)
	{
	}

	public void Set(int x, int y, int h = 0)
	{
	}

	public static Point operator +(Point z, Point w)
	{
		return default;
	}

	public static Point operator -(Point z, Point w)
	{
		return default;
	}

	public static Point operator *(Point z, Point w)
	{
		return default;
	}

	public static Point operator /(Point z, Point w)
	{
		return default;
	}

	public static Point operator +(Point z, int w)
	{
		return default;
	}

	public static Point operator -(Point z, int w)
	{
		return default;
	}

	public static Point operator *(Point z, int w)
	{
		return default;
	}

	public static Point operator /(Point z, int w)
	{
		return default;
	}

	public static Point operator ++(Point z)
	{
		return default;
	}

	public static Point operator --(Point z)
	{
		return default;
	}

	public static Point operator +(Point z)
	{
		return default;
	}

	public static Point operator -(Point z)
	{
		return default;
	}

	public static implicit operator PointF(Point point)
	{
		return default;
	}

	public static implicit operator Location(Point point)
	{
		return default;
	}

	public static bool operator ==(Point a, object b)
	{
		return false;
	}

	public static bool operator !=(Point a, object b)
	{
		return false;
	}

	public static bool operator ==(Point a, Point b)
	{
		return false;
	}

	public static bool operator !=(Point a, Point b)
	{
		return false;
	}

	public static bool operator true(Point a)
	{
		return false;
	}

	public static bool operator false(Point a)
	{
		return false;
	}

	public static bool operator !(Point a)
	{
		return false;
	}

	public int Cross(Point v)
	{
		return 0;
	}

	public int Dot(Point v)
	{
		return 0;
	}

	public PointF Normalize()
	{
		return default;
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
