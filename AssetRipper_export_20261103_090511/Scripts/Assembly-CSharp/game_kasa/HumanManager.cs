using data_kasa;
using java.io;
using java.util;
using kairo.unity.ui;
using main;

namespace game_kasa;

public class HumanManager
{
	public AppData apdat_;

	public PlayerData p_data;

	public static HumanManager instance;

	public const int HUMAN_MAX = 300;

	public const int OFF_CUSTOMER = 4;

	public static int apper_rate;

	public static int[] time_stair1;

	public static int[] time_stair2;

	public static int[] time_escalator;

	public static int[] time_elevator;

	public static int[] night_time_stair1;

	public static int[] night_time_stair2;

	public static int[] night_time_escalator;

	public static int[] night_time_elevator;

	public static int time_useTenantMin;

	public static int time_useTenantMax;

	public static int fukidashi_h;

	public static int fukidashi_time_min;

	public static int fukidashi_time_max;

	public static int fukidashi_wait_min;

	public static int fukidashi_wait_max;

	public static float[] human_vx;

	public static float[] V_ELSE;

	public static float[] V_TENANT_IN;

	public static float[] V_TENANT_OUT;

	public static int[] V_ANIME_TIME;

	public static float[] night_human_vx;

	public static float[] night_V_ELSE;

	public static float[] night_V_TENANT_IN;

	public static float[] night_V_TENANT_OUT;

	public static int[] night_V_ANIME_TIME;

	public static int[] eva_moveLine;

	public static int tenantOut_stopTime;

	public static int tenantOut_stopDis;

	public static int debug_appearNonRegularRate;

	public static int debug_getHeartRate;

	public static int FLG_USE_FRONTTENANT;

	public static int[] HASHIGO_RATE;

	public static int[] SUM_HASHIGO;

	public static int[] NUM_HASHIGO_CUSTOMER;

	public Human_K[] human_k;

	public static int hashigo_route;

	public static int appear_fromGround;

	public const int ROUTE_MODE_GO = 0;

	public const int ROUTE_MODE_HASHIGO = 1;

	public const int ROUTE_MODE_RETURN = 2;

	public const int ROUTE_MODE_FROMTRAIN = 3;

	public static int[] DECIDE_TENANT_F_BONUS;

	public static float[] DECIDE_TENANT_P1;

	public static int[] DECIDE_TENANT_P2;

	public static int[] DECIDE_TENANT_P3;

	public static int DE_R;

	public static int[] DE_SAMPLE;

	public static int[] DE_PARSENT;

	public static int DECIDE_SALETENANT_RATE;

	public int frame_;

	public static int MAX_FROM_TRAIN;

	public static int MAX_FROM_BUS;

	public static int MAX_FROM_HELI;

	public static readonly int[][] CLERK_MOVE_FLOOR;

	public int human_offset;

	private Tenant[] goingTenants_;

	private Vector3D appearCustomer_fromTrain_tmp1;

	private Vector3D appearCustomer_fromBus_tmp1;

	private Vector3D appearCustomer_fromHeli_tmp1;

	private const int CP_INDEX = 0;

	private const int CP_DY = 1;

	private const int CP_MAX = 2;

	private int[][] draw_data;

	private int draw_index;

	private int[] temp;

	internal Vector target_v;

	internal Vector sale_v;

	private static readonly float[] hobby_rate;

	public static HumanManager GetInstance()
	{
		return null;
	}

	public void Update()
	{
	}

	private void Customer_comeDepart(Human_K h)
	{
	}

	public void Draw(Graphics g)
	{
	}

	public void Draw_debug(Graphics g)
	{
	}

	public void SetReturnRouteFlg(Human_K human_k)
	{
	}

	public void SetHashigoRouteFlg(Human_K human_k)
	{
	}

	public Vector GetMovePoint(int address_x, int address_y)
	{
		return null;
	}

	public Human_K GetHumanObj()
	{
		return null;
	}

	public MovePoint GetNode(int[] route_data)
	{
		return null;
	}

	public int GetActiveHumanNum()
	{
		return 0;
	}

	public bool SetMoveRoute(Human_K human_k, int route_mode)
	{
		return false;
	}

	public int GetHashigoFloor(int now_floor)
	{
		return 0;
	}

	public Human_K GenerateCustomer()
	{
		return null;
	}

	public Vector GetMoveRouteDataGo(int startPoint_address_x, int startPoint_address_y, Tenant[] going_tenant, int tenantNum, Human_K human_k)
	{
		return null;
	}

	public Vector GetMoveRouteData(int startPoint_address_x, int startPoint_address_y, int goalPoint_floor, int route_mode)
	{
		return null;
	}

	public Vector GetMoveRouteDataReturn(int startPoint_address_x, int startPoint_address_y, int goalPoint_floor, int route_data)
	{
		return null;
	}

	public void SetStartPath(MovePoint move_point)
	{
	}

	public int[] GetRandArray(int size)
	{
		return null;
	}

	public Vector GetGoingTenant(int floor)
	{
		return null;
	}

	public Vector GetEntrancesTenant()
	{
		return null;
	}

	public void AppearCustomer_fromTrain(int customer_num, int address_x, int address_y)
	{
	}

	public void AppearCustomer_fromBus(int customer_num, int address_x, int address_y)
	{
	}

	public void AppearCustomer_fromHeli(int customer_num, int address_x, int address_y)
	{
	}

	public void Insert_customerObj(int index, int dy)
	{
	}

	public void Sort_zSortObj()
	{
	}

	private void ChangeParam(int[] obj1, int[] obj2)
	{
	}

	public void Draw_zSortObj(Graphics g)
	{
	}

	public int GetGoingTenantNew(int route_mode, Human_K human_k)
	{
		return 0;
	}

	public int GetTenantTopicOlder(Vector target_v, int route_mode, Human_K human_k)
	{
		return 0;
	}

	public int GetTenantDisOlder(Vector target_v, int route_mode, Human_K human_k)
	{
		return 0;
	}

	private void QuickSort(Tenant[] a, int i, int j)
	{
	}

	private int Pivot(Tenant[] a, int i, int j)
	{
		return 0;
	}

	private int Partition(Tenant[] a, int i, int j, int x)
	{
		return 0;
	}

	public bool ChConnectRoad(int address_x1, int address_y1, int address_x2, int address_y2)
	{
		return false;
	}

	public bool Ch_goHashigo(Human_K human_k)
	{
		return false;
	}

	public void SetClerkData(int index, Clerk clerk)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}
