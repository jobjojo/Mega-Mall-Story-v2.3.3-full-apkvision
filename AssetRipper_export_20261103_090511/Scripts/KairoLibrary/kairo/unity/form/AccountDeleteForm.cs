using System;
using java.lang;
using kairo.unity.surface;
using kairo.unity.ui;

namespace kairo.unity.form;

public class AccountDeleteForm : LibraryFormBase, JRunnable
{
	public delegate void DeleteFunc();

	private const int FRAME_MAX = 24;

	private int frame_;

	public const int TYPE_GAME_ACCOUNT = 0;

	private int type_;

	private const int PAGE_0_SELECT = 0;

	private const int PAGE_1_FOURCORNERS = 1;

	private const int PAGE_2_FINALANSWER = 2;

	private const int PAGE_3_DELETE = 3;

	private const int PAGE_4_EXIT = 4;

	private int page_;

	private const int SELECT_YES = 0;

	private const int SELECT_NO = 1;

	public const int RESLUT_NONE = -1;

	public const int RESLUT_CANCEL = 0;

	public const int RESLUT_DELETE = 1;

	public int result_;

	private bool[] lock_;

	private TextLayout textLay_;

	private int buttonWidth_;

	private int[] buttonResults_;

	private string[] buttonTexts_;

	private const int TITLE_H = 21;

	private const int BUTTON_H = 21;

	private const int DEFAULT_WINDOW_W = 212;

	private const int BUTTON_PADING = 6;

	private int[] windowSize_;

	private int[] messageSize_;

	private string TITLE_MESSAGE;

	private string PAGE_0_MESSAGE;

	private string PAGE_1_MESSAGE;

	private string PAGE_2_MESSAGE;

	private string PAGE_3_MESSAGE;

	private string PAGE_4_MESSAGE;

	private string PAGE_0_MESSAGE_PASSWORD;

	private string PAGE_0_MESSAGE_DELETE_ID;

	private const int THMODE_DELETE = 0;

	private const int THSTATE_NONE = -1;

	private const int THSTATE_RUN = 0;

	private const int THSTATE_SUCCEED = 1;

	private const int THSTATE_FAILURE = 2;

	private JThread thread_;

	private int thMode_;

	private int thState_;

	private Exception thException_;

	private string thError_;

	private DialogForm dialogForm_;

	private string sendInfoOperationMode_;

	private string sendInfoOther_;

	private readonly int TOUCH_ID_DLGCMD;

	private readonly int TOUCH_ID_SWITCH;

	public DeleteFunc deleteFunc_;

	private AccountDeleteForm()
		: base(0)
	{
	}

	public AccountDeleteForm(int type, string operation_mode = "2", string other = null, int touchDlgCmd = 2, int touchSwitch = 31)
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

	private void ChangePage(int page)
	{
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

	public void ResizeWindow(int windowW, int windowH, int lineSpace = -1)
	{
	}

	private void SetText(string message)
	{
	}

	public override int GetTouchValue(int type, int index)
	{
		return 0;
	}

	public override void SetTouchValue(int type, int value)
	{
	}

	public override bool OnTouchEvent(TouchEvent e)
	{
		return false;
	}

	internal void OnTouchLock(int type, int v, TouchEvent e)
	{
	}

	private void StartThread(int thMode)
	{
	}

	public void Run()
	{
	}

	public string MakePassword()
	{
		return null;
	}
}
