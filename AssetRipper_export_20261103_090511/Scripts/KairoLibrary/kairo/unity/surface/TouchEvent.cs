namespace kairo.unity.surface;

public class TouchEvent
{
	public const int TYPE_DOWN = 0;

	public const int TYPE_UP = 1;

	public const int TYPE_ENTER = 2;

	public const int TYPE_LEAVE = 3;

	public const int TYPE_MOVE = 4;

	public const int TYPE_CLICK = 5;

	public const int TYPE_LOST = 6;

	public const int TYPE_DRAG = 7;

	public const int TYPE_GRID_DRAG = 8;

	public const int TYPE_CELL_DRAG = 9;

	public const int TYPE_CANCEL = 10;

	public const int TYPE_PINCH_START = 11;

	public const int TYPE_PINCH = 12;

	public const int TYPE_ON = 13;

	public int type;

	public int x;

	public int y;

	public int dx;

	public int dy;

	public float speedX;

	public float speedY;

	public int pinch;

	public int[][] pinchPointBegin_;

	public int[][] pinchPointNow_;

	public TouchComponent component;

	public TouchEvent()
	{
	}

	public TouchEvent(int type, TouchComponent component)
	{
	}

	public void Init()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static bool IsPositive(int type)
	{
		return false;
	}

	public bool IsPositive()
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
