using UnityEngine;

namespace kairo.unity.graphics;

public class RectangleF
{
	public float bottom;

	public float left;

	public float right;

	public float top;

	public RectangleF()
	{
	}

	public RectangleF(float left, float top, float right, float bottom)
	{
	}

	public RectangleF(RectangleF rc)
	{
	}

	public RectangleF(Rectangle rc)
	{
	}

	public void Set(float left, float top, float right, float bottom)
	{
	}

	public void Set(RectangleF rc)
	{
	}

	public void Set(Rectangle rc)
	{
	}

	public float Width()
	{
		return 0f;
	}

	public float Height()
	{
		return 0f;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public Rect ToRect()
	{
		return default;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
