using UnityEngine;

namespace kairo.unity.ui;

public class KInput
{
	private const int STATE_NONE = 0;

	private const int STATE_DOWN = 1;

	private const int STATE_PRESS = 2;

	private const int STATE_UP = -1;

	private static int[] KEY_TABLE;

	private static int[] keyState_;

	internal static float wheel_;

	internal static float wheelWinProc_;

	internal static long wheelWinProcParam_;

	internal static bool mouseWheelMove_;

	internal static int mouseWheelMoveWait_;

	internal static bool anyKey { get; set; }

	internal static bool anyJoystick { get; set; }

	internal static bool anyKeyboard { get; set; }

	internal static void Update()
	{
	}

	internal static bool GetKey(KeyCode key)
	{
		return false;
	}

	internal static bool GetKeyDown(KeyCode key)
	{
		return false;
	}

	internal static bool GetKeyUp(KeyCode key)
	{
		return false;
	}

	internal static float GetMouseWheel()
	{
		return 0f;
	}

	public static bool IsMouseWheelMove()
	{
		return false;
	}
}
