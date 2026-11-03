using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct Rect : ISerializable
{
	public int X = 0;

	public int Y = 0;

	public int Width = 0;

	public int Height = 0;

	private bool empty_ = false;

	public static Rect Null;

	public int Left
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Top
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Right
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Bottom
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Point Center => default;

	public bool IsEmpty => false;

	public Rect(int x, int y, int width, int height)
	{
	}

	internal Rect(int x, int y, int width, int height, bool empty)
	{
	}

	public void Set(int x, int y, int width, int height)
	{
	}

	public static Rect operator *(Rect z, int w)
	{
		return default;
	}

	public static Rect operator /(Rect z, int w)
	{
		return default;
	}

	public static RectF operator *(Rect z, float w)
	{
		return default;
	}

	public static RectF operator /(Rect z, float w)
	{
		return default;
	}

	public static implicit operator RectF(Rect rect)
	{
		return default;
	}

	public static bool operator ==(Rect a, object b)
	{
		return false;
	}

	public static bool operator !=(Rect a, object b)
	{
		return false;
	}

	public static bool operator ==(Rect a, Rect b)
	{
		return false;
	}

	public static bool operator !=(Rect a, Rect b)
	{
		return false;
	}

	public static bool operator true(Rect a)
	{
		return false;
	}

	public static bool operator false(Rect a)
	{
		return false;
	}

	public static bool operator !(Rect a)
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

	public bool Contains(int x, int y)
	{
		return false;
	}
}
