using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct Cylinder : ISerializable
{
	public Circle Circle = default;

	public int Height = 0;

	private bool empty_ = false;

	public static Cylinder Null;

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

	public int Radius
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

	public Cylinder(int x, int y, int h, int radius, int height)
	{
	}

	internal Cylinder(int x, int y, int h, int radius, int height, bool empty)
	{
	}

	public Cylinder(Circle circle, int height)
	{
	}

	public void Set(int x, int y, int h, int radius, int height)
	{
	}

	public void Set(Circle circle, int height)
	{
	}

	public static implicit operator CylinderF(Cylinder cylinder)
	{
		return default;
	}

	public static bool operator ==(Cylinder a, object b)
	{
		return false;
	}

	public static bool operator !=(Cylinder a, object b)
	{
		return false;
	}

	public static bool operator ==(Cylinder a, Cylinder b)
	{
		return false;
	}

	public static bool operator !=(Cylinder a, Cylinder b)
	{
		return false;
	}

	public static bool operator true(Cylinder a)
	{
		return false;
	}

	public static bool operator false(Cylinder a)
	{
		return false;
	}

	public static bool operator !(Cylinder a)
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
