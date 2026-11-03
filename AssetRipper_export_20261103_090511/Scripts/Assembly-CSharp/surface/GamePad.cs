using java.util;
using kairo.unity.surface;
using kairo.unity.ui;
using kairo.unity.util;

namespace surface;

public class GamePad : SurfaceBase
{
	internal static GamePad instance_;

	internal IApplication app_;

	internal Canvas canvas_;

	internal TouchEffectManager effMan_;

	internal static Image[] images_;

	internal static readonly string[] FILENAMES;

	internal static readonly int[] IMAGE_WIDTH;

	internal const int TEX_BG_SHOW = 0;

	internal const int TEX_BG_HIDE1 = 1;

	internal const int TEX_BG_HIDE2_TOP = 2;

	internal const int TEX_BG_HIDE2_BOTTOM = 3;

	internal const int TEX_BUTTON = 4;

	internal const int TEX_BUTTON_L = 5;

	internal const int TEX_BUTTON_H = 6;

	internal const int TEX_SBUTTON = 7;

	internal const int TEX_SBUTTON_L = 8;

	internal const int TEX_SBUTTON_H = 9;

	internal const int TEX_UP_L = 10;

	internal const int TEX_DOWN_L = 11;

	internal const int TEX_LEFT_L = 12;

	internal const int TEX_RIGHT_L = 13;

	internal const int TEX_SELECT_L = 14;

	internal const int TEX_KAIRO1 = 15;

	internal const int TEX_KAIRO2 = 16;

	internal const int TEX_COPYLIGHT = 17;

	internal const int TEX_COPYLIGHT_EN = 18;

	internal const int TEX_PAD_ON = 19;

	internal const int TEX_PAD_OFF = 20;

	internal const int TEX_SOFT1_FRAME = 21;

	internal const int TEX_SOFT2_FRAME = 22;

	internal const int TEX_AM = 23;

	internal const int TEX_PM = 24;

	internal const int TEX_0 = 25;

	internal const int TEX_1 = 26;

	internal const int TEX_2 = 27;

	internal const int TEX_3 = 28;

	internal const int TEX_4 = 29;

	internal const int TEX_5 = 30;

	internal const int TEX_6 = 31;

	internal const int TEX_7 = 32;

	internal const int TEX_8 = 33;

	internal const int TEX_9 = 34;

	internal const int TEX_COLON = 35;

	internal const int TEX_BATTERY0 = 36;

	internal const int TEX_BATTERY1 = 37;

	internal const int TEX_BATTERY2 = 38;

	internal const int TEX_BATTERY3 = 39;

	internal const int TEX_BATTERY4 = 40;

	internal const int TEX_BATTERY5 = 41;

	internal const int TEX_BATTERY6 = 42;

	internal const int TEX_BATTERY7 = 43;

	internal const int TEX_BATTERY8 = 44;

	internal const int TEX_BATTERY9 = 45;

	internal const int TEX_BATTERY10 = 46;

	internal const int TEX_BATTERY11 = 47;

	internal const int TEX_BATTERY12 = 48;

	internal const int TEX_BATTERY13 = 49;

	internal const int TEX_BATTERY_CHARGE = 50;

	internal const int TEX_ARROW_UP = 51;

	internal const int TEX_ARROW_DOWN = 52;

	internal const int TEX_ARROW_LEFT = 53;

	internal const int TEX_ARROW_RIGHT = 54;

	internal const int TEX_BAR_UP = 55;

	internal const int TEX_BAR_DOWN = 56;

	internal const int TEX_BAR_LEFT = 57;

	internal const int TEX_BAR_RIGHT = 58;

	internal static readonly int[][] TEXTURES;

	internal const int T_IMG = 0;

	internal const int T_X = 1;

	internal const int T_Y = 2;

	internal const int T_U = 3;

	internal const int T_V = 4;

	internal const int T_W = 5;

	internal const int T_H = 6;

	internal const int ID_SOFT1 = 0;

	internal const int ID_SOFT2 = 1;

	internal const int ID_SOFT3 = 2;

	internal const int ID_SOFT4 = 3;

	internal const int ID_SOFTM = 4;

	internal const int ID_WEB = 5;

	internal const int ID_UP = 6;

	internal const int ID_DOWN = 7;

	internal const int ID_LEFT = 8;

	internal const int ID_RIGHT = 9;

	internal const int ID_SELECT = 10;

	internal const int ID_DEBUG = 11;

	internal const int ID_SKIP = 12;

	internal const int ID_DIALOG = 13;

	internal const int ID_HITTEST = 14;

	internal const int ID_SLOW = 15;

	internal const int ID_OPTION = 16;

	internal const int ID_LAYOUT = 17;

	internal const int ID_PAUSE = 18;

	internal const int ID_CAPTCHA = 19;

	internal const int ID_HIDE = 20;

	internal const int ID_PAD_ON = 21;

	internal const int ID_PAD_OFF = 22;

	internal static readonly int[][] COMPONENTS;

	internal const int C_L = 0;

	internal const int C_R = 1;

	internal const int C_T = 2;

	internal const int C_B = 3;

	internal const int C_TEX = 4;

	internal const int C_TEX_ON = 5;

	internal const int C_TEX_HIDE = 6;

	internal Font font_;

	internal bool visibleTouchRange_;

	internal long webTouchBegin_;

	internal bool hideDebugButton_;

	internal long padTouchBegin_;

	internal int optionPage_;

	internal int optionPageMax_;

	internal int layoutMode_;

	internal bool hide_;

	public static int SIZE_FULL;

	public static int SIZE_PLAIN;

	public static int SIZE_PLAIN_MIN;

	internal static readonly string[] WEB_NAMES;

	public const int MODE_FULL = 0;

	public const int MODE_PLAIN = 1;

	public const int MODE_OVERLAP = 2;

	internal int mode_;

	public static bool versionVisible_;

	public const int SOFT_W = 82;

	private static JCalendar drawWatch_calendar;

	private static long drawWatch_rangeMin;

	private static long drawWatch_rangeMax;

	private float[] getEvenlyDivisionArea_tmp_;

	private GamePad()
	{
	}

	public static void Load(JarInflater jar)
	{
	}

	public static GamePad GetInstance()
	{
		return null;
	}

	public int GetMode()
	{
		return 0;
	}

	public void SetMode(int mode)
	{
	}

	public override bool IsGameSurface()
	{
		return false;
	}

	private void AddTouch(Graphics g, float x, float y, int id)
	{
	}

	private void AddTouch(Graphics g, float x, float y, int id, int value)
	{
	}

	private void AddTouch(Graphics g, float x, float y, int id, int value, bool enable)
	{
	}

	protected override void OnTouchEvent(TouchEvent evt)
	{
	}

	public override void Draw(Graphics g)
	{
	}

	public bool IsSmallSideView()
	{
		return false;
	}

	public float GetSideViewRatio()
	{
		return 0f;
	}

	public int GetSideSize()
	{
		return 0;
	}

	private bool DrawSoftLabel(Graphics g, float x, float y, int id, int value, bool enable)
	{
		return false;
	}

	private void DrawSoftLabelImage(Graphics g, float x, float y, int imgId)
	{
	}

	private bool IsSoftLabelID(int id)
	{
		return false;
	}

	public void DrawVersion(Graphics g)
	{
	}

	internal void DrawWatch(Graphics g, float x, float y)
	{
	}

	internal void DrawBattery(Graphics g, float x, float y)
	{
	}

	private void DrawImage(Graphics g, float x, float y, int imgId)
	{
	}

	public static void debugDrawImage(Graphics g, float x, float y, int imgId)
	{
	}

	private void DrawScaledImage(Graphics g, float x, float y, float w, float h, int imgId)
	{
	}

	public static void debugDrawScaledImage(Graphics g, float x, float y, float w, float h, int imgId)
	{
	}

	public override void RotateClear()
	{
	}

	private float[] GetDivisionArea(float left, float right, float padding, int index, int max)
	{
		return null;
	}

	public void SetLayoutMode(int mode)
	{
	}

	public int GetLayoutMode()
	{
		return 0;
	}

	public void SetOptionPage(int page)
	{
	}

	public int GetOptionPage()
	{
		return 0;
	}
}
