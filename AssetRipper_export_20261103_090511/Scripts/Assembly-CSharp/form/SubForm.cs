using data_kasa;
using game_kasa;
using java.util;
using kairo.unity.surface;
using kairo.unity.ui;
using kairo.unity.util;
using main;

namespace form;

public class SubForm : MyFormBase
{
	public static int touchBuildTab;

	public static int oldTouchBuildTab;

	public static int newTouchBuildTab;

	public static int main_menu_no;

	public static bool value_reset;

	public static int huwatype_;

	internal static readonly int ARROR_WIDTH;

	internal static readonly int NEW_ZURE_Y;

	private string err_method;

	private int err_line;

	private new AppData apdat_;

	private new Canvas canvas_;

	private new FormManager formMan_;

	private PlayerData p_data;

	public Property sysSave_;

	public const int TYPE_TALK = 0;

	public const int TYPE_DIALOG = 1;

	public const int TYPE_DIALOG_CHARA = 2;

	public const int TYPE_MAIN_MENU = 3;

	public const int TYPE_SETTING_MENU = 4;

	public const int TYPE_ACTION_MENU = 5;

	public const int TYPE_LIST_MENU = 6;

	public const int TYPE_INFO_MENU = 7;

	public const int TYPE_SYSTEM_MENU = 8;

	public const int TYPE_EVENT = 9;

	public const int TYPE_CONFIG = 10;

	public const int TYPE_MANUAL = 11;

	public const int TYPE_SAVE = 12;

	public const int TYPE_NEWS = 13;

	public const int TYPE_WAIT = 14;

	public const int TYPE_CLEARPOINT = 15;

	public const int TYPE_ENDING = 16;

	public const int TYPE_NO_MYMENU = 17;

	public const int TYPE_SAVE_MENU = 18;

	public const int TYPE_BUILD = 19;

	public const int TYPE_BUILD_INFO = 20;

	public const int TYPE_DESTRUCT = 21;

	public const int TYPE_DEPART_INFO = 22;

	public const int TYPE_DEPART_POLICY = 23;

	public const int TYPE_DEPART_POLICY_RANKUP = 24;

	public const int TYPE_DEPART_POLICY_EVENT_T = 25;

	public const int TYPE_DEPART_POLICY_CHANGE = 26;

	public const int TYPE_SPFLOOR_DICTIONARY = 27;

	public const int TYPE_SPFLOOR_DICTIONARY_TBUY = 28;

	public const int TYPE_TENANT_INFO = 29;

	public const int TYPE_TENANT_INFO_2 = 30;

	public const int TYPE_TENANT_INFO_BUILD = 31;

	public const int TYPE_TENANT_ALL = 32;

	public const int TYPE_TENANT_INCOME = 33;

	public const int TYPE_TENANT_LVUP = 34;

	public const int TYPE_TENANT_BONUS = 35;

	public const int TYPE_SKILL_ALL = 36;

	public const int TYPE_SKILL_EQUIP = 37;

	public const int TYPE_SKILL_EQUIPCHANGE = 38;

	public const int TYPE_SKILL_BUY_TOP = 39;

	public const int TYPE_SKILL_BUY = 40;

	public const int TYPE_SKILL_BUY_TENANT = 41;

	public const int TYPE_SKILL_BUY_SECRET = 42;

	public const int TYPE_SKILL_SELL = 43;

	public const int TYPE_SKILL_GET = 44;

	public const int TYPE_SERVICE_INTRODUCE = 45;

	public const int TYPE_SERVICE_INTRODUCE2 = 46;

	public const int TYPE_SERVICE_ONOFF = 47;

	public const int TYPE_SERVICE_CHANGE = 48;

	public const int TYPE_SERVICE_DEVELOP = 49;

	public const int TYPE_CUSTOMER_LIST = 50;

	public const int TYPE_CUSTOMER_APART_LIST = 51;

	public const int TYPE_CUSTOMER_REGULAR_INFO = 52;

	public const int TYPE_CUSTOMER_REGULAR_INFO_DEPART = 53;

	public const int TYPE_CUSTOMER_ITIGEN_INFO = 54;

	public const int TYPE_CUSTOMER_ITIGEN_INFO_DEPART = 55;

	public const int TYPE_AREA_TOP = 56;

	public const int TYPE_AREA_TOP2 = 57;

	public const int TYPE_AREA_ATTRACT = 58;

	public const int TYPE_AREA_INVEST_INFO = 59;

	public const int TYPE_AREA_INVEST_ADD = 60;

	public const int TYPE_AREA_INVEST_SALE = 61;

	public const int TYPE_AREA_LVUP = 62;

	public const int TYPE_AREA_CONST_SELECT = 63;

	public const int TYPE_AREA_BATTLE = 64;

	public const int TYPE_AREA_RIVAL_INFO = 65;

	public const int TYPE_CLERK_MANAGER = 66;

	public const int TYPE_CLERK_SELECT_INFO = 67;

	public const int TYPE_CLERK_INFO = 68;

	public const int TYPE_CLERK_INFO_DEPART = 69;

	public const int TYPE_SALE_RESULT = 70;

	public const int TYPE_SALE_RESULT_RANKUP = 71;

	public const int TYPE_ADVERTISE = 72;

	public const int TYPE_EVENT_EXPAND = 73;

	public const int TYPE_EVENT_NEWCUSTOMER = 74;

	public const int TYPE_EVENT_NEWREGULAR = 75;

	public const int TYPE_EVENT_NEWREGULAR_BONUS = 76;

	public const int TYPE_EVENT_RIVALAPPEAR = 77;

	public const int TYPE_EVENT_RIVALESCAPE = 78;

	public const int TYPE_EVENT_DEPART_RANKUP = 79;

	public const int TYPE_EVENT_PROJECT_WEATHER = 80;

	public const int TYPE_EVENT_PROJECT_BUSINESS = 81;

	public const int TYPE_MONTH_RANKUP = 82;

	public const int TYPE_TWITTED = 83;

	public int type_;

	private static readonly int[][] softLabels_;

	private const int MENU_BUILD = 0;

	private const int MENU_AREA = 1;

	private const int MENU_ACTION = 2;

	private const int MENU_INFO = 3;

	private const int MENU_SYSTEM = 4;

	private const int MENU_SHARE = 5;

	private const int MENU_BUYTENANT = 6;

	private const int MENU_CLERK = 7;

	private const int MENU_ADVERTISE = 8;

	private const int MENU_SALE = 9;

	private const int MENU_DEPART = 10;

	private const int MENU_INCOME = 11;

	private const int MENU_DICTONARY = 12;

	private const int MENU_STORE = 13;

	private const int MENU_CUSTOMER = 14;

	private const int MENU_RANKUP = 15;

	private const int MENU_SAVE = 16;

	private const int MENU_CONFIG = 17;

	private const int MENU_TUTORIAL = 18;

	private const int MENU_RANKING = 19;

	private const int MENU_EXIT = 20;

	private const int MENU_CONTINUE = 21;

	private const int MENU_NEWGAME = 22;

	private const int MENU_DELETE = 23;

	internal static readonly int CONFIG_QUALITY;

	internal static readonly int CONFIG_SPEED;

	internal static readonly int CONFIG_BGM;

	internal static readonly int CONFIG_SE;

	internal static readonly int CONFIG_CURRENCY;

	internal static readonly int CONFIG_ORIENTATION;

	internal static readonly string[] CONFIG_NAMES;

	internal static readonly string[][] CONFIG_VALUE_NAMES;

	internal static readonly int[] CONFIG_VALUES;

	internal static readonly bool[] CONFIG_VALUE_REVERSE;

	internal static readonly int[] CONFIG_VALUE_MAX;

	private static readonly string[] MENU_STR;

	public const string BUTTONSTR_HAI_IIE = "はい\tいいえ";

	private int scrollMaximum_;

	private int scrollValue_;

	public bool untilActiveHide_;

	private int select_;

	private int[] selectPosition_;

	private int x_;

	private int y_;

	private int loopCounter_;

	private int frame_;

	private int frame2_;

	private string name_;

	private TextLayout textLay_;

	private int[][] menus_;

	private string[] selectButtons_;

	public int value1_;

	public int value2_;

	private string text_;

	private string[] textAry_;

	private int textIdx_;

	private int pagesNum_;

	public int page_;

	public int humanCharaIndex_;

	private new SubForm dialog_;

	private SubForm dialog2_;

	private string talkArg_;

	private int nextIndex_;

	public int humanIndex_;

	public int buildFrame_;

	public int workerFrame_;

	public const int EVENT_HAPPY = 0;

	public const int EVENT_UNHAPPY = 1;

	public const int EVENT_SPECIAL = 2;

	public const int EVENT_END = 3;

	private int[] eventIds_;

	private int[] eventAnim_;

	private string[] eventTexts_;

	private int jingle_;

	private int[] EVENT_HAPPY_ANIME_OY;

	private int[] EVENT_SAD_ANIME_OY;

	private int saveState_;

	private const int NEWS_LINES = 6;

	private const int BCATEGORY_ENVIRONMENT = 0;

	private const int BCATEGORY_END = 3;

	public static int buildCategory_;

	private int[][][] buildList_;

	public int dialogId_;

	public new int result_;

	public int arg1_;

	public int arg2_;

	public int wait_;

	private int inputFig_;

	private static readonly int SC_MAINMENU_SELECT;

	private static readonly int SC_MAINMENU_NOTSELECT;

	public static readonly int SC_BUILD_TAB_SELECT;

	public static readonly int SC_BUILD_TAB_NOTSELECT;

	private static readonly int SC_BUILD_NAME;

	private static readonly int SC_BUILD_PRICE_BRACK;

	private static readonly int SC_BUILD_PRICE_RED;

	public static readonly int SC_WINDOW_TITLE;

	public static readonly int SC_WINDOW_BLACK;

	public static readonly int SC_WINDOW_RED;

	public static readonly int SC_WINDOW_BLUE;

	public static readonly int SC_WINDOW_SELECT;

	public static readonly int SC_WINDOW_GRAY;

	public static ChipModel temp_model;

	private static Vector model_v;

	private static Tenant tenant;

	private static readonly int[] TBONUS_ELEMENT_ID;

	private static readonly int[] TBONUS_IMG_ID;

	public static TenantData tenant_data;

	private static Vector service_v;

	private static Service serviceSelect_equip;

	private static Service service_change;

	private static Vector tenant_v;

	private static Vector spFloor_v;

	public static Vector customer_v;

	public static Vector nextCustomer_v;

	public Customer customer_select;

	public int human_id;

	private static bool[] temp_flgSetClerk;

	private static Vector clerk_v;

	public static Clerk clerk;

	private static ApartArea apart_area;

	private const int AREA_1BLOCK_W = 48;

	private const int AREA_NUM = 4;

	private static int[] AREA_CX;

	private static int[] AREAAPART_CX;

	public static int AREA_CAMERA_MOVE_FLG;

	private static int AREA_CAMERA_PX;

	private static int AREA_CAMERA_VX;

	private static int AREA_CAMERA_AX;

	private static int AREA_CAMERA_CNT;

	public static int AREA_CAMERA_MOVE_TIME;

	private static int AREA_CAMERA_GOAL_INDEX;

	public static int AREA_CURSOR_INIT_PY;

	public static int AREA_CURSOR_MOVE_DIS;

	public static int AREA_CURSOR_MOVE_TIME;

	public const int AREA_BLOCK_ADD_PRICE = 500;

	private const int ANIME_TIME_POLICY_R_TENANT = 40;

	private const int ANIME_TIME_APART_ATTRACT = 60;

	private const int ANIME_TIME_APART_LVUP = 60;

	private const int ANIME_TIME_EVENT_NEWREGULAR = 60;

	public JampObj tempAnime_jampObj;

	public int tempAnime_cnt;

	private static readonly int[] equipChange_animeTime;

	private static readonly int[] eventComeCustomer_animeTime;

	private static readonly int[] serviceDevelop_animeTime;

	private static readonly int[] saleResult_animeTime;

	private static readonly int[] saleRankUp_animeTime;

	public const int ANIME_DISP_MODE_NORMAL = 0;

	public const int ANIME_DISP_MODE_TENMETU = 1;

	public const int ANIME_DISP_MODE_CLIPLINE = 2;

	public const int ANIME_DISP_MODE_COUNTER = 3;

	public int[] mc_py;

	public int[] mc_initPy;

	public int[] mc_vy;

	public int[] mc_ay;

	public const int MC_INIT_PY1 = 1080000;

	public const int MC_INIT_PY1_2 = 1110000;

	public const int MC_INIT_PY2 = 1040000;

	public const int MC_INIT_PY2_2 = 1070000;

	public const int MC_INIT_PY3 = 940000;

	public const int MC_INIT_PY4 = 1200000;

	public const int MC_DIS = 80000;

	public const int MC_DIS3 = 80000;

	public const int MC_TIME = 10;

	public const int MC_TIME3 = 10;

	public const int MC_WAIT = 16;

	public int[] mc_time;

	public int[] mc_wait;

	public const int PARAM_INIT_PY = 0;

	public const int PARAM_DIS = 1;

	public const int PARAM_TIME = 2;

	public int[][] mc_init_param;

	public int[] temp_paramArray;

	public long touchInvalidTime_;

	internal string[] SKILLBUYTOP_ELEMENTNAME;

	private new const int WNDFLAG_LEFT_ARW = 1;

	private new const int WNDFLAG_RIGHT_ARW = 2;

	private new const int WNDFLAG_BOX = 4;

	private new const int WNDRET_TOP = 0;

	private new const int WNDRET_RIGHT = 1;

	private new const int WNDRET_BOTTOM = 2;

	private new const int WNDRET_LEFT = 3;

	private new const int WNDRET_BOX_TOP = 4;

	private new const int WNDRET_BOX_RIGHT = 5;

	private new const int WNDRET_BOX_BOTTOM = 6;

	private new const int WNDRET_BOX_LEFT = 7;

	private new const int WNDRET_BOX_END = 8;

	private int[] drawWindow_tmp;

	private Vector3D update_tmp1;

	private static Vector tBonusInfo_v;

	private const int TBONUSINFO_SPFLOOR = 0;

	private const int TBONUSINFO_CLERK = 1;

	private const int TBONUSINFO_SALE = 2;

	private const int TBONUSINFO_SETUP = 3;

	private const int TBONUSINFO_LIKEFLOOR = 4;

	private const int TBONUSINFO_FLOOR = 5;

	private const int TBONUSINFO_DISPNUM = 6;

	private const int TBONUSINFO_ADDMODE_ADD = 0;

	private const int TBONUSINFO_ADDMODE_PARSENT = 1;

	internal string[] DIFFICULT_MESSAGE;

	public const int C_WAIT = 15;

	public const int CLEARPOINT_MODE_INIT = 0;

	public const int CLEARPOINT_MODE_NAME = 1;

	public const int CLEARPOINT_MODE_CPOINT = 2;

	public const int CLEARPOINT_MODE_SCORE = 3;

	public const int CLEARPOINT_MODE_HIGHSCORE = 4;

	public const int CLEARPOINT_MODE_NEXT = 5;

	public const int CLEARPOINT_MODE_RESULT = 6;

	public const int CLEARPOINT_MODE_END = 7;

	public int clearPoint_mode;

	public int clearPoint_cnt;

	public int clearPoint_index;

	public int CLEARPOINT_ELEMENT_MAX;

	public static readonly int[] CLEARPOINT_ANIMETIME;

	public long clearPoint_score;

	public long clearPoint_highScore;

	public const int MANUAL_PANEL_NUM = 26;

	public const int MANUAL_DIS = 25700;

	public const int MANUAL_TIME = 1200;

	public const int MANUAL_V = 21;

	public int manual_bus_px;

	public static readonly int[][] MANUAL_PERSON_POS;

	public static int touchHowaLightFrame_;

	private readonly string[] areaName_;

	private readonly string[] strSaleBusiness_;

	public override string ToString()
	{
		return null;
	}

	public void SetParam_miniC(int index, int[] param)
	{
	}

	public void SetParam_miniC(int index, int param1, int param2, int param3)
	{
	}

	public void Init_miniC(int index)
	{
	}

	public void Update_miniC(int index)
	{
	}

	public void Draw_miniC(Graphics g, int index, int dx)
	{
	}

	public void Draw_miniC_sad(Graphics g, int index, int dx)
	{
	}

	public SubForm()
		: base(0)
	{
	}

	public SubForm(int type)
		: base(0)
	{
	}

	public SubForm(int type, int value1)
		: base(0)
	{
	}

	public SubForm(int type, int x, int y)
		: base(0)
	{
	}

	public void InitDialog(string text, string buttons)
	{
	}

	public static SubForm MakeDialog(string text, string buttons)
	{
		return null;
	}

	public static SubForm MakeDialog(string text)
	{
		return null;
	}

	public static SubForm MakeDialog(string text, string buttons, int defaultSelect)
	{
		return null;
	}

	public static SubForm MakeNoMymenu(string text)
	{
		return null;
	}

	public static SubForm MakeWait(int wait)
	{
		return null;
	}

	public static SubForm MakeShareWindow(int type)
	{
		return null;
	}

	public static SubForm MakeTalkForm(int msgId, string arg)
	{
		return null;
	}

	public static SubForm MakeTalkForm(int characterIndex, string text, string arg)
	{
		return null;
	}

	public static SubForm MakeEvent(string var_event, string arg)
	{
		return null;
	}

	public static SubForm MakeNews(int id, string arg)
	{
		return null;
	}

	public void SetTenant(Tenant in_tenant)
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

	private void _draw4(Graphics g)
	{
	}

	private void _draw5(Graphics g)
	{
	}

	private void _draw6(Graphics g)
	{
	}

	private void _draw7(Graphics g)
	{
	}

	private void _draw2(Graphics g)
	{
	}

	private void _draw8(Graphics g)
	{
	}

	private void _draw9(Graphics g)
	{
	}

	private void _draw10(Graphics g)
	{
	}

	private void _draw3(Graphics g)
	{
	}

	internal override int[] DrawWindow(Graphics g, int width, int height, string title, int sideSpace, int topSpace, int bottomSpace, int barArwSpace, int flag)
	{
		return null;
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

	private bool Update2()
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

	private void DrawScroll(Graphics g, int[] wnd, int num, int showMax, int expand)
	{
	}

	public static void DrawScroll(Graphics g, int x, int y, int w, int h, int num, int showMax, int expand, int selectValueType)
	{
	}

	public static void DrawScrollPage(Graphics g, int x, int y, int w, int h, int num, int showMax, int expand, int selectValueType)
	{
	}

	private void DrawHorizontalScroll(Graphics g, int[] wnd, int y, int num, int showMax)
	{
	}

	private void AddMenu(int menuId, int state)
	{
	}

	private void DrawMenu(Graphics g, int type)
	{
	}

	private int[] FrameMenu()
	{
		return null;
	}

	private int[] FrameMenu(int backResult)
	{
		return null;
	}

	private void SetEvent(int index)
	{
	}

	public void DrawInputValue(Graphics g, int right, int top, int value, bool inputMode, bool active, int color, int fig)
	{
	}

	public bool IsMenu()
	{
		return false;
	}

	public bool IsSpecialWindow()
	{
		return false;
	}

	public new static int GetBoxHeaderY(int boxTop)
	{
		return 0;
	}

	public new static int GetBoxFooterY(int boxBottom)
	{
		return 0;
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

	private void DrawMeter(Graphics g, int x, int y, int value, int max)
	{
	}

	private void DrawMeter(Graphics g, int x, int y, int value, int max, int scaleNum)
	{
	}

	private void DrawMeter(Graphics g, int x, int y, int value, int max, int scaleNum, bool rev)
	{
	}

	public void Update_areaCamera()
	{
	}

	public void Regist_areaCamera()
	{
	}

	public void Ch_areaLvUp()
	{
	}

	public static void SetAreaPosData()
	{
	}

	public void Draw_equipParam(Graphics g, int dx, int dy, int param)
	{
	}

	public int[] GetItemSub(Service select_item, Service nowEquip_item)
	{
		return null;
	}

	public int[] GetTenantBaseParam(ChipModel model, int lv)
	{
		return null;
	}

	public int[] GetTenantParamLv(TenantData t_data, int lv)
	{
		return null;
	}

	public bool ChTenantBonus(TenantData t_data, int param_index)
	{
		return false;
	}

	public void Draw_paramEffect(Graphics g, int dx, int dy, int mode, int value, int[] param)
	{
	}

	public void Draw_paramEffect(Graphics g, int dx, int dy, int mode, int value, int[] param, bool flg_sign, int seb_id)
	{
	}

	public void Draw_areaTop(Graphics g)
	{
	}

	public void Draw_areaTop2(Graphics g)
	{
	}

	public void Draw_areaRivalInfo(Graphics g)
	{
	}

	private void Init_tenantBonusInfo()
	{
	}

	private void Draw_tenantBonusInfo(Graphics g)
	{
	}

	private void Draw_tenantBonusInfoParam2(Graphics g, int oy, int add_mode, string str1, int p1, string str2, int p2)
	{
	}

	private void Draw_tenantBonusInfoParam1(Graphics g, int oy, int add_mode, string str1, int p1)
	{
	}

	public void SetApartAreaProject_pp()
	{
	}

	public int GetRateServiceIntroduce(Service service, TenantData t_data)
	{
		return 0;
	}

	public string GetStrServiceIntroduce(Service service, TenantData t_data)
	{
		return null;
	}

	public void SetSoftLabel_serviceOnOff(TenantData t_data, int select_)
	{
	}

	public void Update_clearPoint()
	{
	}

	public void Draw_clearPoint(Graphics g)
	{
	}

	public static void CreateCustomerList(int set_mode)
	{
	}

	public int GetHumanId(int c_id)
	{
		return 0;
	}

	public void SetNextComeCustoemr(int area_number)
	{
	}

	public void Draw_manual(Graphics g)
	{
	}

	public void DrawStar(Graphics g, int x, int y, int subform_frame)
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

	public static void DrawHowaLight(Graphics g, int x, int y, int width, int height)
	{
	}

	public int GetStringLength(Graphics g, string name)
	{
		return 0;
	}

	public void SetSelect(int no)
	{
	}

	public static void DrawStringBold_colorAndFontSizeAndWidth(Graphics g, string str, int ox, int oy, int ow, int color1, int color2, int fontSize, int anchor, int outlineQuality = -1, float outlineWidth = float.NaN)
	{
	}

	public static void SetStringBoldOutline(int outlineQuality, float outlineWidth)
	{
	}

	public void DrawIconTenantMath(Graphics g, int dx, int dy, int sx, int sy, int width, int height, int size)
	{
	}

	public void DrawIconRegularBonus01(Graphics g, int dx, int dy)
	{
	}

	public void DrawLvUp(Graphics g, int dx, int dy)
	{
	}

	public void DrawLv(Graphics g, int dx, int dy)
	{
	}

	public void DrawNew(Graphics g, int dx, int dy)
	{
	}

	public void DrawIconUp(Graphics g, int dx, int dy)
	{
	}

	public void DrawRankUpCon(Graphics g, int dx, int dy)
	{
	}

	public void DrawComeFan(Graphics g, int dx, int dy)
	{
	}

	public void DrawRivalDepartUsing(Graphics g, int dx, int dy)
	{
	}

	public static void DrawTenantBonus(Graphics g, AppData apdat, int dx, int dy, bool icon = true)
	{
	}

	public void DrawAreaName(Graphics g, int dx, int dy, int frame, int anchor)
	{
	}

	public void DrawBusiness(Graphics g, int dx, int dy, int addX, int id)
	{
	}

	public void DrawIconProject(Graphics g, int dx, int dy, int value)
	{
	}

	public void DrawTenantInfo(Graphics g, int dx, int dy, int value)
	{
	}

	public void DrawNumTime(Graphics g, int dx, int dy)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool CheckMainWindow()
	{
		return false;
	}
}
