using System.Collections.Generic;
using kairo.unity.form;

namespace kairo.unity.ui;

public class Joystick
{
	public enum Buttons
	{
		None = -1,
		A = 0,
		B = 1,
		X = 2,
		Y = 3,
		L = 6,
		R = 7,
		ZL = 8,
		ZR = 9
	}

	private class OnceButton
	{
		public Buttons button_;

		public string key_;

		public bool visible_;

		public FormBase form_;

		public int lastDrawFrame_;

		public string Pack()
		{
			return null;
		}

		public void Unpack(string src)
		{
		}
	}

	private static Dictionary<Buttons, Keys> keyCode_;

	private static List<OnceButton> onceButtons_;

	private const string ONCEBUTTON_PREF_KEY = "@ONCE_BUTTONS2";

	public static bool AutoDisplayAssign { get; set; }

	public static void ShowButton(Graphics g, Buttons button, float x, float y, int scaleRatio = 100)
	{
	}

	public static void ShowFadeButton(Graphics g, Buttons button, float x, float y, int registerID = -1, int scaleRatio = 100)
	{
	}

	public static void ShowOnceButtonZLZR(Graphics g, float x, float y, float width, string key, int scaleRatio = 100)
	{
	}

	public static void ShowOnceButton(Graphics g, Buttons button, float x, float y, string key, int scaleRatio = 100)
	{
	}

	internal static void UpdateOnceButtons()
	{
	}

	public static void ResetOnceButtons()
	{
	}

	private static List<OnceButton> GetOnceButtons()
	{
		return null;
	}

	private static void SaveOnceButtons()
	{
	}

	public static bool CheckKeyPulse(Buttons button)
	{
		return false;
	}

	public static bool CheckKeyState(Buttons button)
	{
		return false;
	}

	public static bool CheckKeyRepeat(Buttons button)
	{
		return false;
	}

	public static bool IsShown()
	{
		return false;
	}
}
