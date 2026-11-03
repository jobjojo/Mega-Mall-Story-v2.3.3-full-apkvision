using kairo.unity.ui;

namespace kairo.unity.form;

public class DialogForm : LibraryFormBase
{
	public static int dialogResult_;

	private const int FRAME_MAX = 24;

	private int frame_;

	private bool end_;

	private bool bgDraw_;

	private bool cmdsVertical_;

	public int number_;

	public int result_;

	private string title_;

	private string message_;

	private TextLayout textLay_;

	private int buttonWidth_;

	private int[] buttonResults_;

	private string[] buttonTexts_;

	private const int TITLE_H = 21;

	private const int BUTTON_H = 21;

	private const int DEFAULT_WINDOW_W = 200;

	private int[] windowSize_;

	private int[] messageSize_;

	private const int BUTTON_PADING = 6;

	private int removeCount_;

	internal bool isExitDialog_;

	public static void Start(int type, string title, string message, string cmds)
	{
	}

	public static bool IsEnd()
	{
		return false;
	}

	public static int GetResult()
	{
		return 0;
	}

	public DialogForm(int type, string title, string message, string cmds, bool cmdsVertical = false)
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

	public void SetDrawBG(bool draw)
	{
	}

	public void ResizeWindow(int windowW, int windowH, int lineSpace = -1)
	{
	}

	public void Decide()
	{
	}

	public void Decide(int select)
	{
	}

	public void Back()
	{
	}
}
