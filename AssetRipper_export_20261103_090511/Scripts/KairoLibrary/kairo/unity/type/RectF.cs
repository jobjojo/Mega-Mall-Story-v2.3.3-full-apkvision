using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct RectF : ISerializable
{
	public float X = 0f;

	public float Y = 0f;

	public float Width = 0f;

	public float Height = 0f;

	private bool empty_ = false;

	public static RectF Null;

	public float Left
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Top
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Right
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Bottom
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public PointF Center => default;

	public bool IsEmpty => false;

	public RectF(float x, float y, float width, float height)
	{
	}

	internal RectF(float x, float y, float width, float height, bool empty)
	{
	}

	public void Set(float x, float y, float width, float height)
	{
	}

	public static RectF operator *(RectF z, int w)
	{
		return default;
	}

	public static RectF operator /(RectF z, int w)
	{
		return default;
	}

	public static RectF operator *(RectF z, float w)
	{
		return default;
	}

	public static RectF operator /(RectF z, float w)
	{
		return default;
	}

	public static explicit operator Rect(RectF rect)
	{
		return default;
	}

	public static bool operator ==(RectF a, object b)
	{
		return false;
	}

	public static bool operator !=(RectF a, object b)
	{
		return false;
	}

	public static bool operator ==(RectF a, RectF b)
	{
		return false;
	}

	public static bool operator !=(RectF a, RectF b)
	{
		return false;
	}

	public static bool operator true(RectF a)
	{
		return false;
	}

	public static bool operator false(RectF a)
	{
		return false;
	}

	public static bool operator !(RectF a)
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

	public bool Contains(float x, float y)
	{
		return false;
	}
}
