using UnityEngine;

namespace kairo.unity.graphics;

public class Rectangle
{
	public int bottom;

	public int left;

	public int right;

	public int top;

	public Rectangle()
	{
	}

	public Rectangle(int left, int top, int right, int bottom)
	{
	}

	public Rectangle(Rectangle rc)
	{
	}

	public void Set(int left, int top, int right, int bottom)
	{
	}

	public void Set(Rectangle rc)
	{
	}

	public int Width()
	{
		return 0;
	}

	public int Height()
	{
		return 0;
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
