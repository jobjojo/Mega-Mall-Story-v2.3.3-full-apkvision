using java.io;
using kairo.unity.ui;
using main;

namespace game_kasa;

public class VehicleManager
{
	public AppData apdat_;

	private static VehicleManager instance;

	public const int TRAIN_MAX = 2;

	public Vector3D[] train_pos;

	public Vector3D[] train_v;

	public Vector3D[] train_a;

	public bool[] train_flgExist;

	public int[] train_floor;

	public int[] train_stopAddressX;

	public int[][] train_address;

	private int[] train_mode;

	private int[] train_stopCnt;

	public int now_trainIndex;

	public static int flg_train1F;

	public const int TRAIN_DRAW_STATUS_NONE = 0;

	public const int TRAIN_DRAW_STATUS_RAIL_UNDERG = 1;

	public const int TRAIN_DRAW_STATUS_RAIL = 2;

	public const int TRAIN_DRAW_STATUS_1F = 3;

	public const int TRAIN_DRAW_STATUS_AMOUNG = 4;

	public const float TRAIN_SPEED_VX = 25f;

	public const float TRAIN_SPEED_AX = -1f;

	private const int VEHICLE_MODE_STANDBY = 0;

	private const int VEHICLE_MODE_GOING = 1;

	private const int VEHICLE_MODE_STOP = 2;

	private const int VEHICLE_MODE_RETURN = 3;

	private const int TRAIN_MAX_STOPCNT = 50;

	private const int BUS_MAX_STOPCNT = 50;

	private const int HELI_MAX_STOPCNT = 50;

	public static int train_customerNum;

	public static int train_customerWaitMax;

	public static int train_customerW;

	public static int bus_customerNum;

	public static int bus_customerWaitMax;

	public static int bus_customerW;

	public static int heli_customerNum;

	public static int heli_customerWaitMax;

	public static int heli_customerW;

	public const int BUS_MAX = 2;

	public Vector3D[] bus_pos;

	public Vector3D[] bus_v;

	public Vector3D[] bus_a;

	public bool[] bus_flgExist;

	public int[] bus_floor;

	public int[] bus_stopAddressX;

	public int[][] bus_address;

	private int[] bus_mode;

	private int[] bus_stopCnt;

	public int now_busIndex;

	public static int flg_bus1F;

	public const int BUS_DRAW_STATUS_NONE = 10;

	public const int BUS_DRAW_STATUS_RAIL_UNDERG = 11;

	public const int BUS_DRAW_STATUS_RAIL = 12;

	public const int BUS_DRAW_STATUS_1F = 13;

	public const int BUS_DRAW_STATUS_AMOUNG = 14;

	public const float BUS_SPEED_VX = 25f;

	public const float BUS_SPEED_AX = -1f;

	public const int HELI_MAX = 3;

	public Vector3D[] heli_pos;

	public Vector3D[] heli_oldPos;

	public Vector3D[] heli_goalPos;

	public Vector3D[] heli_startPos;

	public Vector3D[] heli_v;

	public Vector3D[] heli_a;

	public bool[] heli_flgExist;

	public int[] heli_muki;

	public int[][] heli_goalAddress;

	public int[][] heli_address;

	public int[] heli_mode;

	public int[] heli_stopCnt;

	public int[] heli_movePoint;

	public int now_heliIndex;

	private const int HELI_INIT_ADD_ADDRESS_Y = 3;

	private const float HELI_INIT_VX = 30f;

	private const float HELI_VY = -20f;

	private int temp_cnt;

	private Vector3D update_train_tmp1;

	private Vector3D update_bus_tmp1;

	private int[] draw_train_tmp;

	private int[] draw_bus_tmp;

	private int[] draw_heli_tmp;

	private int[] draw_heliShadow_tmp1;

	private int[] draw_heliShadow_tmp2;

	private Vector3D draw_heliShadow_tmp3;

	private int[] chInDisplay_train_tmp1;

	private int[] chInDisplay_train_tmp2;

	private int[] chInDisplay_bus_tmp1;

	private int[] chInDisplay_bus_tmp2;

	public static VehicleManager GetInstance()
	{
		return null;
	}

	public void StartTrain(int stop_address_x, int floor)
	{
	}

	private void InitTrain(int stop_address_x, int floor, int train_index)
	{
	}

	public void StartBus(int stop_address_x, int floor)
	{
	}

	private void InitBus(int stop_address_x, int floor, int bus_index)
	{
	}

	public void StartHeli(int goal_addressX, int goal_addressY)
	{
	}

	private void InitHeli(int goal_addressX, int goal_addressY, int heli_index)
	{
	}

	public void DeleteTrain(int address_x, int address_y)
	{
	}

	public void DeleteBus(int address_x, int address_y)
	{
	}

	public void DeleteHeli(int address_x, int address_y)
	{
	}

	public void Update()
	{
	}

	private void Update_train()
	{
	}

	private void Update_bus()
	{
	}

	private void Update_heli()
	{
	}

	public void Draw_train(Graphics g)
	{
	}

	public void Draw_bus(Graphics g)
	{
	}

	public void Draw_heli(Graphics g)
	{
	}

	public void Draw_heliShadow(Graphics g)
	{
	}

	public int[] ChInDisplay_train()
	{
		return null;
	}

	public int[] ChInDisplay_bus()
	{
		return null;
	}

	public int GetTrainDrawStatus(int ch_floor)
	{
		return 0;
	}

	public int GetRailDrawStatus(int ch_floor)
	{
		return 0;
	}

	public void Draw_rail(Graphics g, int rail_status, int dx, int dy)
	{
	}

	public void Start_vehicle()
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}
