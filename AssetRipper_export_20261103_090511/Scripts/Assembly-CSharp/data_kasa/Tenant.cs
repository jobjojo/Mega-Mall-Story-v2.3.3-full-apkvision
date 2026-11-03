using game_kasa;
using java.io;
using kairo.unity.ui;
using main;

namespace data_kasa;

public class Tenant
{
	public AppData apdat_;

	public bool flg_exist;

	public int floor;

	public int house_number;

	public int direct;

	public int[] body_x;

	public int[] body_y;

	public int[] size_yoko;

	public int[] size_tate;

	public int construction_cnt;

	public int depart_setup;

	public int[] procession;

	public bool ch_connectGround;

	public bool ch_movingGround;

	public bool flg_business;

	public int cnt_shutter;

	public int cnt_shutterFukidashi;

	public ChipModel chip_tenant;

	public ChipModel chip_step;

	public int chip_tenantId;

	public int chip_stepId;

	public MovePoint move_point;

	public Elevator elevator;

	public Entrance entrance;

	public TenantData tenantData;

	public const int ID_TENANT = 0;

	public const int ID_STEP = 1;

	public const int ID_ROUTE = 2;

	public const int CONSTRUCTION_MAX = 60;

	public const int TENANT_ID_ROUTE = 0;

	public const int TENANT_ID_STAIRS1 = 1;

	public const int TENANT_ID_STAIRS2 = 2;

	public const int TENANT_ID_ESCALATOR = 3;

	public const int TENANT_ID_ELEVATOR = 4;

	public const int TENANT_ID_BUS = 6;

	public const int TENANT_ID_STATION = 7;

	public const int TENANT_ID_HELI = 8;

	public const int TENANT_ID_MOVIE = 17;

	public const int TENANT_ID_HOSPITAL = 33;

	public const int TENANT_ID_AQUARIUM = 38;

	public const int TENANT_ID_CAJINO = 85;

	public const int TENANT_ID_PURANETA = 84;

	public const int TENANT_ID_CONVINI = 36;

	public const int TENANT_ID_SERVICECOUTER = 28;

	public const int TYPE_TENANT = 0;

	public const int TYPE_ROUTE = 1;

	public const int TYPE_STAIR = 2;

	public const int TYPE_ESCALATOR = 3;

	public const int TYPE_ELEVATOR = 4;

	public const int TYPE_ENTRANCE = 5;

	public const int TYPE_STATION = 6;

	public const int TYPE_BUS = 7;

	public const int TYPE_HELI = 8;

	public const int TYPE_ELSE = 9;

	public const int DEPART_NORAML = 0;

	public const int DEPART_ROOFTOP = 1;

	public const int DEPART_ROOFTOP_LEFT = 2;

	public const int DEPART_ROOFTOP_RIGHT = 4;

	public const int DEPART_FLOORLEFT = 8;

	public const int DEPART_FLOORRIGHT = 16;

	public const int DEPART_FLOORLEFT_ENTRANCE = 32;

	public const int DEPART_FLOORRIGHT_ENTRANCE = 64;

	public const int DEPART_FLOORLEFT_ENTRANCE_HALF = 128;

	public const int DEPART_FLOORRIGHT_ENTRANCE_HALF = 256;

	public const int DESTRUCT_MODE_ALL = 0;

	public const int DESTRUCT_MODE_TENANT_ONLY = 1;

	public const int DESTRUCT_MODE_STEP_ONLY = 2;

	public const int DESTRUCT_MODE_NOTHING = 3;

	public const int MAX_PROCESSTION = 4;

	public static int num_yokoSize;

	public static int[] num_procession;

	public static int[] eva_startLine_x;

	public static int[] eva_endLine_x;

	public static int[] eva_startLine_z;

	public static int[] eva_endLine_z;

	public static int[] num_lineYoko;

	public static int[] num_lineTate;

	public static int[] eva_entrance;

	public static int[] eva_exit;

	private const int NUM_MONEY = 5;

	public static int MONEY_INITPY;

	public static int MONEY_UP_DIS;

	public static int MONEY_UP_TIME;

	public static int MONEY_DOWN_DIS;

	public static int MONEY_DOWN_TIME;

	public static int MONEY_STOP_TIME;

	public static int MONEY_NUM_FRAME;

	public static int MONEY_WAIT;

	private int[] flg_money;

	private int[] money_frame;

	private int[] money_wait;

	private int[] screen_py;

	private int[] screen_v;

	private int[] value;

	private string[] value_str;

	private int screen_a_up;

	private int screen_v_down;

	private int money_index;

	public const int FUKIDASHI_DIRECT_UP = 0;

	public const int FUKIDASHI_DIRECT_DOWN = 1;

	public const int FUKIDASHI_DIRECT_STOP = 2;

	public const int FUKIDASHI_MOVEHOW_VSTOP = 0;

	public const int FUKIDASHI_MOVEHOW_VRETURN = 1;

	public const int FUKIDASHI_MOVEHOW_VFIX = 2;

	public const int FUKIDASHI_ID_DIRECT = 0;

	public const int FUKIDASHI_ID_MOVEHOW = 1;

	public const int FUKIDASHI_ID_DIS = 2;

	public const int FUKIDASHI_ID_TIME = 3;

	public const int FUKIDASHI_ID_VY = 4;

	public const int FUKIDASHI_ID_AY = 5;

	public const int NUM_TF_POINT = 2;

	public static int TF_ENDCNT;

	public static int TF_NOROUTE_TIME;

	public static int setIndex;

	public static int[][] tf_data;

	public int tf_py;

	public int tf_vy;

	public int tf_ay;

	public int tf_flgExist;

	public int tf_index;

	public int tf_imgId;

	public int tf_cnt;

	public int tf_cntAll;

	public int flg_fukidashi;

	public static int tf_initPy;

	public const int FLG_FUKIDASHI_SPFLOOR = 1;

	public const int FLG_FUKIDASHI_OPEN = 2;

	public const int FLG_FUKIDASHI_COMPATIBLE = 4;

	private int frame;

	public bool flg_build;

	public bool flg_hitCursor;

	public bool flg_inDisplay;

	public int[] disp_pos;

	public bool ch_movingGround_finish;

	public bool ch_moveRoute;

	public int temp_param1;

	public int temp_param2;

	public int temp_param3;

	public const int EF_EQUIPBONUS_OY = -6;

	public const int EF_EQUIPBONUS_DIS = 130000;

	public const int EF_EQUIPBONUS_TIME = 15;

	public const int EF_EQUIPBONUS_STOP_TIME = 10;

	public EffectObj ef_equipBonus;

	public Vector3D ef_screenPos;

	public Tenant()
	{
	}

	public Tenant(int in_floor, int in_house_number)
	{
	}

	public void Init()
	{
	}

	public void Update()
	{
	}

	public void Draw(Graphics g, int dx, int dy, int address_x, int address_y)
	{
	}

	public void Draw_buildRect(Graphics g, int dx, int dy)
	{
	}

	public void Draw_activeObj(Graphics g, int dx, int dy, int address_x, int address_y)
	{
	}

	public void Draw_step(Graphics g, int dx, int dy, int address_x, int address_y)
	{
	}

	public void Draw_stepZSort(Graphics g, int dx, int dy, int address_x, int address_y)
	{
	}

	public void Draw_road(Graphics g, int dx, int dy, int floor)
	{
	}

	public void Draw_DepartPartsSide(Graphics g, int dx, int dy)
	{
	}

	public void Draw_DepartPartsRoofTop(Graphics g, int dx, int dy)
	{
	}

	public void Draw_departParts(Graphics g, int img_id, int depth, int dx, int dy)
	{
	}

	public void Draw_departParts(Graphics g, int img_id, int seb_id, int frame, int depth, int dx, int dy)
	{
	}

	public static void Draw_buildRoad(Graphics g, ChipModel model, int dx, int dy)
	{
	}

	public static void Draw_buildRoadLine(Graphics g, int dx, int dy, int id)
	{
	}

	public void Build(ChipModel model, int in_body_x, int in_body_y, int in_size_yoko, int in_size_tate)
	{
	}

	public void Destruct(int destruct_mode, int in_body_x, int in_body_y)
	{
	}

	public void Update_money()
	{
	}

	public void Draw_money(Graphics g, int dx, int dy)
	{
	}

	public void Regist_money(int in_value, int wait)
	{
	}

	public void Update_tf()
	{
	}

	public void Draw_tf(Graphics g, int dx, int dy)
	{
	}

	public int Regist_tf(int fukidashi_id)
	{
		return 0;
	}

	public void ChFukidashi()
	{
	}

	public void SetSpFloorData(int spFloor_id, bool flg_effect)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Serialize2(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public void Deserialize2(InputStream stream)
	{
	}
}
