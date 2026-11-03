using java.lang;
using kairo.unity.surface;
using kairo.unity.ui;

namespace kairo.unity.form;

public class LanguageSelectForm : LibraryFormBase, JRunnable
{
	private const int FRAME_MAX = 128;

	private int frame_;

	private const int STATE_SELECT = 0;

	private const int STATE_SHEET_SELECT = 1;

	private const int STATE_LOADING = 2;

	private const int STATE_TEST = 3;

	private const int STATE_END = 4;

	private int state_;

	private static readonly string[][] softLabels_;

	private string[] langs_;

	private int index_;

	private string location_;

	private bool draw2rows_;

	private string[] results_;

	private string accessID_;

	private string[] sheets_;

	private int sheetSelect_;

	private DialogForm dialogForm_;

	private JThread th_;

	private bool thSuccess_;

	private byte[][] receiveBytes_;

	private LanguageSelectForm()
		: base(0)
	{
	}

	public LanguageSelectForm(string[] languages, int index, string customPackLocation)
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

	private void DrawLanguageTitle(Graphics g, string title, float dx, float dy, int width, int height, int color, int fontOffset = 0)
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

	public string[] GetResults()
	{
		return null;
	}

	private void ChangeState(int state)
	{
	}

	private void CreateLangPack()
	{
	}

	private void LoadLangPack()
	{
	}

	private string GetSpreadsheetURL(string deployId, string sheetName)
	{
		return null;
	}

	private bool CheckSpreadsheetSetting()
	{
		return false;
	}

	public void Run()
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
}
