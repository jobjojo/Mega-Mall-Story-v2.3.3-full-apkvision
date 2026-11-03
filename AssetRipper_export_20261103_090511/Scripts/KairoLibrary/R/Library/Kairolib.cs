using kairo.unity.ui;

namespace R.Library;

public static class Kairolib
{
	private const int IMG_TOUCH_EFFECT = 25;

	public const int BUTTON_LANGUAGE = 0;

	public const int CONNECTING_BG = 1;

	public const int CONNECTING_ANIM = 2;

	public const int BALLOON = 3;

	public const int BUTTON_CANCEL = 4;

	public const int RANKING = 5;

	public const int LINKED = 6;

	public const int UNLINKED = 7;

	public const int SAFEAREA_BG = 8;

	public const int IPHONEX = 9;

	public const int SCREEN_CURSOR = 10;

	public const int BUTTON_MIGRATION = 11;

	public const int DATA_TRANSFER = 12;

	public const int BUTTONS_SWITCH = 13;

	public const int WINDOW = 14;

	public const int PRIVACY_POLICY = 15;

	public const int CURRENCY_POLICY = 16;

	public const int AUTO_SAVE = 17;

	public const int KAIROKUN = 18;

	public const int BUTTONS_PS4 = 19;

	public const int EMOJI = 20;

	public const int NEW = 21;

	public const int STEAM_BG = 22;

	public const int BUTTON_GAMEPAD = 23;

	public const int SPLASH = 24;

	public const int BUTTON_KEYBOARD = 25;

	public const int BUTTON_REVIEW = 26;

	public const int RIGHT_CLICK = 27;

	public const int BUTTON_STORAGE_DELETE = 28;

	public const int BUTTONS_XBOX = 29;

	public const int REVIEW = 30;

	public const int SCREEN_CURSOR_WINDOW = 0;

	public const int SCREEN_CURSOR_FINGER = 1;

	public const int SCREEN_CURSOR_KAIROKUN = 2;

	public const int SCREEN_CURSOR_KAIROKUN_PS4 = 3;

	internal static bool AutoCancelJoystick;

	private static long lastConnectingTime_;

	private static int connectingFrame_;

	private static int autosaveFrame_;

	private static int autosaveX_;

	private static int autosaveY_;

	public static Seb ButtonLanguage => null;

	public static Seb ConnectingBg => null;

	public static Seb ConnectingAnim => null;

	public static Seb Balloon => null;

	public static Seb ButtonCancel => null;

	public static Seb Ranking => null;

	public static Seb Linked => null;

	public static Seb Unlinked => null;

	public static Seb SafeareaBg => null;

	public static Seb IPhoneX => null;

	public static Seb ScreenCursor => null;

	public static Seb ButtonMigration => null;

	public static Seb DataTransfer => null;

	private static Seb ButtonsSwitch => null;

	private static Seb ButtonsPs4 => null;

	private static Seb ButtonsXbox => null;

	public static Seb Window => null;

	public static Seb PrivacyPolicy => null;

	public static Seb CurrencyPolicy => null;

	public static Seb AutoSave => null;

	public static Seb Kairokun => null;

	public static Seb Emoji => null;

	public static Seb NewText => null;

	public static Seb SteamBg => null;

	public static Seb ButtonGamePad => null;

	public static Seb Splash => null;

	public static Seb ButtonKeyboard => null;

	public static Seb ButtonReview => null;

	public static Seb RightClick => null;

	public static Seb ButtonStorageDelete => null;

	public static Seb Review => null;

	public static Seb[] seb => null;

	public static Image[] img => null;

	public static SoundBase[] sound => null;

	public static ResourceManager resource { get; set; }

	public static void DrawConnectingAnim(Graphics g, bool bg = false)
	{
	}

	public static void DrawConnectingAnim(Graphics g, int x, int y, bool bg = false)
	{
	}

	public static void DrawPrivacyPolicy(Graphics g, int x, int y, Anchor anchor = (Anchor)0)
	{
	}

	public static void DrawPrivacyPolicy(Graphics g, int x, int y, int touchId, Anchor anchor)
	{
	}

	public static void DrawCurrencyPolicy(Graphics g, int x, int y, int style, Anchor anchor = (Anchor)0)
	{
	}

	public static void DrawCurrencyPolicy(Graphics g, int x, int y, int style, int touchId, Anchor anchor)
	{
	}

	public static void SetAutoSavePosition(int x, int y)
	{
	}

	public static void DrawAutoSaveAnim(Graphics g, bool bg = false, bool scaling = true)
	{
	}

	public static void DrawButtons(Graphics g, int x, int y, int buttonFrame, int layer = -1, bool autoKeyReverse = true)
	{
	}

	internal static void DrawButtons(Graphics g, int x, int y, int buttonFrame, int layer, bool autoKeyReverse, bool force)
	{
	}

	private static void _drawButtons(Graphics g, int x, int y, int buttonFrame, int layer, bool autoKeyReverse, bool force)
	{
	}

	public static void DrawNewText(Graphics g, float x, float y, int frame = 0, float scale = 1f)
	{
	}

	public static void DrawTouchEffect(Graphics g, float x, float y, int frame, int maxFrame)
	{
	}
}
