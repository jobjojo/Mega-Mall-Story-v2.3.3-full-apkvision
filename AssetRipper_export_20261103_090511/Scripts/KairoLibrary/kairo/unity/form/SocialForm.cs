using java.lang;
using kairo.unity.system.social;
using kairo.unity.ui;

namespace kairo.unity.form;

public class SocialForm : LibraryFormBase, JRunnable
{
	private int frame_;

	private const int FADE_MAX = 8;

	private const int STATE_MAINSELECT = 0;

	private const int STATE_LEADERBOARD = 1;

	private const int STATE_ACHIEVEMENT = 2;

	private const int STATE_LEADERBOARD_RECV = 3;

	private int state_;

	private int subState_;

	private const string SOFTLABEL_CANCEL = "ｷｬﾝｾﾙ";

	public int colorBG_;

	public int colorFont_;

	public int colorBold_;

	public FormBase nextForm_;

	private DialogForm dialogForm_;

	private const int MENU_SHOW_SCORES = 0;

	private const int MENU_LOAD_SCORE = 1;

	private const int MENU_SEND_SCORE = 2;

	private const int MENU_SHOW_ACHIEVEMENTS = 3;

	private const int MENU_LOAD_ACHIEVEMENTS = 4;

	private const int MENU_UNLOCK_ACHIEVEMENT = 5;

	private const int MENU_RESET_ACHIEVEMENT = 6;

	private const int MENU_MAX = 7;

	private string[] menus_;

	private JThread th_;

	private bool drawConnecting_;

	private const string TITLE_SOCIAL_MENU = "Game Center";

	private Leaderboard.LeaderboardData[] leaderboards_;

	private Achievement.AchievementData[] achievements_;

	private int selectLDB_;

	private int selectACV_;

	private const int NEW_ICON_VALUE = 20210728;

	public override string ToString()
	{
		return null;
	}

	public SocialForm()
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

	public void Run()
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

	private void ChangeState(int state)
	{
	}

	public void SetState(int state)
	{
	}

	private DialogForm MakeInductionDialog()
	{
		return null;
	}

	private bool IsLogin()
	{
		return false;
	}

	public static void DrawButtonImage(Graphics g, Image img, int buttonX, int buttonY, int buttonW, int buttonH, bool focus)
	{
	}

	public bool IsEnabledMenu(int menuIndex)
	{
		return false;
	}

	public string GetMenuStringID(int menuIndex)
	{
		return null;
	}
}
