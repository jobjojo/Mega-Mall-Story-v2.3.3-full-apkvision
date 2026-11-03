using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct PaddingF : ISerializable
{
	public float Left = 0f;

	public float Top = 0f;

	public float Right = 0f;

	public float Bottom = 0f;

	private bool empty_ = false;

	public static PaddingF Null;

	public SizeF Size => default;

	public bool IsEmpty => false;

	public PaddingF(float all)
	{
	}

	public PaddingF(float left, float top, float right, float bottom)
	{
	}

	internal PaddingF(float left, float top, float right, float bottom, bool empty)
	{
	}

	public void Set(float all)
	{
	}

	public void Set(float left, float top, float right, float bottom)
	{
	}

	public static explicit operator Padding(PaddingF p)
	{
		return default;
	}

	public static bool operator ==(PaddingF a, object b)
	{
		return false;
	}

	public static bool operator !=(PaddingF a, object b)
	{
		return false;
	}

	public static bool operator ==(PaddingF a, PaddingF b)
	{
		return false;
	}

	public static bool operator !=(PaddingF a, PaddingF b)
	{
		return false;
	}

	public static bool operator true(PaddingF a)
	{
		return false;
	}

	public static bool operator false(PaddingF a)
	{
		return false;
	}

	public static bool operator !(PaddingF a)
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
