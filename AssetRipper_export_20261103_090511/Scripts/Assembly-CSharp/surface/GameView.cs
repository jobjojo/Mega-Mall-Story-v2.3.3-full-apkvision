using form;
using java.util;
using kairo.unity.surface;
using kairo.unity.ui;
using kairo.unity.util;

namespace surface;

public class GameView : SurfaceBase
{
	internal static GameView instance_;

	internal IApplication app_;

	internal Canvas canvas_;

	internal TouchEffectManager effMan_;

	internal FormManager formMan_;

	internal static Image[] images_;

	internal static readonly string[] FILENAMES;

	internal static readonly int[] IMAGE_WIDTH;

	public const int TEX_LEFT_ARW = 0;

	public const int TEX_RIGHT_ARW = 1;

	public const int TEX_LEFT_ARW_L = 2;

	public const int TEX_RIGHT_ARW_L = 3;

	public const int TEX_MINUS = 4;

	public const int TEX_PLUS = 5;

	public const int TEX_MINUS_L = 6;

	public const int TEX_PLUS_L = 7;

	public const int TEX_MARKER_LEFT = 8;

	public const int TEX_MARKER_CENTER = 9;

	public const int TEX_MARKER_RIGHT = 10;

	public const int TEX_TRACK_BAR = 11;

	public const int TEX_NOTES = 12;

	public static readonly int[][] TEXTURES;

	internal const int T_IMG = 0;

	internal const int T_X = 1;

	internal const int T_Y = 2;

	internal const int T_U = 3;

	internal const int T_V = 4;

	internal const int T_W = 5;

	internal const int T_H = 6;

	internal Image render_;

	internal Graphics g_;

	public const int ID_TITLEMENU = 0;

	public const int ID_DLGPAGE = 1;

	public const int ID_DLGCMD = 2;

	public const int ID_DLGSEL = 3;

	public const int ID_KEYCLICK = 4;

	public const int ID_KEYPRESS = 5;

	public const int ID_KEYDOWN = 6;

	public const int ID_KEYUP = 7;

	public const int ID_MAINMENU = 8;

	public const int ID_SUBMENU = 9;

	public const int ID_LIST = 10;

	public const int ID_SLIST = 11;

	public const int ID_VSCROLLBAR = 12;

	public const int ID_VSCROLLBTN = 13;

	public const int ID_VSCROLLBAR2 = 14;

	public const int ID_VSCROLLBAR3 = 15;

	public const int ID_UNMARKER = 16;

	public const int ID_CAMERA = 17;

	public const int ID_ARROW = 18;

	public const int ID_TRACKBAR = 19;

	public const int ID_PLUS = 20;

	public const int ID_MINUS = 21;

	public const int ID_OVER = 22;

	public const int ID_ARROWPRESS = 23;

	public const int ID_ARROWPRESS_L = 24;

	public const int ID_ARROWPRESS_R = 25;

	public const int ID_NOTES = 26;

	public const int ID_PREV = 27;

	public const int ID_NEXT = 28;

	public const int ID_NO = 29;

	public const int ID_SCROLLBG = 30;

	internal static readonly int[][] TOUCHPARAMS;

	private const int TPARAM_LEFT = 0;

	private const int TPARAM_RIGHT = 1;

	private const int TPARAM_TOP = 2;

	private const int TPARAM_BOTTOM = 3;

	private const int TPARAM_COLLISION = 4;

	private const int TPARAM_SCREEN = 5;

	public const int VALUE_KEY = 65536;

	public const int VALUE_SELECT = 131072;

	public const int VALUE_SELMENU = 196608;

	public const int VALUE_SCROLL = 262144;

	public const int VALUE_BUILDCATEGORY = 327680;

	public const int VALUE_QUALITY = 393216;

	public const int VALUE_GAMESPEED = 458752;

	public const int VALUE_BGM_VOLUME = 524288;

	public const int VALUE_SE_VOLUME = 589824;

	public const int VALUE_CURRENCY = 655360;

	public const int VALUE_ORIENTATION = 720896;

	public const int VALUE_PAGE = 786432;

	public const int VALUE_SELECT2 = 851968;

	public const int VALUE_VALUE1 = 917504;

	internal Font font_;

	internal long markComponentKey_;

	private int markComponentFrame_;

	private bool capture_;

	private string captureFile_;

	private int captureScale_;

	private string toastText_;

	private bool addScrollMargin_;

	private int notesFrame_;

	public long notesEffect_;

	public const int KEYID_0 = 0;

	public const int KEYID_1 = 1;

	public const int KEYID_2 = 2;

	public const int KEYID_3 = 3;

	public const int KEYID_4 = 4;

	public const int KEYID_5 = 5;

	public const int KEYID_6 = 6;

	public const int KEYID_7 = 7;

	public const int KEYID_8 = 8;

	public const int KEYID_9 = 9;

	public const int KEYID_ASTERISK = 10;

	public const int KEYID_POUND = 11;

	public const int KEYID_LEFT = 16;

	public const int KEYID_UP = 17;

	public const int KEYID_RIGHT = 18;

	public const int KEYID_DOWN = 19;

	public const int KEYID_SELECT = 20;

	public const int KEYID_SOFT1 = 21;

	public const int KEYID_SOFT2 = 22;

	public const int KEYID_SOFT3 = 23;

	public const int KEYID_SOFT4 = 24;

	public const int KEYID_USER1 = 25;

	public const int KEYID_USER2 = 26;

	public const int KEYID_USER3 = 27;

	public const int KEYID_USER4 = 28;

	public const int KEYID_USER5 = 29;

	public const int KEYID_USER6 = 30;

	internal Vector<int[]> delayPaintBuffer_;

	private int loopFrame_;

	private static float[] GetImageRect_result;

	private int[] drawVerticalScroll_tmp;

	private GameView()
	{
	}

	public static void Load(JarInflater jar)
	{
	}

	public static GameView GetInstance()
	{
		return null;
	}

	public int GetSideSoftWidth()
	{
		return 0;
	}

	public override bool IsGameSurface()
	{
		return false;
	}

	public override void BeginTouchRegist(Graphics g)
	{
	}

	public override void EndTouchRegist(Graphics g)
	{
	}

	public override void DoEnd()
	{
	}

	public static TouchComponent AddTouch(int id)
	{
		return null;
	}

	public static TouchComponent AddTouch(int id, int value)
	{
		return null;
	}

	public static TouchComponent AddTouch(int id, TouchOption opt)
	{
		return null;
	}

	public static TouchComponent AddTouch(int id, int value, TouchOption opt)
	{
		return null;
	}

	public static TouchComponent AddTouch(Graphics g, int id, int x, int y, int w, int h)
	{
		return null;
	}

	public static TouchComponent AddTouch(Graphics g, int id, int x, int y, int w, int h, int value)
	{
		return null;
	}

	public static TouchComponent AddTouch(Graphics g, int id, int x, int y, int w, int h, int value, TouchOption opt)
	{
		return null;
	}

	public static TouchComponent AddTouch(Graphics g, int id, Image img, int x, int y, int u, int v, int w, int h)
	{
		return null;
	}

	public static TouchComponent AddTouch(Graphics g, int id, Image img, int x, int y, int u, int v, int w, int h, int value)
	{
		return null;
	}

	public static TouchComponent AddTouch(Graphics g, int id, Image img, int x, int y, int u, int v, int w, int h, int value, TouchOption opt)
	{
		return null;
	}

	public static TouchComponent AddTouch(Graphics g, int id, int x, int y, Seb seb, int frame)
	{
		return null;
	}

	public static TouchComponent AddTouch(Graphics g, int id, int x, int y, Seb seb, int frame, int value)
	{
		return null;
	}

	public static TouchComponent AddTouch(Graphics g, int id, int x, int y, Seb seb, int frame, int value, TouchOption opt)
	{
		return null;
	}

	internal TouchComponent _addTouch(Graphics g, int id, int x, int y, int w, int h, int value, TouchOption opt)
	{
		return null;
	}

	public static bool CheckMarker(long key)
	{
		return false;
	}

	public static bool CheckMarker(int id, int value)
	{
		return false;
	}

	public static void ClearMarker()
	{
	}

	public override void OnKeyDown(int key)
	{
	}

	internal void Set(int value, TouchComponent c)
	{
	}

	internal void Set(TouchValueAccessor va, int value, TouchComponent c)
	{
	}

	internal void Set(int type, int value, TouchComponent c)
	{
	}

	internal void Set(TouchValueAccessor va, int type, int value, TouchComponent c)
	{
	}

	internal int Get(int type)
	{
		return 0;
	}

	internal int Get(TouchValueAccessor va, int type)
	{
		return 0;
	}

	internal bool CheckHitRect(int x1, int y1, int w1, int h1, int x2, int y2, int w2, int h2)
	{
		return false;
	}

	internal int Join(int type, int v)
	{
		return 0;
	}

	internal TouchValueAccessor GetTouchValueAccessor()
	{
		return null;
	}

	protected override void OnTouchEvent(TouchEvent e)
	{
	}

	internal void OnTouchTitleMenu(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchDlgPage(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchDlgCmd(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchDlgSel(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchKeyClick(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchKeyPress(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchArrowPress(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchKeyDown(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchKeyUp(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchMainMenu(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchSubMenu(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchList(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchScrollList(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchVScrollBar(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchVScrollButton(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchUnMarker(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchCamera(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchTrackBar(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchOver(int type, int v, TouchEvent e)
	{
	}

	protected void OnTouchNextPrev(int type, int v, TouchEvent e)
	{
	}

	protected void OnTouchNo(int type, int v, TouchEvent e)
	{
	}

	public override void Draw(Graphics g)
	{
	}

	private void DrawImage(Graphics g, float x, float y, int imgId)
	{
	}

	private void DrawScaledImage(Graphics g, float x, float y, float w, float h, int imgId)
	{
	}

	private static float[] GetImageRect(int imgId)
	{
		return null;
	}

	public int[] DrawVerticalScroll(Graphics g, int x, int y, int w, int h, int value, int maximum, int largeChange, bool touch, int type)
	{
		return null;
	}

	public TouchEffect AddEffect(int id, int x, int y, int imgId, TouchComponent c)
	{
		return null;
	}

	public override void RotateClear()
	{
	}

	public override void OnReceiveTouchEvent(MotionEvent evt)
	{
	}

	private int GetKey(TouchComponent c, int defaultKey)
	{
		return 0;
	}

	private void AddDelayPaintBuffer(Graphics g, int[] paint)
	{
	}
}
