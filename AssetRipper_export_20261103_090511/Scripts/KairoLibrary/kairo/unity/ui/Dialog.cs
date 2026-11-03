using System;

namespace kairo.unity.ui;

public class Dialog
{
	public delegate void OnFinishMethod(int result);

	public const int BUTTON_CANCEL = 2;

	public const int BUTTON_NO = 8;

	public const int BUTTON_OK = 1;

	public const int BUTTON_YES = 4;

	public const int DIALOG_ERROR = 2;

	public const int DIALOG_INFO = 0;

	public const int DIALOG_WARNING = 1;

	public const int DIALOG_YESNO = 3;

	public const int DIALOG_YESNOCANCEL = 4;

	private Font font_;

	private string title_;

	private string msg_;

	private string[] cmds_;

	private int background_;

	private int type_;

	private string url_;

	private int result_;

	private int delay_;

	private OnFinishMethod onFinishMethod_;

	private static Dialog current_;

	public static Dialog Current => null;

	public Dialog(int type, string title)
	{
	}

	public void SetFont(Font f)
	{
	}

	public void SetText(string msg)
	{
	}

	public void SetButtons(params string[] buttons)
	{
	}

	public void SetBackground(int c)
	{
	}

	public void SetSoftLabel(int key, string label)
	{
	}

	public int Show()
	{
		return 0;
	}

	[Obsolete("この機能はAndroid、iOS、Unityエディタ限定で使えます。それ以外では即時に-1が返されます。")]
	public int ShowSelection()
	{
		return 0;
	}

	public void Show(OnFinishMethod onFinishMethod)
	{
	}

	private void Start()
	{
	}

	public void Finish()
	{
	}
}
