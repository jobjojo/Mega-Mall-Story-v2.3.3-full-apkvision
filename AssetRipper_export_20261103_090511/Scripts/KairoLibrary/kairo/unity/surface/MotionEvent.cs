namespace kairo.unity.surface;

public class MotionEvent
{
	public const int ACTION_DOWN = 0;

	public const int ACTION_UP = 1;

	public const int ACTION_MOVE = 2;

	public const int ACTION_CANCEL = 3;

	public const int ACTION_OUTSIDE = 4;

	public const int ACTION_POINTER_DOWN = 5;

	public const int ACTION_POINTER_UP = 6;

	public const int ACTION_POINTER_1_DOWN = 5;

	public const int ACTION_POINTER_2_DOWN = 261;

	public const int ACTION_POINTER_3_DOWN = 517;

	public const int ACTION_POINTER_4_DOWN = 773;

	public const int ACTION_POINTER_5_DOWN = 1029;

	public const int ACTION_POINTER_1_UP = 6;

	public const int ACTION_POINTER_2_UP = 262;

	public const int ACTION_POINTER_3_UP = 518;

	public const int ACTION_POINTER_4_UP = 774;

	public const int ACTION_POINTER_5_UP = 1030;

	protected int action;

	protected int[] pointerIds;

	protected float[] pointerPos;

	protected float[] pointerDelta;

	protected bool isMousePointer;

	internal bool isRightClick;

	public MotionEvent(int action, int[] pointerIds, float[] pointerPos, float[] pointerDelta, bool isMousePointer = false)
	{
	}

	public int GetAction()
	{
		return 0;
	}

	public float GetX()
	{
		return 0f;
	}

	public float GetY()
	{
		return 0f;
	}

	public float GetDeltaX()
	{
		return 0f;
	}

	public float GetDeltaY()
	{
		return 0f;
	}

	public float GetDeltaTime()
	{
		return 0f;
	}

	public float GetX(int index)
	{
		return 0f;
	}

	public float GetY(int index)
	{
		return 0f;
	}

	public float GetDeltaX(int index)
	{
		return 0f;
	}

	public float GetDeltaY(int index)
	{
		return 0f;
	}

	public float GetDeltaTime(int index)
	{
		return 0f;
	}

	public bool IsMousePointer()
	{
		return false;
	}

	public int GetPointerCount()
	{
		return 0;
	}

	public int GetPointerId(int index)
	{
		return 0;
	}
}
