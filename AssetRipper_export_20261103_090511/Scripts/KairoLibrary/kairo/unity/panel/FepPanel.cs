using System;
using kairo.unity.ui;

namespace kairo.unity.panel;

public abstract class FepPanel
{
	public class Display
	{
		public static void SetCurrent(FepPanel panel)
		{
		}

		public static void SetCurrent(Canvas canvas)
		{
		}
	}

	public const int SOFT_KEY_1 = 0;

	public const int SOFT_KEY_2 = 1;

	public const int BUTTON_PRESSED = 1;

	public const int SELECTION_CHANGED = 2;

	public const int TEXT_CHANGED = 3;

	private static FepPanel current_;

	private Label label_;

	private TextBox text_;

	private Button btn1_;

	private Button btn2_;

	private int delay_;

	public static FepPanel Current => null;

	public FepPanel()
	{
	}

	public void SetLayoutManager(object obj)
	{
	}

	public void SetComponentListener(object obj)
	{
	}

	public void SetSoftLabel(int key, string text)
	{
	}

	public int GetWidth()
	{
		return 0;
	}

	public int GetHeight()
	{
		return 0;
	}

	public void Add(Component component)
	{
	}

	[Obsolete("kfw.paenl.MainPanel.Show()を使用してください")]
	public void Show()
	{
	}

	public void Start()
	{
	}

	internal bool Update()
	{
		return false;
	}

	public abstract void ComponentAction(Component c, int type, int param);

	public static int GetStringLength(string s)
	{
		return 0;
	}

	private static bool IsSimpleChara(char c)
	{
		return false;
	}
}
