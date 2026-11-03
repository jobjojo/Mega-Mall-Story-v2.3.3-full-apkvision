using data_kasa;
using java.io;
using java.util;
using kairo.unity.ui;
using main;

namespace game_kasa;

public class Human_K
{
	private static AppData apdat_;

	private static Canvas canvas_;

	private PlayerData p_data;

	public const int SCR_MOVE = 0;

	public const int SCR_WAIT = 1;

	public const int SCR_MOVE_ROUTE = 2;

	public const int SCR_STEP_UP = 3;

	public const int SCR_STEP_UP_MAIN = 4;

	public const int SCR_STEP_DOWN = 5;

	public const int SCR_STEP_DOWN_MAIN = 6;

	public const int SCR_ELEVATOR_IN = 7;

	public const int SCR_ELEVATOR_OUT = 8;

	public const int SCR_ELEVATOR_USE = 9;

	public const int SCR_ENTRANCE_IN_PRI = 10;

	public const int SCR_ENTRANCE_IN = 11;

	public const int SCR_ENTRANCE_OUT = 12;

	public const int SCR_TENANT_LINE_PRI = 13;

	public const int SCR_TENANT_LINE = 14;

	public const int SCR_TENANT_USE_TERMINAL = 15;

	public const int SCR_TENANT_USE_BUYITEM = 16;

	public const int SCR_TENANT_USE_DINNER = 17;

	public const int SCR_TENANT_USE_TOLET = 18;

	public const int SCR_TENANT_USE_REST = 19;

	public const int SCR_TENANT_USE_PLAY = 20;

	public const int SCR_TENANT_USE_REFRESH = 21;

	public const int SCR_TENANT_USE_ADMIRE = 22;

	public const int SCR_TENANT_USE_REGI = 23;

	public const int SCR_TENANT_USE_OLD = 24;

	public const int SCR_TENANT_OUT = 25;

	public const int SCR_DRIVE_ROUTE = 26;

	public const int SCR_MOVE_IMPOSSIBLE = 27;

	public const int SCR_MOVE_IMPOSSIBLE_GROUND = 28;

	public const int SCR_GET_HAPPY = 29;

	public const int SCR_GET_HEART = 30;

	public const int SCR_FUKIDASHI2 = 31;

	public const int SCR_USEREGI = 32;

	public const int SCR_JAMP = 33;

	public const int SCR_SEARCH_ROUTE = 34;

	public const int SCR_CLERK_ACTION = 35;

	public const int SCR_MOVE_TENANT_CENTER = 36;

	private int insertScriptIndex_;

	public int flg_exist;

	public int id;

	public int frame;

	public Vector script_;

	public Vector route_data;

	public Vector3D pos;

	public Vector3D old_pos;

	public Vector3D g_pos;

	public Vector3D screen_pos;

	public Vector3D v;

	public Vector3D a;

	public Vector3D elevatorOut_pos;

	public int flg_anime;

	public int cnt_anime;

	public int flg_move;

	public int seb_id;

	public int img_id;

	public int floor_number;

	public int[] address;

	public int[] goal_address;

	public int goal_tenantId;

	public int wait_elevatorOut;

	public int item_bag;

	public int mpoint_index;

	public int entrance_direct;

	private int flg_fukidashi;

	private int cnt_fukidashi;

	private int wait_fukidashi;

	private int id_fukidashi;

	public int getHappyPoint;

	public int cnt_getHappyPoint;

	public bool flg_getHappyPoint;

	public int disp_heartEfPoint;

	public int cnt_getHeartPoint;

	public bool flg_getHeartPoint;

	public int heart_getNum;

	public bool heart_overLine;

	public int c_data_id;

	public Customer c_data;

	public int clerk_id;

	public int clerk_afterActBonus;

	public int inTenant_buyNum;

	public int[] inTenant_buyList;

	public int inTenant_buyIndex;

	public const int INTENANT_BUYITEM_MAX = 15;

	public int hashigo_cnt;

	public int hashigo_useCommonFlor;

	public bool flg_disp;

	public const int ANIME_WALK = 1;

	public const int ANIME_DIRECT = 2;

	public const int ANIME_USEREGI = 4;

	public const int ANIME_JAMP = 8;

	public const int ANIME_CLERKACT = 16;

	public const int ANIME_TEATIME = 32;

	public const int ANIME_GETITEM = 64;

	public const int ANIME_ROTATE = 128;

	public const int ANIME_TOLET = 256;

	public const int ANIME_REST = 512;

	public const int ANIME_REFRESH = 1024;

	public const int ANIME_ADMIRE = 2048;

	public const int FLG_RETURNROUTE = 1;

	public const int FLG_HASHIGO = 2;

	public const int FLG_MOVE_IMPOSSIBLE = 4;

	public const int FLG_ELEVATOR_IN = 8;

	public const int FLG_ELEVATOR_HIDE_BACK = 16;

	public const int FLG_ELEVATOR_OUT_CLO = 32;

	public const int FLG_ELEVATOR_OUT_GO = 64;

	public const int FLG_ESCALATOR_USE = 128;

	public const int FLG_BUY = 256;

	public const int FLG_SHOPPING_BAG = 512;

	public const int FLG_NODISP_BAG = 1024;

	public const int FLG_SHOPPING_CAGO = 2048;

	public const int FLG_SHOPPING_TABLE = 4096;

	public const int FLG_STAIR_USE = 8192;

	public const int ITEM_BAG_NUM = 4;

	public static int GET_HAPPY_TIME_P1;

	public static int GET_HAPPY_TIME_P2;

	public static int GET_HAPPY_TIME_P3;

	public static int GET_HAPPY_TIME_P4;

	public static int GET_HAPPY_END_TIME;

	public static int GET_HAPPY_H;

	public static int GET_HAPPY_WAIT;

	public static int GET_HEART_END_TIME;

	public static int GET_HEART_HEART_STOP;

	public static int GET_HEART_AFTER;

	public static int GET_HEART_WAIT;

	public const int DRAW_MODE_DRAW = 0;

	public const int DRAW_MODE_ZSORT = 1;

	public const int DRAW_MODE_H_ZSORT = 2;

	public static int ANIME_USEREGI_TIME_P1;

	public static int ANIME_USEREGI_TIME_P2;

	public static int ANIME_JAMP_TIME;

	public static int ANIME_JAMP_DIS;

	public static int ANIME_JAMP_NUM;

	public static int ANIME_JAMP_WAIT;

	public static int ANIME_JAMP_RATE;

	public static int CLERKACT_RATE;

	public static int CLERKACT_FRAME;

	public static int CLERKACT_NUM;

	public JampObj jamp_obj;

	public int ef_tenantItem_index;

	public const int EF_TENANTITEM_NUM = 10;

	public EffectObj[] ef_tenantItem;

	public int flg_tuseHNum;

	public bool flg_hitCursor;

	private int[] move_tmp1;

	private Vector3D move_tmp2;

	private Vector3D move_tmp3;

	private Vector3D move_tmp4;

	private Vector3D move_tmp5;

	private Vector3D move_StepUpMain_tmp1;

	private Vector3D move_StepUpMain_tmp2;

	private Vector3D move_StepDownMain_tmp1;

	private Vector3D move_StepDownMain_tmp2;

	private Vector3D move_elevatorIn_tmp1;

	private Vector3D move_elevatorOut_tmp1;

	private Vector3D move_elevatorOut_tmp2;

	private Vector3D move_elevatorUse_tmp1;

	private Vector3D move_elevatorUse_tmp2;

	private Vector3D move_entranceIn_tmp1;

	private Vector3D move_entranceOut_tmp1;

	private Vector3D move_tenantLine_tmp1;

	private Vector3D move_tenantOut_tmp1;

	private Vector3D move_tenantUseTerminal_tmp1;

	private int imPossible_cnt;

	private Vector3D proc_moveTenantCenter_tmp1;

	internal int startWorkWait_;

	public short[][] getInterestChips_tmp_;

	private int[] draw_chInsert;

	private int[] draw_tmp1;

	private Vector3D draw_tmp2;

	internal int[][] HEART_IMG_RECT;

	internal int[] HEART_IMG_OY;

	private int[] heart_screenPos;

	private int[] draw_debug_tmp;

	public static readonly int[] CLERK_ACT_RAND;

	private Vector3D setGoalPos_tmp1;

	private Vector3D proc_tenantUse_tmp1;

	public const int GET_TYPE_SPD_VX = 1;

	public const int GET_TYPE_SPD_V_ELSE = 2;

	public const int GET_TYPE_SPD_TENANT_IN = 3;

	public const int GET_TYPE_SPD_TENANT_OUT = 4;

	public const int GET_TYPE_SPD_ANIME_TIME = 5;

	public const int GET_TYPE_SPD_STAIR1 = 6;

	public const int GET_TYPE_SPD_STAIR2 = 7;

	public const int GET_TYPE_SPD_ESCALATOR = 8;

	public const int GET_TYPE_SPD_ELEVATOR = 9;

	public Human_K(int id)
	{
	}

	public void Script()
	{
	}

	public void ClearScript()
	{
	}

	public void AddCommandMove(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandMove2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandStepUp(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandStepUp2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandStepUpMain(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandStepUpMain2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandStepDown(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandStepDown2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandStepDownMain(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandStepDownMain2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandElevatorIn(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandElevatorIn2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandElevatorOut(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandElevatorOut2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandElevatorUse(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandElevatorUse2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandEntranceInPri(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandEntranceInPri2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandEntranceIn(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandEntranceIn2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandEntranceOut(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandEntranceOut2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantLinePri(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantLinePri2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantLine(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantLine2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantOut(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantOut2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUseTerminal(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUseTerminal1(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_buyItem(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_buyItem2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_dinner(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_dinner2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_tolet(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_tolet2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_rest(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_rest2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_play(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_play2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_refresh(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_refresh2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_admire(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUse_admire2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUseRegi(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUseRegi2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUseOld(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandTenantUseOld2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandDriveRoute(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandMoveImpossible(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandMoveImpossibleGround(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandGetHappy(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandGetHeart(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandFukidashi(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandUseRegi(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandJamp(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandSearchRoute(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandClerkAction(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandClerkAction2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandMoveTenantCenter(int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandMoveTenantCenter2(int insertIndex, int address_x, int address_y, int eva_speed)
	{
	}

	public void AddCommandMoveRoute(int x, int y, int rapid, int offset)
	{
	}

	public void AddCommandMoveRoute(int[] pos, int rapid, int offset)
	{
	}

	public void AddCommandWait(int wait, bool flg_disp)
	{
	}

	public void AddCommandWait(int wait)
	{
	}

	public void AddCommand(int[] script)
	{
	}

	public bool Move(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_toStepUp(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_StepUpMain(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_toStepDown(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_StepDownMain(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_elevatorIn(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_elevatorOut(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_elevatorUse(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_entranceInPri(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_entranceIn(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_entranceOut(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantLinePri(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantLine(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantOut(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantUseOld(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantUseTerminal(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantUse_buyItem(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantUse_dinner(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantUse_tolet(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantUse_rest(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantUse_play(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantUse_refresh(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantUse_admire(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_tenantUseRegi(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_driveRoute(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_imPossible(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Move_imPossibleGround(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Update_getHappyPoint()
	{
		return false;
	}

	public bool Update_getHeartPoint()
	{
		return false;
	}

	public void Regist_getHeartPoint(int in_disp_efPoint)
	{
	}

	public bool Proc_fukidashi(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Proc_jamp(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Proc_searchRoute(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Proc_clerkAction(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public bool Proc_moveTenantCenter(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public int[] GetFirstScript()
	{
		return null;
	}

	public void SetQueue(int type, int xi, int yi, int offset)
	{
	}

	public void SetQueue(int type, int xi, int yi, int offset, int waitTime)
	{
	}

	public bool StartWork()
	{
		return false;
	}

	public bool StartWork(bool fukidashi)
	{
		return false;
	}

	public void WorkEnd()
	{
	}

	public void Update()
	{
	}

	public void Draw_chInsert(Graphics g)
	{
	}

	public void Insert_zSort(int[] disp_pos, int depth)
	{
	}

	public void Draw(Graphics g)
	{
	}

	public void Draw_efGage(Graphics g, int dx, int dy)
	{
	}

	public void Insert_efGage(int[] disp_pos, int depth)
	{
	}

	public void Draw_efHeart(Graphics g, int dx, int dy)
	{
	}

	public void Insert_efHeart(int[] disp_pos, int depth)
	{
	}

	public void Draw_debug(Graphics g)
	{
	}

	public void SetBaseData()
	{
	}

	public void InitPosData()
	{
	}

	private bool Update_fukidashi()
	{
		return false;
	}

	private void Insert_fukidashi(int[] disp_pos)
	{
	}

	public void Regist_fukidashi2(int fukidashi_id, int wait)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public void Proc_clerkActEnd()
	{
	}

	public void SetClerkActBonus()
	{
	}

	public bool ChTenantExist(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public void MoveToGoalPos(int script_id, Vector3D goal_pos, Vector3D pos, Vector3D old_pos)
	{
	}

	public void SetGoalPos(int goalPos_id, int address_x, int address_y)
	{
	}

	public void Proc_tenantUse(int address_x, int address_y)
	{
	}

	public void Proc_goProcession(Tenant tenant)
	{
	}

	public void Proc_goUseSpace(Tenant tenant)
	{
	}

	public void Pripare_inTenant(int tenantUseSpape_id, Tenant tenant)
	{
	}

	public void Out_inTenant()
	{
	}

	public bool ChHighQualityItem(Tenant tenant)
	{
		return false;
	}

	public void GetItem_inTenant(Tenant tenant, int address_x, int address_y)
	{
	}

	public void GetPlay_inTenant(Tenant tenant, int address_x, int address_y)
	{
	}

	public void GetRefresh_inTenant(Tenant tenant, int address_x, int address_y)
	{
	}

	public void GetDinner_inTenant(Tenant tenant, int address_x, int address_y)
	{
	}

	public void GetAdmire_inTenant(Tenant tenant, int address_x, int address_y)
	{
	}

	public bool ChangeGoTenant_Hashigo(int address_x, int address_y, int eva_speed)
	{
		return false;
	}

	public void GetHeartFromTenant(Tenant tenant)
	{
	}

	public void SetFukidashiFromTenant(Tenant tenant)
	{
	}

	public void SetFukidashiFromTenant(Tenant tenant, bool must, int wait)
	{
	}

	public void SetChReturnHour()
	{
	}

	public ResourceManager GetResource()
	{
		return null;
	}

	public int[] GetBoundingRect()
	{
		return null;
	}

	public float GetHumanSpeed(int typeId, int customerType)
	{
		return 0f;
	}
}
