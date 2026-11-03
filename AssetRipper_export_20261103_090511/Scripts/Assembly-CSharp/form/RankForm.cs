using kairo.unity.ui;

namespace form;

public class RankForm : MyFormBase
{
	internal static readonly int BUILDING_MAX;

	internal int[] building;

	internal static readonly int BUILDING_SPACE;

	internal int aa_imgId;

	private int frame_;

	private int frame2_;

	private int page_;

	private int chara_;

	private const int STATE_TOP = 0;

	private int state_;

	private static readonly int[][] softLabels_;

	private const int RESEVENT_SEB_BG = 0;

	private const int RESEVENT_SEB_CHARA = 1;

	private const int RESEVENT_SEB_BOX = 1;

	private const int RESEVENT_SEB_MINIHAPPY = 2;

	private ResourceManager resEvent_;

	public RankForm()
		: base(0)
	{
	}

	public override string ToString()
	{
		return null;
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

	private void _draw(Graphics g)
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

	private void ChangeState(int state)
	{
	}

	private void SetSoftLabel()
	{
	}

	public override int GetTouchValue(int type, int index)
	{
		return 0;
	}

	public override void SetTouchValue(int type, int value)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
