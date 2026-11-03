using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct CircleF : ISerializable
{
	public PointF Position = default;

	public float Radius = 0f;

	private bool empty_ = false;

	public static CircleF Null;

	public float X
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Y
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float H
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool IsEmpty => false;

	public CircleF(float x, float y, float h, float radius)
	{
	}

	internal CircleF(float x, float y, float h, float radius, bool empty)
	{
	}

	public CircleF(PointF position, float radius)
	{
	}

	public void Set(float x, float y, float h, float radius)
	{
	}

	public void Set(PointF position, float radius)
	{
	}

	public static explicit operator Circle(CircleF circle)
	{
		return default;
	}

	public static bool operator ==(CircleF a, object b)
	{
		return false;
	}

	public static bool operator !=(CircleF a, object b)
	{
		return false;
	}

	public static bool operator ==(CircleF a, CircleF b)
	{
		return false;
	}

	public static bool operator !=(CircleF a, CircleF b)
	{
		return false;
	}

	public static bool operator true(CircleF a)
	{
		return false;
	}

	public static bool operator false(CircleF a)
	{
		return false;
	}

	public static bool operator !(CircleF a)
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
