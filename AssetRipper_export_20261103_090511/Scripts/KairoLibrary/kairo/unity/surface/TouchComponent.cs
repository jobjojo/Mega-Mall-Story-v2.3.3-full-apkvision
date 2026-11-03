using kairo.unity.component;

namespace kairo.unity.surface;

public class TouchComponent
{
	public SurfaceBase surface_;

	public int id;

	public int x;

	public int y;

	public int width;

	public int height;

	public int value;

	public TouchOption option;

	public int paintX;

	public int paintY;

	public int paintFrame;

	internal bool isLock;

	internal int hasCount;

	public UIComponent component;

	public TouchComponent()
	{
	}

	public TouchComponent(TouchComponent copy)
	{
	}

	public void Init()
	{
	}

	public void SetPaint(int x, int y)
	{
	}

	public void SetPaint(int x, int y, int frame)
	{
	}

	public long GetKey()
	{
		return 0L;
	}

	public static long GetKey(int id, int value)
	{
		return 0L;
	}

	public static int GetId(long key)
	{
		return 0;
	}

	public static int GetValue(long key)
	{
		return 0;
	}

	public bool Check(int bit)
	{
		return false;
	}

	public int GetPriority()
	{
		return 0;
	}
}
