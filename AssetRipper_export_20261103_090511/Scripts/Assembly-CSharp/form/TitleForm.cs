using java.util;
using kairo.unity.surface;
using kairo.unity.ui;
using main;

namespace form;

public class TitleForm : MyFormBase
{
	public static bool title_now;

	public const int BACK_HEIGHT = 378;

	public const int CARTAIN_HEIGHT = 600;

	public static int zure_h;

	private new AppData apdat_;

	private new Canvas canvas_;

	private new FormManager formMan_;

	public const int RESTITLE_IMG_LOGO = 2;

	public const int RESTITLE_IMG_CURTAIN = 3;

	public const int RESTITLE_IMG_LIGHT = 4;

	public const int RESTITLE_IMG_SAVELOAD = 5;

	public const int RESTITLE_IMG_TOPMARGIN = 7;

	public const int RESTITLE_IMG_SUBWAY = 8;

	public const int RESTITLE_IMG_BUS = 9;

	public ResourceManager resTitle_;

	private const int STATE_MENU = 0;

	internal static readonly int STATE_SAVESLOT;

	internal static int state_;

	private static readonly int[][] softLabels_;

	private const int MENU_START = 0;

	private const int MENU_LOAD = 0;

	private const int MENU_RANKING = 1;

	private const int MENU_SITE = 3;

	private const int MENU_END = 2;

	private int selMenu_;

	private new SubForm dialog_;

	private int titleY_;

	private int titleFrame_;

	private int sunY_;

	private bool playLoopBgm_;

	private int POUND_PRESS_CNT;

	private bool STAR;

	private int selectSaveType_;

	private int selectSave_;

	private int currentSave_;

	public bool flg_bgmOlder;

	public string newGameName_;

	public bool newGameFlag_;

	public int newGameFrame1_;

	public int newGameFrame2_;

	private static readonly int[] title_anime;

	private Vector waitHumans_;

	private Vector existHumans_;

	private Vector shopHumans_;

	private const int HUMAN_ID = 0;

	private const int HUMAN_X = 1;

	private const int HUMAN_Y = 2;

	private const int HUMAN_VX = 3;

	private const int HUMAN_VY = 4;

	private const int HUMAN_DIR = 5;

	private const int HUMAN_FRAME = 6;

	private const int HUMAN_STATE = 7;

	private const int HUMAN_IN_X = 8;

	private const int HUMAN_OUT_Y = 9;

	private const int HUMAN_BAG = 10;

	private const int HUMAN_END = 11;

	private const int COURSE_NUM = 5;

	private const int COURSE_MUL = 6;

	private int[][] humanCourseRatio_;

	private const int DOOR_SWITCH_INTERVAL = 5;

	private const int DOOR_OPEN_INTERVAL = 10;

	private int[] doorLeft_;

	private int[] doorRight_;

	private int startWait_;

	private const int HUMAN_SCALE = 1000;

	internal int playBgmTime;

	internal int TBGM;

	internal int frame_;

	public const int TA_ALLTIME = 600;

	public int ta_cnt;

	public const int TA_DIS = 24000;

	public const int TA_TIME = 240;

	public const int TA_V = 100;

	public static readonly int[][] TA_DATA;

	internal bool[] flg_taAnime;

	internal int[] ta_animeCnt;

	internal int[] ta_id;

	internal Vector ta;

	public override string ToString()
	{
		return null;
	}

	public TitleForm()
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

	private void ContinueGame()
	{
	}

	private void NewGame()
	{
	}

	private void DrawRepeat(Graphics g, int seb, int x, int y, int w, int frame)
	{
	}

	public void SmartBeginPaint(Graphics g)
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

	public void Update_titleAnime()
	{
	}

	public void Draw_titleAnime(Graphics g)
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

	public override bool OnTouchEvent(TouchEvent e)
	{
		return false;
	}
}
