using game_kasa;
using java.io;
using main;

namespace data_kasa;

public class TenantData
{
	public AppData apdat_;

	public PlayerData p_data;

	public Tenant parent;

	public static int LV_MAX;

	public const int ITEM_MAX = 5;

	public static int SHUTTER_ANIME_TIME;

	public static int SALE_HEART_DECRE;

	public static int SALE_WEEK;

	public static int SALE_RATE;

	public const int PID_QUALITY = 0;

	public const int PID_TOPIC = 1;

	public const int PID_INCOME = 2;

	public const int PID_UPKEEP = 3;

	public const int PID_STOCKMAX = 4;

	public const int PID_BONUS = 5;

	public const int PID_MAX = 6;

	public static readonly string[] PID_STR;

	public const int BONUSP_QUALITY = 0;

	public const int BONUSP_TOPIC = 1;

	public const int BONUSP_INCOME = 2;

	public const int BONUSP_UPKEEP = 3;

	public const int BONUSP_STOCKMAX = 4;

	public const int BONUSP_BONUS = 5;

	public const int BONUSP_MAX = 6;

	public int tenant_lv;

	public int tenant_numCustomer;

	public int[] tenant_bonusParam;

	private int quality;

	private int serving;

	private int topic;

	private int romance;

	private int income;

	private int upkeep;

	private int stock_max;

	public int stock;

	public int bonus_num;

	public int[][] report_month_plus;

	public int[][] report_month_minus;

	public int number_shop;

	public int[] service_id;

	public int num_serviceEquip;

	public bool[] service_onOff;

	public int flg_spFloor;

	public int flg_equipBonus;

	public int sale_point;

	public int slot_nowIndex;

	public int slot_release;

	public int slot_point;

	public int service_knowhow;

	public int tenantUseNum;

	public int[] tenantUseCustomerId;

	public int regiUseCustomerId;

	public int[] userSpace;

	public const int TENANTUSER_MAX = 7;

	public const int USER_NONE = -1;

	public const int GOALPOS_TENANTUSE_BUYITEM = 0;

	public const int GOALPOS_TENANTUSE_PRIREGI = 1;

	public const int GOALPOS_TENANTUSE_REGI = 2;

	public const int GOALPOS_TENANTUSE_DINNER = 3;

	public const int GOALPOS_TENANTUSE_TOLET = 4;

	public const int GOALPOS_TENANTUSE_REST = 5;

	public const int TENANT_USESPACE_NONUSESPACE = 0;

	public const int TENANT_USESPACE_BUYITEM = 1;

	public const int TENANT_USESPACE_DINNER = 2;

	public const int TENANT_USESPACE_TOLET = 3;

	public const int TENANT_USESPACE_REST = 4;

	public const int TENANT_USESPACE_PLAY = 5;

	public const int TENANT_USESPACE_REFRESH = 6;

	public const int TENANT_USESPACE_ADMIRE = 7;

	public const int MAXTIME_GETITEM = 22;

	public const int MAXTIME_TEATIME = 56;

	public const int MAXTIME_REST = 35;

	public static readonly int[] TORELEASE_VALUE;

	public const int MAX_USERSPACE = 7;

	public static int[] MAXNUM_USERSPACE;

	public static int[] NUM_USEPOINT;

	public static int[] USEPOINT_LINE_LEFT;

	public static int[] USEPOINT_LINE_RIGHT;

	public static int FLG_SERVICE_DEVELOP;

	public static int[][] TUSE_PARAM;

	public int[] report_benefit_month;

	public static int[] FLOOR_BOUNUS_FLOOR;

	public static int[][] FLOOR_BOUNUS_LIKE;

	public const int KIND_MEAL = 0;

	public const int KIND_DAILY = 1;

	public const int KIND_ELEC = 2;

	public const int KIND_BEAUTY = 3;

	public const int KIND_ENTERTAINMENT = 4;

	public const int KIND_EQUIPMENT = 5;

	public const int KIND_ELSE = 6;

	public const int KIND_NUM = 7;

	public static readonly string[] KIND_NAME;

	public const int TENANTMOVE_COST = 50;

	public const int TENANT_COST_FLOOR_RATE = 50;

	private int UPPOINT;

	private Vector3D cntCustomer_tmp1;

	public TenantData()
	{
	}

	public TenantData(Tenant tenant)
	{
	}

	public void Build_initParam()
	{
	}

	public void Update()
	{
	}

	public void SetParamData()
	{
	}

	public void SetParamData(bool flg_efEquip, TenantData equipTenantData)
	{
	}

	public void Proc_income(int in_income)
	{
	}

	public void Proc_upkeep()
	{
	}

	public void Update_week()
	{
	}

	public void Udate_monthPri()
	{
	}

	public void Update_month()
	{
	}

	public void Update_year()
	{
	}

	public void PutSaleMark()
	{
	}

	public int GetReportYear(int year)
	{
		return 0;
	}

	public void UpPoint_slotRelease(Clerk clerk)
	{
	}

	public bool ChSlotRelease()
	{
		return false;
	}

	public void Clik_slotRelease()
	{
	}

	public void CntCustomer(Tenant tenant)
	{
	}

	public void Tenant_lvUp(ChipModel model)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public static void Copy(TenantData src, TenantData dst)
	{
	}

	public bool ChAllService(TenantData t_data)
	{
		return false;
	}

	public int GetQuality()
	{
		return 0;
	}

	public int GetQuality(bool flg_disp)
	{
		return 0;
	}

	public void SetQuality(int charm)
	{
	}

	public int GetIncome()
	{
		return 0;
	}

	public int GetIncome(bool flg_disp)
	{
		return 0;
	}

	public void SetIncome(int income)
	{
	}

	public int GetRomance()
	{
		return 0;
	}

	public int GetRomance(bool flg_disp)
	{
		return 0;
	}

	public void SetRomance(int romance)
	{
	}

	public int GetServing()
	{
		return 0;
	}

	public int GetServing(bool flg_disp)
	{
		return 0;
	}

	public void SetServing(int serving)
	{
	}

	public int GetStock_max()
	{
		return 0;
	}

	public int GetStock_max(bool flg_disp)
	{
		return 0;
	}

	public void SetStock_max(int stock_max)
	{
	}

	public int GetTopic()
	{
		return 0;
	}

	public int GetTopic(bool flg_disp)
	{
		return 0;
	}

	public void SetTopic(int topic)
	{
	}

	public int GetUpkeep()
	{
		return 0;
	}

	public int GetUpkeep(bool flg_disp)
	{
		return 0;
	}

	public void SetUpkeep(int upkeep)
	{
	}
}
