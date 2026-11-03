using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct Circle : ISerializable
{
	public Point Position = default;

	public int Radius = 0;

	private bool empty_ = false;

	public static Circle Null;

	public int X
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Y
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int H
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsEmpty => false;

	public Circle(int x, int y, int h, int radius)
	{
	}

	internal Circle(int x, int y, int h, int radius, bool empty)
	{
	}

	public Circle(Point position, int radius)
	{
	}

	public void Set(int x, int y, int h, int radius)
	{
	}

	public void Set(Point position, int radius)
	{
	}

	public static implicit operator CircleF(Circle circle)
	{
		return default;
	}

	public static bool operator ==(Circle a, object b)
	{
		return false;
	}

	public static bool operator !=(Circle a, object b)
	{
		return false;
	}

	public static bool operator ==(Circle a, Circle b)
	{
		return false;
	}

	public static bool operator !=(Circle a, Circle b)
	{
		return false;
	}

	public static bool operator true(Circle a)
	{
		return false;
	}

	public static bool operator false(Circle a)
	{
		return false;
	}

	public static bool operator !(Circle a)
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
}
