using UnityEngine;

namespace kairo.unity.ui;

public class KeyEvent
{
	public const KeyCode KEYCODE_HOME = KeyCode.Home;

	public const KeyCode KEYCODE_BACK = KeyCode.Escape;

	public const KeyCode KEYCODE_FOCUS = KeyCode.LeftWindows;

	public const int ACTION_DOWN = 0;

	public const int ACTION_UP = 1;

	private int action_;

	private KeyCode keyCode_;

	public KeyEvent(int action, KeyCode keyCode)
	{
	}

	public int GetAction()
	{
		return 0;
	}

	public KeyCode GetKeyCode()
	{
		return KeyCode.None;
	}

	public int GetRepeatCount()
	{
		return 0;
	}
}
