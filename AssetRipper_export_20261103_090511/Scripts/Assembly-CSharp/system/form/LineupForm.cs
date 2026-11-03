using form;
using kairo.unity.system.lineup.ui;
using kairo.unity.ui;

namespace system.form;

public class LineupForm : MyFormBase
{
	public const int FORMID_LINEUP = 903;

	public const int TYPE_MAIN = 0;

	public int type_;

	private static readonly int[][] configData_;

	private int select_;

	private int loopCounter_;

	private int frame_;

	private LineupData[] linups_;

	private TextLayout lay_;

	private int[] clip_;

	private bool push_;

	internal const int RESLINEUPLAY_SEB_BG = 0;

	internal static ResourceManager resLineupLayout_;

	public override string ToString()
	{
		return null;
	}

	public LineupForm()
		: base(0)
	{
	}

	public LineupForm(int type)
		: base(0)
	{
	}

	public override bool Init()
	{
		return false;
	}

	public override void Draw(Graphics g)
	{
	}

	public override bool Finish()
	{
		return false;
	}

	public override bool Resume()
	{
		return false;
	}

	public override bool Update()
	{
		return false;
	}

	public int[] DrawCommand(Graphics g, string str, int x, int y, int anchor, bool active, int margin, bool cursor)
	{
		return null;
	}

	public override int GetTouchValue(int type, int index)
	{
		return 0;
	}

	public override void SetTouchValue(int type, int value)
	{
	}

	public override bool CheckMainWindow()
	{
		return false;
	}

	public void SetSoftlabel()
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
