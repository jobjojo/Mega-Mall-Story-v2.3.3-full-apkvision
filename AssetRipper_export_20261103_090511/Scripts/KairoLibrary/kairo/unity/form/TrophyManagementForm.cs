using kairo.unity.surface;
using kairo.unity.ui;

namespace kairo.unity.form;

public class TrophyManagementForm : LibraryFormBase
{
	private string[] trophyList_;

	private string log_;

	private int logTime_;

	private const int STEP = 11;

	public TrophyManagementForm()
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

	private void Log(string text)
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
