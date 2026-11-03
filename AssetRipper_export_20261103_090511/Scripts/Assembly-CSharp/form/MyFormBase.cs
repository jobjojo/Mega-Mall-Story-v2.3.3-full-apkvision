using game_kasa;
using java.util;
using kairo.unity.form;
using kairo.unity.surface;
using kairo.unity.ui;
using main;
using surface;

namespace form;

public class MyFormBase : FormBase
{
	public struct sTouchPoint
	{
		public int id;

		public int x;

		public int y;

		public int w;

		public int h;

		public int val;

		public TouchOption opt;
	}

	internal IApplication app_;

	internal AppData apdat_;

	internal Canvas canvas_;

	internal FormManager formMan_;

	public static GameView view_;

	internal GamePad pad_;

	internal Camera camera_;

	internal int update_;

	internal int draw_;

	internal SubForm dialog_;

	internal int result_;

	internal int arwFrame_;

	internal static readonly int TITLE_HEIGHT;

	internal static readonly int WNDFLAG_LEFT_ARW;

	internal static readonly int WNDFLAG_RIGHT_ARW;

	internal static readonly int WNDFLAG_BOX;

	internal static readonly int WNDRET_TOP;

	internal static readonly int WNDRET_RIGHT;

	internal static readonly int WNDRET_BOTTOM;

	internal static readonly int WNDRET_LEFT;

	internal static readonly int WNDRET_WIDTH;

	internal static readonly int WNDRET_HEIGHT;

	internal static readonly int WNDRET_BOX_TOP;

	internal static readonly int WNDRET_BOX_RIGHT;

	internal static readonly int WNDRET_BOX_BOTTOM;

	internal static readonly int WNDRET_BOX_LEFT;

	internal static readonly int WNDRET_BOX_WIDTH;

	internal static readonly int WNDRET_BOX_HEIGHT;

	internal static readonly int WNDRET_BOX_END;

	private int[] drawWindow_tmp;

	private static int fontSize_;

	private Vector<sTouchPoint> touchList_;

	internal MyFormBase(int id)
		: base(0)
	{
	}

	public override bool Init()
	{
		return false;
	}

	public override bool Update()
	{
		return false;
	}

	public override void Draw(Graphics g)
	{
	}

	public override bool Resume()
	{
		return false;
	}

	public override bool Finish()
	{
		return false;
	}

	public static string Unit(long value, bool cs)
	{
		return null;
	}

	internal static string Comma(long value)
	{
		return null;
	}

	internal string Format(string str, int len)
	{
		return null;
	}

	internal string Format(string str, int len, char padding)
	{
		return null;
	}

	internal string Format(int v, int len)
	{
		return null;
	}

	internal string Format(int v, int len, char padding)
	{
		return null;
	}

	internal string Format(long v, int len)
	{
		return null;
	}

	internal string Format(long v, int len, char padding)
	{
		return null;
	}

	public static string Replace(string text, string arg)
	{
		return null;
	}

	public string Replace(string text, string oldStr, string newStr)
	{
		return null;
	}

	internal bool Active()
	{
		return false;
	}

	internal bool Push(string text)
	{
		return false;
	}

	internal bool Push(string text, string cmds)
	{
		return false;
	}

	internal bool Push(string text, string cmds, int defaultSelect)
	{
		return false;
	}

	internal bool Pop(int result)
	{
		return false;
	}

	internal bool Check(int flag, int bit)
	{
		return false;
	}

	internal static bool Jp()
	{
		return false;
	}

	internal static bool En()
	{
		return false;
	}

	internal static bool Korea()
	{
		return false;
	}

	internal static bool Zh()
	{
		return false;
	}

	internal static bool Zh_CN()
	{
		return false;
	}

	internal static bool TH()
	{
		return false;
	}

	internal static bool DE()
	{
		return false;
	}

	internal static bool RU()
	{
		return false;
	}

	internal static bool FR()
	{
		return false;
	}

	internal static bool PT()
	{
		return false;
	}

	internal static bool LanguageAddVersion()
	{
		return false;
	}

	public override int GetTouchValue(int type, int index)
	{
		return 0;
	}

	public override void SetTouchValue(int type, int value)
	{
	}

	public virtual bool OnTouchEvent(TouchEvent e)
	{
		return false;
	}

	public int Tv(int type, int value)
	{
		return 0;
	}

	internal int[] DrawWindow(Graphics g, int width, int height, string title, int sideSpace, int topSpace, int bottomSpace, int flag)
	{
		return null;
	}

	internal int[] DrawWindow(Graphics g, int width, int height, string title, int sideSpace, int topSpace, int bottomSpace, int flag, int page, int pageMax)
	{
		return null;
	}

	internal virtual int[] DrawWindow(Graphics g, int width, int height, string title, int sideSpace, int topSpace, int bottomSpace, int barArwSpace, int flag)
	{
		return null;
	}

	internal int[] DrawWindow(Graphics g, int width, int height, string title, int sideSpace, int topSpace, int bottomSpace, int barArwSpace, int flag, int page, int pageMax)
	{
		return null;
	}

	public static int GetBoxHeaderY(int boxTop)
	{
		return 0;
	}

	public static int GetBoxFooterY(int boxBottom)
	{
		return 0;
	}

	public static string LT(string text)
	{
		return null;
	}

	public static string LT(string text, string arg)
	{
		return null;
	}

	public static string LT(string text, long arg)
	{
		return null;
	}

	public TextFormat LF(string format)
	{
		return null;
	}

	public static string YEN(string text, long value)
	{
		return null;
	}

	public static string YEN(string text, long value, bool comma)
	{
		return null;
	}

	public static string UNI(string text, long value)
	{
		return null;
	}

	public static string UNI(string text, long value, bool comma)
	{
		return null;
	}

	public static void PushFontSize(Graphics g, int size)
	{
	}

	public static void BackFontSize(Graphics g)
	{
	}

	public void ResetTouchList()
	{
	}

	public void AddTouchList(int id, int x = 0, int y = 0, int w = 0, int h = 0, int val = 0, TouchOption opt = null)
	{
	}

	public void AttachTouchList(Graphics g)
	{
	}
}
