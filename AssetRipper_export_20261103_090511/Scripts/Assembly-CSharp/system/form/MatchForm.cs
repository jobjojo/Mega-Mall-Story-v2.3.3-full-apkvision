using form;
using java.lang;
using kairo.unity.ui;

namespace system.form;

public class MatchForm : MyFormBase, JRunnable
{
	private class UserRecord
	{
		public int rank_;

		public int friendId_;

		public int number_;

		public int visitor_;

		public string innName_;

		public int year_;

		public int month_;

		public int week_;

		public long money_;

		public string country_;

		public string name_;

		public Image image_;
	}

	public const int FORMID_MATCH = 904;

	public const int TYPE_MATCHING = 0;

	public const int TYPE_RANKING = 1;

	public int type_;

	private static readonly int[][] configData_;

	public bool untilActiveHide_;

	private int select_;

	private int command_;

	private int x_;

	private int y_;

	private int loopCounter_;

	private new bool draw_;

	private UserRecord[] userList_;

	private UserRecord dlUser_;

	internal int USER_MAX;

	internal int TOPRANK_MAX;

	private UserRecord[][] rankList_;

	private const int THTYPE_MATCHING = 0;

	private const int THTYPE_RANKING = 1;

	private const int THTYPE_DOWNLOAD = 2;

	private int threadType_;

	private const int THSTATE_NONE = 0;

	private const int THSTATE_RUN = 1;

	private const int THSTATE_SUCCESS = 2;

	private const int THSTATE_FAILURE = 3;

	private int threadState_;

	private string error_;

	private JThread th_;

	private static byte[] upload_;

	public override string ToString()
	{
		return null;
	}

	public MatchForm()
		: base(0)
	{
	}

	public MatchForm(int type)
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

	private void _draw(Graphics g)
	{
	}

	private new int GetBoxFooterY(int v)
	{
		return 0;
	}

	private new float GetBoxHeaderY(int v)
	{
		return 0f;
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

	private bool _update()
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

	public void ThreadStart(int type)
	{
	}

	public void Run()
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
