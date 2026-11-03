using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct SizeF : ISerializable
{
	public float Width = 0f;

	public float Height = 0f;

	private bool empty_ = false;

	public bool IsEmpty => false;

	public SizeF(float width, float height)
	{
	}

	internal SizeF(float width, float height, bool empty)
	{
	}

	public void Set(float width, float height)
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

	public static bool operator ==(SizeF a, object b)
	{
		return false;
	}

	public static bool operator !=(SizeF a, object b)
	{
		return false;
	}

	public static bool operator true(SizeF a)
	{
		return false;
	}

	public static bool operator false(SizeF a)
	{
		return false;
	}

	public static bool operator !(SizeF a)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
