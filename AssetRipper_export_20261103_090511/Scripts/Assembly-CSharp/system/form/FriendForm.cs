using form;
using java.lang;
using kairo.unity.form;
using kairo.unity.surface;
using kairo.unity.ui;
using system.friend.ui;

namespace system.form;

public class FriendForm : MyFormBase
{
	public const int FORMID_FRIEND = 901;

	public const int TYPE_INPUT_NAME = 0;

	public const int TYPE_RENAME = 1;

	public const int TYPE_FRIEND_LIST = 2;

	public const int TYPE_SEARCH = 3;

	public const int TYPE_APPLY = 4;

	public const int TYPE_APPLY_CONFIRM = 5;

	public const int TYPE_APPROVE = 6;

	public const int TYPE_APPROVE2 = 7;

	public const int TYPE_REFUSE = 8;

	public const int TYPE_REFUSE2 = 9;

	public const int TYPE_ERROR_MSG = 10;

	public const int TYPE_ABOUT_FRIEND = 11;

	public const int TYPE_PLAY_BONUS1 = 12;

	public const int TYPE_PLAY_BONUS2 = 13;

	public const int TYPE_NEW_FRIEND_BONUS1 = 14;

	public const int TYPE_NEW_FRIEND_BONUS2 = 15;

	public int type_;

	private static readonly int[][] softLabels_;

	private const int PLAY_BONUS_END_FRAME = 24;

	private const int PLAY_BONUS2_END_FRAME = 50;

	private int frame_;

	private int select_;

	private int select2_;

	private int page_;

	private int value1_;

	private int loopCounter_;

	private FriendForm next_;

	private string text_;

	private string text2_;

	private TextLayout textLay_;

	private FriendData friendData_;

	public Friend friend_;

	private const int FRIEND_LIST_MAX = 5;

	private JThread th_;

	public const int RESFRIEND_SEB_TRIAL = 0;

	public const int RESFRIEND_SEB_STUDENT = 1;

	public const int RESFRIEND_SEB_OBJ01 = 2;

	public const int RESFRIEND_SEB_EXCLAMATION_MARK00 = 3;

	public const int RESFRIEND_SEB_EFFECT00 = 4;

	public const int RESFRIEND_SEB_FOUNDATION = 5;

	public const int RESFRIEND_SEB_JUMP_ASSIST00 = 6;

	public const int RESFRIEND_SEB_JUMP_ASSIST01 = 7;

	public const int RESFRIEND_SEB_TALK_ASSIST00D = 8;

	public const int RESFRIEND_SEB_TALK_ASSIST00R = 9;

	public const int RESFRIEND_SEB_TALK_ASSIST01D = 10;

	public const int RESFRIEND_SEB_TALK_ASSIST01R = 11;

	public const int RESFRIEND_SEB_CLAP_ASSIST00D = 12;

	public const int RESFRIEND_SEB_CLAP_ASSIST00R = 13;

	public const int RESFRIEND_SEB_CLAP_ASSIST01D = 14;

	public const int RESFRIEND_SEB_CLAP_ASSIST01R = 15;

	public const int RESFRIEND_SEB_TICKET = 16;

	public const int RESFRIEND_SEB_NUM_TICKET = 17;

	public const int RESFRIEND_SEB_GET = 18;

	public static ResourceManager resFriend_;

	public static int COLOR_WHITE;

	public static int COLOR_BLACK;

	public static int COLOR_RED;

	public static int COLOR_GREEN;

	public static int COLOR_BLUE;

	public static int COLOR_AQUA;

	private static int[] drawRandomFriend_result;

	public override string ToString()
	{
		return null;
	}

	public FriendForm()
		: base(0)
	{
	}

	public FriendForm(int type)
		: base(0)
	{
	}

	public static FriendForm MakeErrorMsgForm(string msg, string msg_sub)
	{
		return null;
	}

	internal static void LoadResource()
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

	private bool _update()
	{
		return false;
	}

	public override void Draw(Graphics g)
	{
	}

	public void _draw(Graphics g)
	{
	}

	private new int GetBoxFooterY(int v)
	{
		return 0;
	}

	public override bool Resume()
	{
		return false;
	}

	public override bool Finish()
	{
		return false;
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

	public int[] DrawCommand(Graphics g, string str, int x, int y, bool active, bool cursor)
	{
		return null;
	}

	public int[] DrawCommand(Graphics g, string str, int x, int y, int anchor, bool active, bool cursor)
	{
		return null;
	}

	public int[] DrawCommand(Graphics g, string str, int x, int y, int anchor, bool active, int margin, bool cursor)
	{
		return null;
	}

	public int[] DrawCommand(Graphics g, string str, int x, int y, int w, int anchor, bool active, bool cursor)
	{
		return null;
	}

	public void SetSoftLabel(int left, int right)
	{
	}

	public static void DrawLine(Graphics g, int x1, int y1, int x2, int y2, int color)
	{
	}

	public static void DrawDotLine(Graphics g, int x1, int y1, int x2, int y2, int color)
	{
	}

	public static void DrawRect(Graphics g, int x, int y, int width, int height, int color)
	{
	}

	public static void DrawRect2(Graphics g, int x, int y, int width, int height, int color1, int color2)
	{
	}

	public static void DrawRect3(Graphics g, int x, int y, int width, int height, int color1, int color2, int color3)
	{
	}

	public static void FillRect(Graphics g, int x, int y, int width, int height, int color)
	{
	}

	public static void FillRect2(Graphics g, int x, int y, int width, int height, int color1, int color2)
	{
	}

	public static void FillRect3(Graphics g, int x, int y, int width, int height, int color1, int color2, int color3)
	{
	}

	public static void FillRect4(Graphics g, int x, int y, int width, int height, int color1, int color2, int color3, int color4)
	{
	}

	public static void FillRectShadow(Graphics g, int x, int y, int width, int height, int color1, int color2, int color3)
	{
	}

	public static void DrawObi(Graphics g, int x, int y, int width, int height, int color1, int color2)
	{
	}

	public static void DrawGradation(Graphics g, int dx, int dy, int sx, int sy, int w, int h, int sr, int sg, int sb, int dr, int dg, int db)
	{
	}

	public static void DrawBonusObi(Graphics g, int x, int y, int width, int height, int color1, int color2, int color3)
	{
	}

	public void DrawNumImage(Graphics g, int seb, long value, int x, int y)
	{
	}

	public void DrawNumImage(Graphics g, int seb, long value, int x, int y, int padding)
	{
	}

	public void DrawNumImage(Graphics g, int seb, long value, int x, int y, int padding, int anchor)
	{
	}

	public FormBase MakeErrorDialog()
	{
		return null;
	}

	public FormBase MakeErrorDialog(string msg, string args)
	{
		return null;
	}

	public static int[] DrawRandomFriend(Graphics g, int center, int top)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
