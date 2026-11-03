using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct Size : ISerializable
{
	public int Width = 0;

	public int Height = 0;

	private bool empty_ = false;

	public static Size Null;

	public bool IsEmpty => false;

	public Size(int width, int height)
	{
	}

	internal Size(int width, int height, bool empty)
	{
	}

	public void Set(int width, int height)
	{
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

	public static implicit operator SizeF(Size size)
	{
		return default;
	}

	public static bool operator ==(Size a, object b)
	{
		return false;
	}

	public static bool operator !=(Size a, object b)
	{
		return false;
	}

	public static bool operator ==(Size a, Size b)
	{
		return false;
	}

	public static bool operator !=(Size a, Size b)
	{
		return false;
	}

	public static bool operator true(Size a)
	{
		return false;
	}

	public static bool operator false(Size a)
	{
		return false;
	}

	public static bool operator !(Size a)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
