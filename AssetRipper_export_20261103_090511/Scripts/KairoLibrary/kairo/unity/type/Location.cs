using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct Location : ISerializable
{
	public int Xi = 0;

	public int Yi = 0;

	public int Hi = 0;

	private bool empty_ = false;

	public static Location Null;

	public bool IsEmpty => false;

	public Location(int xi, int yi, int hi = 0)
	{
	}

	internal Location(int xi, int yi, int hi, bool empty)
	{
	}

	public void Set(int xi, int yi, int hi = 0)
	{
	}

	public static Location operator +(Location z, Location w)
	{
		return default;
	}

	public static Location operator -(Location z, Location w)
	{
		return default;
	}

	public static Location operator *(Location z, Location w)
	{
		return default;
	}

	public static Location operator /(Location z, Location w)
	{
		return default;
	}

	public static Location operator +(Location z, int w)
	{
		return default;
	}

	public static Location operator -(Location z, int w)
	{
		return default;
	}

	public static Location operator *(Location z, int w)
	{
		return default;
	}

	public static Location operator /(Location z, int w)
	{
		return default;
	}

	public static Location operator ++(Location z)
	{
		return default;
	}

	public static Location operator --(Location z)
	{
		return default;
	}

	public static Location operator +(Location z)
	{
		return default;
	}

	public static Location operator -(Location z)
	{
		return default;
	}

	public static implicit operator Point(Location location)
	{
		return default;
	}

	public static bool operator ==(Location a, object b)
	{
		return false;
	}

	public static bool operator !=(Location a, object b)
	{
		return false;
	}

	public static bool operator ==(Location a, Location b)
	{
		return false;
	}

	public static bool operator !=(Location a, Location b)
	{
		return false;
	}

	public static bool operator true(Location a)
	{
		return false;
	}

	public static bool operator false(Location a)
	{
		return false;
	}

	public static bool operator !(Location a)
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
}
