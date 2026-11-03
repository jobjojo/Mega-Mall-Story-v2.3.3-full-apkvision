using kairo.unity.ui;
using kairo.unity.util;

namespace kairo.unity.surface;

public class TouchOption
{
	public delegate void OnTouchEventDelegate(TouchEvent e);

	public const int FLAG_THROUGH = 1;

	public const int FLAG_MIN_PRIORITY = 2;

	public const int FLAG_MAX_PRIORITY = 4;

	public const int FLAG_TOP_PRIORITY = 8;

	public const int FLAG_MARKER = 16;

	public const int FLAG_CANCEL_SCREEN_LIMIT = 32;

	public const int FLAG_CANCEL_COMPONENT = 64;

	public const int FLAG_TOUCH_RECT = 128;

	public const int FLAG_TOUCH_F_RECT = 256;

	public const int FLAG_SCROLL_BAR_ADD_MARGIN = 512;

	public const int FLAG_SAME_ID = 1024;

	public const int FLAG_TOUCH_LIGHT = 2048;

	public const int FLAG_RIGHT_CLICK = 4096;

	public const int FLAG_CANCEL_TOUCH = 8192;

	public int flag;

	public int denyFlag;

	public float dragGridW;

	public float dragGridH;

	internal float dragTop;

	internal float dragBottom;

	internal float dragLeft;

	internal float dragRight;

	public int[] dragCell;

	public int[] args;

	public int[] margin;

	public int collisionBits;

	public int[] extendValues;

	public int[] keys;

	public int[] button;

	private int[] keysBuf_;

	internal bool Lock;

	internal int hasCount;

	public static FastVector<TouchOption> buffer;

	public OnTouchEventDelegate onTouchEvent;

	public TouchOption()
	{
	}

	public TouchOption(TouchOption copy)
	{
	}

	public void Init()
	{
	}

	public static TouchOption Create()
	{
		return null;
	}

	public static TouchOption Create(int[] args)
	{
		return null;
	}

	public static TouchOption Create(int[] args, int flag)
	{
		return null;
	}

	public static TouchOption Create(int flag)
	{
		return null;
	}

	public static TouchOption Drag(int gridX, int gridY)
	{
		return null;
	}

	public static TouchOption Drag(float gridX, float gridY)
	{
		return null;
	}

	public static TouchOption Drag(int gridX, int gridY, int flag)
	{
		return null;
	}

	public static TouchOption Drag(float gridX, float gridY, int flag)
	{
		return null;
	}

	public static TouchOption Drag(int x, int y, int w, int h, int xcells, int ycells)
	{
		return null;
	}

	public static TouchOption Drag(int x, int y, int w, int h, int xcells, int ycells, int flag)
	{
		return null;
	}

	public TouchOption Arg(params int[] args)
	{
		return null;
	}

	public TouchOption Flag(int flag)
	{
		return null;
	}

	public TouchOption DenyFlag(int flag)
	{
		return null;
	}

	public TouchOption Margin(int left, int right, int top, int bottom)
	{
		return null;
	}

	public TouchOption Collision(int bits)
	{
		return null;
	}

	public TouchOption ExtendValues(int[] values)
	{
		return null;
	}

	public TouchOption ExtendValues(int value)
	{
		return null;
	}

	public TouchOption Keys(params int[] keys)
	{
		return null;
	}

	public TouchOption Keys(int key)
	{
		return null;
	}

	public TouchOption OnTouchEvent(OnTouchEventDelegate method)
	{
		return null;
	}

	public TouchOption Button(Joystick.Buttons btn, int x = 0, int y = 0, int anchor = 0, int scale = 67)
	{
		return null;
	}

	public void Dispose()
	{
	}

	public bool Check(int bit)
	{
		return false;
	}
}
