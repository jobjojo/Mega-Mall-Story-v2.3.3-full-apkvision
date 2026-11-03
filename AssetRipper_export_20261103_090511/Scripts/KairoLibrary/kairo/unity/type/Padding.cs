using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct Padding : ISerializable
{
	public int Left = 0;

	public int Top = 0;

	public int Right = 0;

	public int Bottom = 0;

	private bool empty_ = false;

	public static Padding Null;

	public Size Size => default;

	public bool IsEmpty => false;

	public Padding(int all)
	{
	}

	public Padding(int left, int top, int right, int bottom)
	{
	}

	internal Padding(int left, int top, int right, int bottom, bool empty)
	{
	}

	public void Set(int all)
	{
	}

	public void Set(int left, int top, int right, int bottom)
	{
	}

	public static implicit operator PaddingF(Padding p)
	{
		return default;
	}

	public static bool operator ==(Padding a, object b)
	{
		return false;
	}

	public static bool operator !=(Padding a, object b)
	{
		return false;
	}

	public static bool operator ==(Padding a, Padding b)
	{
		return false;
	}

	public static bool operator !=(Padding a, Padding b)
	{
		return false;
	}

	public static bool operator true(Padding a)
	{
		return false;
	}

	public static bool operator false(Padding a)
	{
		return false;
	}

	public static bool operator !(Padding a)
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
