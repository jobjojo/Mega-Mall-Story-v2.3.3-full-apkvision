using form;
using java.lang;
using kairo.unity.surface;
using kairo.unity.ui;
using system.billing.ui;

namespace system.form;

public class BillingForm : MyFormBase, JRunnable
{
	public const int FORMID_BILLING = 900;

	public const int TYPE_MARKET_NOTES = 0;

	public const int TYPE_HTTP_CONNECT_ERR = 1;

	public const int TYPE_SHOP = 2;

	public const int TYPE_BILLING_ITEM = 3;

	public const int TYPE_RECEIVED_MARKET = 4;

	public const int TYPE_SHOP_CHOICE = 5;

	public int type_;

	private static readonly int[][] configData_;

	private int scrollValue_;

	public bool untilActiveHide_;

	private int select_;

	private int select2_;

	private int x_;

	private int y_;

	private int loopCounter_;

	private int frame_;

	private int page_;

	private int mode_;

	private TextLayout textLay_;

	public int value1_;

	public int value2_;

	public int value3_;

	private BillingForm bform_;

	public ApplyTask task_;

	public BillingItem item_;

	public BillingItem[] sales_;

	public string[] marketNotes_;

	private bool skipUpdateSales_;

	private string password_;

	public static bool admobSkipPurchase_;

	private const int SHOW_SALE_H = 6;

	private static int MAKET_ITEM_GET_END_FRAME;

	private static int MAKET_ITEM_GET_END_FRAME2;

	public int dialogId_;

	private const int THTYPE_GETLIST = 0;

	private const int THTYPE_PURCHASE = 1;

	private const int THTYPE_GIFT = 2;

	private int threadType_;

	private const int THSTATE_NONE = 0;

	private const int THSTATE_RUN = 1;

	private const int THSTATE_SUCCESS = 2;

	private const int THSTATE_FAILURE = 3;

	private int threadState_;

	private long threadBeginTime_;

	private int threadFrame_;

	private string error_;

	private JThread th_;

	private string[] gift_;

	internal const int RESBILLING_SEB_OWNER_L = 0;

	internal const int RESBILLING_SEB_OWNER_R = 1;

	internal const int RESBILLING_SEB_TICKET = 2;

	internal const int RESBILLING_SEB_TALK_ASSIST00R = 3;

	internal const int RESBILLING_SEB_TALK_ASSIST01R = 4;

	internal const int RESBILLING_SEB_FOUNDATION = 5;

	internal const int RESBILLING_SEB_JUMP_ASSIST00 = 6;

	internal const int RESBILLING_SEB_JUMP_ASSIST01 = 7;

	internal const int RESBILLING_SEB_GET = 8;

	internal const int RESBILLING_SEB_EFFECT00 = 9;

	internal const int RESBILLING_SEB_AD_OFF = 10;

	internal static ResourceManager resBilling_;

	private static int[] drawAdOffButtoan_result;

	public override string ToString()
	{
		return null;
	}

	public BillingForm()
		: base(0)
	{
	}

	public BillingForm(int type)
		: base(0)
	{
	}

	public BillingForm(int type, ApplyTask provide)
		: base(0)
	{
	}

	internal static void LoadResource()
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

	private void ScrollControl(int num, int showMax)
	{
	}

	public void ScrollUpdate(int num, int showMax)
	{
	}

	public void ScrollUpdate(int num, int showMax, int value)
	{
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

	public override bool CheckMainWindow()
	{
		return false;
	}

	public void SetSoftlabel()
	{
	}

	public void UpdateSaleList()
	{
	}

	public void ThreadStart(int type)
	{
	}

	public void Run()
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

	public new static string Comma(long value)
	{
		return null;
	}

	public static int[] DrawAdOffButtoan(Graphics g, int dx, int dy, int dw, int dh, int frame)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
