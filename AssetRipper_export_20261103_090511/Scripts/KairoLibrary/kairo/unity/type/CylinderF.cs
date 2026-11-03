using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct CylinderF : ISerializable
{
	public CircleF Circle = default;

	public float Height = 0f;

	private bool empty_ = false;

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

	public float Radius
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

	public CylinderF(float x, float y, float h, float radius, float height)
	{
	}

	internal CylinderF(float x, float y, float h, float radius, float height, bool empty)
	{
	}

	public CylinderF(CircleF circle, float height)
	{
	}

	public void Set(float x, float y, float h, float radius, float height)
	{
	}

	public void Set(CircleF circle, float height)
	{
	}

	public static explicit operator Cylinder(CylinderF cylinder)
	{
		return default;
	}

	public static bool operator ==(CylinderF a, object b)
	{
		return false;
	}

	public static bool operator !=(CylinderF a, object b)
	{
		return false;
	}

	public static bool operator ==(CylinderF a, CylinderF b)
	{
		return false;
	}

	public static bool operator !=(CylinderF a, CylinderF b)
	{
		return false;
	}

	public static bool operator true(CylinderF a)
	{
		return false;
	}

	public static bool operator false(CylinderF a)
	{
		return false;
	}

	public static bool operator !(CylinderF a)
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
