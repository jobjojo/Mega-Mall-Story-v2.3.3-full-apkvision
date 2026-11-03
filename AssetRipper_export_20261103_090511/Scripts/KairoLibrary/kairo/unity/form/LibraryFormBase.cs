using kairo.unity.surface;
using kairo.unity.ui;

namespace kairo.unity.form;

public class LibraryFormBase : FormBase
{
	internal IApplication app_;

	internal Canvas canvas_;

	internal SurfaceBase view_;

	internal int update_;

	internal int draw_;

	protected int select_;

	protected const int ID_DLGCMD = 2;

	protected const int ID_ARROW = 18;

	protected const int ID_SWITCH = 31;

	public const int VALUE_KEY = 65536;

	public const int VALUE_SELECT = 131072;

	public const int VALUE_SELMENU = 196608;

	public const int VALUE_BOOL = 327680;

	internal LibraryFormBase(int id)
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

	public bool IsPushSoftLabel(string softlabel, int key = 0)
	{
		return false;
	}

	public static string Replace(string text, string arg)
	{
		return null;
	}

	public string Replace(string text, string oldStr, string newStr)
	{
		return null;
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

	public virtual bool OnTouchEvent(TouchEvent e)
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

	public int Tv(int type, int value)
	{
		return 0;
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

	internal int Join(int type, int v)
	{
		return 0;
	}

	internal TouchValueAccessor GetTouchValueAccessor()
	{
		return null;
	}

	internal int GetKey(TouchComponent c, int defaultKey)
	{
		return 0;
	}

	protected static void AddTouch(Graphics g, int ID, int x, int y, int w, int h, TouchOption option = null)
	{
	}

	protected static void AddTouch(Graphics g, int ID, int x, int y, int w, int h, int value, TouchOption option = null)
	{
	}

	protected static void AddTouch(int ID, TouchOption option = null)
	{
	}

	protected static void AddTouch(int ID, int x, int y, int w, int h, TouchOption option = null)
	{
	}

	protected static void AddTouch(int ID, int x, int y, int w, int h, int value, TouchOption option = null)
	{
	}

	internal void OnTouchDlgCmd(int type, int v, TouchEvent e)
	{
	}

	internal void OnTouchArrow(int type, int v, TouchEvent e)
	{
	}
}
