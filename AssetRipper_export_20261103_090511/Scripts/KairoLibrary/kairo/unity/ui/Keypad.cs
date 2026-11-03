using kairo.unity.component;
using kairo.unity.form;

namespace kairo.unity.ui;

public class Keypad
{
	internal FormBase form_;

	internal UIComponent component_;

	internal const int KEYBUFFER_SIZE = 60;

	internal int keyBufIndex_;

	internal int[] keyBuffer_;

	internal int keyStateWork_;

	internal int keyState_;

	internal int keyPulse_;

	internal int keyPulseInvalid_;

	internal int keyEventState_;

	internal bool keyBack_;

	internal bool keyBackWork_;

	internal bool physicalInputWork_;

	internal bool physicalInput_;

	internal static bool InvalidKeyRepeat { get; set; }

	internal Keypad()
	{
	}

	internal Keypad(FormBase form)
	{
	}

	internal Keypad(UIComponent component)
	{
	}

	public void DecideKeyState()
	{
	}

	public int GetKeyState()
	{
		return 0;
	}

	public bool CheckKeyState(int key)
	{
		return false;
	}

	public bool CheckKeyPulse(int key)
	{
		return false;
	}

	public bool GetKeyPulse(int key)
	{
		return false;
	}

	public bool CheckKeyRepeat(int key, int interval)
	{
		return false;
	}

	public bool CheckKeyDouble(int key, int interval)
	{
		return false;
	}

	public int GetKeypadState()
	{
		return 0;
	}

	public void ClearKeyBuffer()
	{
	}

	public bool GetJoystickPress(int index)
	{
		return false;
	}

	public bool GetJoystickDown(int index)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
