using System;
using kairo.unity.panel;
using kairo.unity.ui;

namespace kfw.panel;

public class MainPanel : FepPanel
{
	public delegate void OnFinishMethod(string result);

	private Label lbl1;

	private TextBox txtBox;

	private Button btn;

	private Button btn2;

	private Canvas bkCanvas_;

	private int maxLength_;

	private int maxWidth_;

	private char[] prohibition_;

	private string itemName_;

	private bool endMark_;

	private bool trim_;

	private int inputMode_;

	private bool end_;

	public string result_;

	public string defaultText_;

	public string originalText_;

	private string[] bkSoftLabels_;

	private OnFinishMethod onFinishMethod_;

	public MainPanel()
	{
	}

	public MainPanel(string label, string defaultText, int maxLength = 14, int inputMode = 2, string itemName = null)
	{
	}

	private void Init(string label, string defaultText, int maxLength, int inputMode, string itemName)
	{
	}

	[Obsolete("入力パネルはiPhone対応に向けて処理をブロックさせず、第二引数にイベントハンドラを指定する方式に書き換えてください。")]
	public virtual string Show(Canvas canvas)
	{
		return null;
	}

	public virtual void Show(Canvas canvas, OnFinishMethod onFinishMethod)
	{
	}

	public override void ComponentAction(Component c, int type, int param)
	{
	}

	private void ReStart()
	{
	}

	public void SetProhibition(char[] words)
	{
	}

	public void SetItemName(string name)
	{
	}

	public void SetEndMark(bool enable)
	{
	}

	public void SetTrim(bool enable)
	{
	}

	private int GetStringWidth(string str)
	{
		return 0;
	}

	public static bool IsSupportsLanguage()
	{
		return false;
	}
}
