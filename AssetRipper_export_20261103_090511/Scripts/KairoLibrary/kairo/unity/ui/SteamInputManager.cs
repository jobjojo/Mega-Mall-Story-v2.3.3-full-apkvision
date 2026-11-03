using System.Collections.Generic;
using kairo.unity.surface;

namespace kairo.unity.ui;

public class SteamInputManager
{
	public abstract class Button
	{
		protected bool pulse_;

		protected Image image_;

		protected string file_;

		public string Name { get; }

		public float X { get; protected set; }

		public float Y { get; protected set; }

		public bool State { get; protected set; }

		public bool Pulse
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Button(string name)
		{
		}

		internal virtual void Update()
		{
		}

		public static implicit operator bool(Button label)
		{
			return false;
		}

		public static bool operator true(Button x)
		{
			return false;
		}

		public static bool operator false(Button x)
		{
			return false;
		}

		public static bool operator !(Button x)
		{
			return false;
		}

		public virtual Image GetImage()
		{
			return null;
		}

		public void CreateVisibility(Image img)
		{
		}
	}

	public class DigialButton : Button
	{
		public DigialButton(string name)
			: base(null)
		{
		}

		private bool Check()
		{
			return false;
		}

		internal override void Update()
		{
		}

		public override Image GetImage()
		{
			return null;
		}
	}

	public class AnalogButton : Button
	{
		public AnalogButton(string name)
			: base(null)
		{
		}

		private bool Check()
		{
			return false;
		}

		internal override void Update()
		{
		}

		public override Image GetImage()
		{
			return null;
		}
	}

	public class Buttons
	{
		public static Button Up;

		public static Button Down;

		public static Button Left;

		public static Button Right;

		public static Button SoftL;

		public static Button SoftR;

		public static Button TriggerL;

		public static Button TriggerR;

		public static Button Start;

		public static Button Option;

		public static Button Select;

		public static Button Back;

		public static Button X;

		public static Button Y;

		public static Button StickL;

		public static Button StickR;
	}

	public delegate TouchComponent AddTouchDelegate(Graphics g, int id, int x, int y, int w, int h, int value, TouchOption opt);

	private static bool initialized_;

	private static long vibrationStopTime_;

	private static Image dpadImage_;

	private static int isSteamDeck_;

	internal const string PREF_STEAM_REVIEW = "@STEAM_THANKS";

	internal static int steamThanksState_;

	private static List<Button> buttons_;

	private static long downButtonTime_;

	internal static void Update()
	{
	}

	public static void ShowBindingPanel()
	{
	}

	public static void DrawButton(Graphics g, int x, int y, int id, AddTouchDelegate method)
	{
	}

	public static void DrawKeyboardButton(Graphics g, int x, int y, int id, AddTouchDelegate method)
	{
	}

	public static void DrawReviewButton(Graphics g, int x, int y, Anchor anchor, int id, AddTouchDelegate method)
	{
	}

	public static void DrawReviewButton(Graphics g, int x, int y, Anchor anchor, int id, AddTouchDelegate method, Joystick.Buttons button)
	{
	}

	public static void DrawReviewButton(Graphics g, int x, int y, float scale, Anchor anchor, int id, AddTouchDelegate method)
	{
	}

	public static void DrawReviewButton(Graphics g, int x, int y, float scale, Anchor anchor, int id, AddTouchDelegate method, Joystick.Buttons button)
	{
	}

	public static bool HasController()
	{
		return false;
	}

	public static void Vibrator(long ms)
	{
	}

	public static void StartVibration()
	{
	}

	public static void StopVibration()
	{
	}

	public static void Dipose()
	{
	}

	public static Image GetDPadImage()
	{
		return null;
	}

	public static Image GetMouseButtonImage(int button)
	{
		return null;
	}

	internal static bool IsSteamDeck()
	{
		return false;
	}
}
