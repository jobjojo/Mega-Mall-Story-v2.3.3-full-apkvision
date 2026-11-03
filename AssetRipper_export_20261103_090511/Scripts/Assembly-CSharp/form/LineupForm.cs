using kairo.unity.ui;

namespace form;

public class LineupForm : MyFormBase
{
	public class LineupObj
	{
		public int icon_;

		public int action_;

		public int gameId_;

		public string explain_;

		public string url_;

		public LineupObj(string src)
		{
		}
	}

	internal static Image[] images_;

	internal static Image[] icons_;

	internal static readonly string[] FILENAMES;

	internal static readonly int[] IMAGE_WIDTH;

	internal static readonly int IMG_WND;

	internal static readonly int IMG_PRT;

	private const int STATE_SELECT = 0;

	private const int STATE_DIALOG = 1;

	private int state_;

	private static readonly int[][] softLabels_;

	public const int ACTION_NONE = 0;

	public const int ACTION_SITE = 1;

	public const int ACTION_DOWNLOAD = 2;

	internal static LineupObj[] lineup_;

	internal int focus_;

	internal int scroll_;

	internal int animFrame1_;

	internal int animFrame2_;

	internal bool anyPush_;

	internal static readonly int SHOW_MAX;

	private static int[] drawVerticalScroll_tmp;

	public override string ToString()
	{
		return null;
	}

	public LineupForm()
		: base(0)
	{
	}

	public static void Load()
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

	public void Render(Graphics g)
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

	public override int GetTouchValue(int type, int index)
	{
		return 0;
	}

	public override void SetTouchValue(int type, int value)
	{
	}

	private void ScrollControl(int num, int showMax)
	{
	}

	public void ScrollUpdate(int num, int showMax)
	{
	}

	public void ScrollUpdate(int num, int showMax, int value)
	{
	}

	public static void DrawIcon(Graphics g, int x, int y, int icon)
	{
	}

	public static void DrawImage(Graphics g, int imgId, int dx, int dy, int sx, int sy, int width, int height)
	{
	}

	public static void DrawScaledImage(Graphics g, int imgId, int dx, int dy, int width, int height, int sx, int sy, int swidth, int sheight)
	{
	}

	public static int[] DrawVerticalScroll(Graphics g, int x, int y, int w, int h, int value, int maximum, int largeChange, bool touch)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
