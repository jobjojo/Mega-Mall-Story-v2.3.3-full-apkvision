using data_kasa;
using game_kasa;
using java.util;
using kairo.unity.graphics;
using kairo.unity.surface;
using kairo.unity.ui;
using kairo.unity.util;
using main;

namespace form;

public class TestForm : MyFormBase
{
	public static int tenantAllNow;

	public static int eff_alpha;

	public static int touchEffectTime;

	public static bool mode_sale_now;

	public static int mode_sale_hanabi;

	public static int mode_hanabi_tenant;

	public static Human_K before_select;

	public static Human_K select;

	public static bool screenOut;

	public static int camera_adjust;

	public static int touchBuildSize_;

	public int touchBuildX_;

	public static bool padTouchNow_;

	public static bool touchReadyBuild_;

	public static bool build_OK;

	public int[] touch_address;

	public bool pinch_now;

	public static int touchXNow;

	public static int touchYNow;

	public static int mapchipScaleCount_;

	public static int alpha2_;

	private new AppData apdat_;

	public new static Canvas canvas_;

	private new FormManager formMan_;

	private PlayerData p_data;

	public static Camera camera;

	public const int STATE_MAIN = 0;

	public const int STATE_BUILD = 1;

	public const int STATE_BUILD_ROAD = 2;

	public const int STATE_DESTRUCT = 3;

	public const int STATE_TENANTMOVE = 4;

	public const int STATE_SALE = 5;

	public const int STATE_HINT_ON = 6;

	public const int STATE_HINT_OFF = 7;

	public const int STATE_CAPTURE = 8;

	public const int STATE_CAPTURE_EXE = 9;

	public static int state_;

	private static readonly int[][] softLabels_;

	public int buildNo_;

	private int constructBlinkWait_;

	public int buildEffectX_;

	public int buildEffectY_;

	public int buildEffectWait_;

	private int buildTouchFrame_;

	private new SubForm dialog_;

	private SubForm menu_;

	private int frame_;

	private int dislog_addressX;

	private int dislog_addressY;

	public Human_K focus_;

	private int focusWait_;

	public Human_K catchHuman_;

	public Map catchMapChip_;

	private int catchFrame_;

	private int catchStartCursorX_;

	private int catchStartCursorY_;

	public string newGameName_;

	public int newGameFrame1_;

	public int newGameFrame2_;

	public static int scale_;

	public float pinchScaleValue_;

	public const int PINCH_SACLE_PADDING = 40;

	public const int GOBJTYPE_FUKIDASHI = 0;

	public const int GOBJTYPE_FUKIDASHI2 = 1000;

	public const int GOBJTYPE_HUMAN_ALL = 1;

	public const int GOBJTYPE_HUMAN = 2;

	public const int GOBJTYPE_MAPCHIP = 3;

	public const int GOBJTYPE_GAME = 4;

	public const int GOBJTYPE_COM_IMG = 5;

	public const int GOBJTYPE_COM2_IMG = 6;

	public const int GOBJTYPE_COM2_SEB = 7;

	public const int GOBJTYPE_VEHICLE = 8;

	public const int GOBJTYPE_HUMAN_EF_GAGE = 9;

	public const int GOBJTYPE_HUMAN_EF_HEART = 10;

	public const int GOBJTYPE_TENANT_RECT = 11;

	public const int GOBJP_TYPE = 0;

	public const int GOBJP_ID = 1;

	public const int GOBJP_DEPTH = 2;

	public const int GOBJP_IMG = 3;

	public const int GOBJP_SEB = 4;

	public const int GOBJP_FRAME = 5;

	public const int GOBJP_X = 6;

	public const int GOBJP_Y = 7;

	public const int GOBJP_DARK = 8;

	public const int GOBJP_LAYER = 9;

	public const int GOBJP_END = 10;

	private int gameObjectPoolIndex_;

	private int[][] gameObjectPool_;

	public const int GOBJDEPTH_VEHICLE_BACK = 0;

	public const int GOBJDEPTH_VEHICLE = 10;

	public const int GOBJDEPTH_ROAD_1F = 11;

	public const int GOBJDEPTH_TENANT = 15;

	public const int GOBJDEPTH_TENANT2 = 35;

	public const int GOBJDEPTH_ROUTE = 40;

	public const int GOBJDEPTH_STAIR = 45;

	public const int GOBJDEPTH_BUILD = 48;

	public const int GOBJDEPTH_HUMAN = 50;

	public const int GOBJDEPTH_ESCALATOR2 = 305;

	public const int GOBJDEPTH_FUKIDASHI = 310;

	public const int GOBJDEPTH_MONEY = 320;

	private const int ZSORT_PADDING = 120;

	private const int MAX_Z_PARALLEL = 10;

	private int zsortObjectStart_;

	private int zsortObjectLast_;

	private byte[] zsortObjectCount_;

	private int[][] zsortObjects_;

	private int buildRoadStartX_;

	private int buildRoadStartY_;

	public int step_direct;

	public int cost_buildRoad;

	public int old_cursor_x;

	public int old_cursor_y;

	public long proc_time;

	public long draw_time;

	public const int BOTTOM_INFO_BAR = 22;

	public const int VIEW_X = 0;

	public const int VIEW_Y = 22;

	public static int VIEW_W;

	public static int VIEW_H;

	public const int TOPHELP_CNT = 60;

	private int topHelp_cnt;

	private string topHelp_str;

	public const int SCR_EVENT = 0;

	public const int SCR_WAIT = 1;

	public const int SCR_SCENE = 2;

	public const int SCR_SPECIAL = 3;

	public Vector script_;

	public bool buildTrackX_;

	public bool buildTrachY_;

	public static bool isBuildTrack_;

	public int buildDownX_;

	public int buildDownY_;

	public bool buildLock_;

	public int touchBuildDragFrame_;

	public int touchBuildDragFrame2_;

	public bool touchSkip_;

	public bool autoSave_;

	public const int DLGID_TESTLIMIT = 100;

	public int saveGameViewX_;

	public int saveGameViewY_;

	public int saveViewX_;

	public int saveViewY_;

	public static Offscreen imgOffscreen;

	private Vector3D _update_tmp1;

	private int offscreenDayTime_;

	private string offscreenDayTimeString_;

	private long offscreenMoney_;

	private string offscreenMoneyString_;

	private int offscreenFloor_;

	private string offscreenFloorString_;

	private static bool flg_allDraw;

	private bool flg_updateBottomBar;

	public const bool DRAW_NEWVER = true;

	public int btmMessage_cnt;

	public static readonly int[] BTMMESSAGE_ANIME;

	public int btmMessage_chNumTenant;

	public int btmMessage_chNumCustomer;

	private string[] btmMessage;

	private long lastPinchTime_;

	internal Vector3D touchCameraSpeed_;

	internal Vector3D touchCameraDecimal_;

	internal FastVector touchCameraPoint_;

	internal bool touchDragCamera_;

	public static bool touchBuildDrag_;

	private int[] getScaleRange_tmp;

	private bool captured_;

	private int qualityBackup_;

	private int drawWallBackup_;

	private int adBackup_;

	private bool unlockShare_;

	private static bool sc_createing_;

	private long nextTime_;

	private int fpsCount_;

	private int skipFps_;

	private int fpsAveFocus_;

	private int[] fpsAve_;

	private bool frameSkip_;

	private int aveFps_;

	private int skipCount_;

	private int frameSkipCount_;

	private int[] frameSkipList_;

	public override string ToString()
	{
		return null;
	}

	public TestForm()
		: base(0)
	{
	}

	public override bool Init()
	{
		return false;
	}

	public int[] GetFirstScript()
	{
		return null;
	}

	public void ClearScript()
	{
	}

	public void AddCommandWait(int wait)
	{
	}

	public void AddCommandEvent(int evtId)
	{
	}

	public void AddCommandScene(int on)
	{
	}

	public void AddCommandSpecial(int[] arg)
	{
	}

	public void Script()
	{
	}

	public override bool Update()
	{
		return false;
	}

	private bool _update(int frameCount, bool skip)
	{
		return false;
	}

	public void DrawPermanent(Graphics g)
	{
	}

	public void UpdateOffscreenTopBar(Graphics g)
	{
	}

	public void UpdateOffscreenBottomBar(Graphics g, bool flg_fouceUpdate)
	{
	}

	public void UpdateOffscreen()
	{
	}

	public void SetAllDraw()
	{
	}

	public void SetBottomBarDraw()
	{
	}

	public override void Draw(Graphics g)
	{
	}

	public void _draw_newVer(Graphics g)
	{
	}

	public void InitOffscreen()
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

	public void ChangeState(int state)
	{
	}

	public void SetStateSoftLabel(int state)
	{
	}

	public bool BuildMode(int no)
	{
		return false;
	}

	public bool DestructMode()
	{
		return false;
	}

	public bool TenantMoveMode()
	{
		return false;
	}

	public bool TenantMoveMode2(int no)
	{
		return false;
	}

	public void InsertGameObject(int type, int id, int depth, int img, int seb, int frame, int x, int y, bool dark, int layer)
	{
	}

	private void DrawZSortObjects2(Graphics g)
	{
	}

	private void DrawZSortObjects2(Graphics g2, bool alpha)
	{
	}

	private void ClearZSortObjects()
	{
	}

	public bool ChPutRouteStart(ChipModel model, int address_x, int address_y, bool message)
	{
		return false;
	}

	public bool ChPutRoute(ChipModel buildModel, int start_x, int start_y, int end_x, int end_y, bool message)
	{
		return false;
	}

	public bool ChPutTenant(ChipModel model, int address_x, int address_y, bool message)
	{
		return false;
	}

	public bool ChPutSaleMark(int address_x, int address_y, bool message)
	{
		return false;
	}

	public void SetPutTenantRect(int model_id)
	{
	}

	public void SetPutRoadRect(ChipModel model, int address_x, int address_y)
	{
	}

	public void ClearTenantRect()
	{
	}

	public void Proc_destructTenantSpace(int tenantSpace_id, int address_x, int address_y)
	{
	}

	public void Proc_destructTenantSpace(int tenantSpace_id, int address_x, int address_y, bool flg_tenantMove)
	{
	}

	public void Proc_connectionElevator(ChipModel buildModel, int start_x, int start_y, int end_x, int end_y)
	{
	}

	public void Ch_cursorNo()
	{
	}

	public int GetBuildRoadCost(ChipModel model, int start_x, int start_y, int end_x, int end_y)
	{
		return 0;
	}

	public void ProgressTime(int add, int frameCount)
	{
	}

	public bool Ch_DrawMiddleWindow()
	{
		return false;
	}

	public int GetMiddleWindowMode()
	{
		return 0;
	}

	public void Draw_hishoTalk(Graphics g)
	{
	}

	public void Draw_hishoTalk(Graphics g, string message)
	{
	}

	public void Regist_topHelp(string str)
	{
	}

	public void Regist_topHelp(string str, int wait)
	{
	}

	public void Update_topHelp()
	{
	}

	public void Draw_topHelp(Graphics g)
	{
	}

	public void Proc_build(ChipModel model, int address_x, int address_y, int price)
	{
	}

	public void Update_btmMessage()
	{
	}

	public int GetAnimeId(int anime_cnt)
	{
		return 0;
	}

	public int GetAnimeScrollCnt(int anime_cnt)
	{
		return 0;
	}

	private void Draw_btmMessage(Graphics g)
	{
	}

	public void Regist_middleWindow()
	{
	}

	public void Regist_saleWindow()
	{
	}

	private void Update_middleWindow()
	{
	}

	private void Draw_middleWindow(Graphics g)
	{
	}

	public void Move_tenant(int body_x, int body_y, int next_body_x, int next_body_y)
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

	public void OnTouchCamera(int type, int v, TouchEvent e)
	{
	}

	private Human_K GetHuman()
	{
		return null;
	}

	internal Human_K GetHuman(int x, int y)
	{
		return null;
	}

	internal Human_K GetHuman(int x, int y, int px, int py)
	{
		return null;
	}

	public void SetCameraPosition(float x, float y)
	{
	}

	public void SetCameraPosition(int x, int y)
	{
	}

	private int[] GetScaleRange()
	{
		return null;
	}

	private int GetScaleMin()
	{
		return 0;
	}

	private int GetScaleMax()
	{
		return 0;
	}

	private void SetScale(int scale)
	{
	}

	public static int GetGameWidth()
	{
		return 0;
	}

	public static int GetGameHeight()
	{
		return 0;
	}

	public void SetCursor(int x, int y)
	{
	}

	public int GetViewOffsetX()
	{
		return 0;
	}

	public int GetViewOffsetY()
	{
		return 0;
	}

	private bool CheckTouchCell(int xi, int yi, int tx, int ty)
	{
		return false;
	}

	internal void ShowTouchArrow(Graphics g)
	{
	}

	internal void DrawBtmMessage(Graphics g)
	{
	}

	internal void ShowDepartNinki(Graphics g, int bottom_w)
	{
	}

	internal void ShowCursorNo(Graphics g, int x, int y)
	{
	}

	internal void DrawBuildEffect(Graphics g)
	{
	}

	public int ZureX()
	{
		return 0;
	}

	public int ZureY()
	{
		return 0;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public Offscreen MyCreateOffscreen()
	{
		return null;
	}

	private void GetLayoutMethod(out int width, out int height, out Image.Format format, out Image.Filter filterMode)
	{
		width = default;
		height = default;
		format = default;
		filterMode = default;
	}

	private bool DynamicRender(Graphics g, Offscreen offscreen)
	{
		return false;
	}

	public void CaptureMode(int unlock_type)
	{
	}

	private void Capture()
	{
	}

	private void FinishCapture()
	{
	}

	private bool isCaptureState()
	{
		return false;
	}

	public void InitFpsBoost()
	{
	}

	public int GetFpsSkipNum()
	{
		return 0;
	}

	public bool CheckFpsBoost()
	{
		return false;
	}
}
