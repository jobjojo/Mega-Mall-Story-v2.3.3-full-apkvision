using UnityEngine;
using java.io;
using kairo.unity.util;

namespace kairo.unity.type;

public struct Color : ISerializable
{
	private int color_ = 0;

	public int A
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int R
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int G
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int B
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static implicit operator Color(int color)
	{
		return default;
	}

	public static implicit operator Color(uint color)
	{
		return default;
	}

	public static implicit operator Color(UnityEngine.Color color)
	{
		return default;
	}

	public static implicit operator int(Color color)
	{
		return 0;
	}

	public static implicit operator UnityEngine.Color(Color color)
	{
		return default;
	}

	public Color(int argb)
	{
	}

	public Color(uint argb)
	{
	}

	public Color(int r, int g, int b)
	{
	}

	public Color(int r, int g, int b, int a)
	{
	}

	public Color(UnityEngine.Color color)
	{
	}

	public UnityEngine.Color GetColor()
	{
		return default;
	}

	public int GetArgb()
	{
		return 0;
	}

	public void Set(int r, int g, int b)
	{
	}

	public void Set(int r, int g, int b, int a)
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

	public override int GetHashCode()
	{
		return 0;
	}
}
