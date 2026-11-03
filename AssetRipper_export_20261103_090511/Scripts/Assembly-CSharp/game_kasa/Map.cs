using data_kasa;
using java.io;
using java.util;
using kairo.unity.ui;
using main;

namespace game_kasa;

public class Map
{
	public AppData apdat_;

	public PlayerData p_data;

	public const int STEP_X = 30;

	public const int STEP_Y = 15;

	public const int SIZE_W = 60;

	public const int SIZE_H = 29;

	private static Map instance;

	public const int FLOOR_MAX = 20;

	public const int HOUSENUMBER_MAX = 30;

	public static int flg_cameraFlg;

	public Tenant[][] tenant;

	public string underExplain_str;

	private int underExplain_cnt;

	public const int OFF_GFLOOR = 5;

	private Vector3D ground_pos;

	private Vector3D depart_leftBottom;

	private Vector3D depart_rightBottom;

	private int[] disp_ground;

	private int[] disp_departLB;

	private int[] disp_departRB;

	public int frame_;

	private int[] draw_floor_tmp1;

	private int[] draw_floor_tmp2;

	private int[] draw_debugFloor_tmp1;

	private int[] draw_debugFloor_tmp2;

	private int[] chDispHeight_tmp;

	private int[] draw_ground_tmp1;

	private int[] draw_ground_tmp2;

	private int[] draw_ground_tmp3;

	private int[] draw_weather_tmp;

	private int[] draw_sky_tmp;

	private int[] draw_skyHigh_tmp;

	public static readonly Vector3D temp_leftBottom;

	private int[] getDepartDispPos_tmp1;

	public bool elevator_mode;

	private int[] getTenantDispData_tmp;

	private int[] draw_backRail_tmp1;

	private int[] draw_backRail_tmp2;

	public static int count;

	public static Map GetInstance()
	{
		return null;
	}

	public void Update()
	{
	}

	public void Draw(Graphics g)
	{
	}

	public void SetFlgInDisplay(Graphics g)
	{
	}

	public void Draw_step(Graphics g)
	{
	}

	public void Draw_tenantActiveObj(Graphics g)
	{
	}

	public void Draw_debugInfo(Graphics g)
	{
	}

	public void Draw_floor(Graphics g, int screen_off_y, int floor_num)
	{
	}

	public void Draw_debugFloor(Graphics g, int screen_off_y, int floor_num)
	{
	}

	public int ChDispHeight(int screen_off_y)
	{
		return 0;
	}

	public int ChDispWidth(int left_x, int right_x)
	{
		return 0;
	}

	public int ChDispWidth(int[] pos_data)
	{
		return 0;
	}

	public int ChDispWidth2(Tenant tenant, int camera_left_x, int camera_top_y)
	{
		return 0;
	}

	public int Get1FloorScreenHeight()
	{
		return 0;
	}

	public int GetFloorNum()
	{
		return 0;
	}

	public void Draw_ground(Graphics g)
	{
	}

	public void Draw_weather(Graphics g)
	{
	}

	public void Draw_sky(Graphics g)
	{
	}

	public void Draw_skyHigh(Graphics g)
	{
	}

	public void SetDepartParts()
	{
	}

	private void SetDepartRoofTop()
	{
	}

	private void SetDepartSideLeft()
	{
	}

	private void SetDepartSideRight()
	{
	}

	public void Update_modelObj()
	{
	}

	public void Update_efEquipBonus()
	{
	}

	public int[] GetAddressFromScreen(float screen_px, float screen_py, int[] var_out)
	{
		return null;
	}

	public int[] GetAddressFromGlobal(Vector3D pos, int[] var_out)
	{
		return null;
	}

	public int[] GetDpartBaseScreenPos()
	{
		return null;
	}

	public int[] GetDepartDispPos(int[] address)
	{
		return null;
	}

	public void Build_route(ChipModel buildModel, int start_x, int start_y, int end_x, int end_y)
	{
	}

	public int GetDestructModeTenant(int address_x, int address_y)
	{
		return 0;
	}

	public int GetDestructModeStep(int address_x, int address_y)
	{
		return 0;
	}

	public void SetUnderExplain(string reason)
	{
	}

	public void ResetUnderExplain()
	{
	}

	public bool ChFinishUnderExplain()
	{
		return false;
	}

	public int[] GetTenantDispData(Tenant tenant, int left_x, int top_y)
	{
		return null;
	}

	public Vector3D GetGlobalPosFromAdress(int address_x, int address_y, Vector3D var_out)
	{
		return null;
	}

	public void SetGlobalPosFromAddress(int address_x, int address_y, Vector3D set_pos)
	{
	}

	public Vector3D GetScreenPosFromAdress(int address_x, int address_y, Vector3D var_out)
	{
		return null;
	}

	public bool ChSetSpace(int address_x, int address_y)
	{
		return false;
	}

	public bool ChSetSpace(ChipModel model, int address_x, int address_y)
	{
		return false;
	}

	public int[] GetSetSpaceAddress()
	{
		return null;
	}

	public int GetSetSpaceTenantArea()
	{
		return 0;
	}

	public void Draw_backRail(Graphics g)
	{
	}

	public int[] GetRailInfo()
	{
		return null;
	}

	public static int GetDisAddress(int ax1, int ay1, int ax2, int ay2)
	{
		return 0;
	}

	public static int GetDisAddress(int ax1, int ax2)
	{
		return 0;
	}

	public void Copy_routeData(Vector dst_data, Vector src_data)
	{
	}

	public static bool ChConnectGround(int destruct_x, int destruct_y)
	{
		return false;
	}

	private static void ChRoopConnectGround(Tenant[][] all_tenant, int address_x, int address_y, int destruct_x, int destruct_y)
	{
	}

	public void ChMoveGround()
	{
	}

	public void ChRoopMoveGround(Tenant[][] tenant, int address_x, int address_y)
	{
	}

	public void SetInitDepartEntrance(int yoko_num)
	{
	}

	public void SetInitDepartTenant()
	{
	}

	public void SetDebugDepartTenant(int mode)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}
