using form;
using game_kasa;
using java.io;
using java.util;
using kairo.unity.ui;
using main;

namespace data_kasa;

public class PlayerData
{
	public AppData apdat_;

	private static PlayerData instance;

	public int num_heart;

	public int getNum_heart;

	public int now_departRank;

	public int pri_departRank;

	public Vector tenantData_v;

	public Vector getModelOrder_v;

	public int[] chipModel_haveNum;

	public bool[] chipModel_find;

	public bool[] chipModel_store;

	public bool[] chipModel_discoverRareItem;

	public int numCustomer_year;

	public int numCustomer_allTime;

	public static int now_HNNum;

	public static int now_BFNum;

	public static int now_FNum;

	public const int FLOORNUM_MAX = 12;

	public const int BFLOORNUM_MAX = 4;

	public const int HOUSENUM_MAX = 30;

	public static int RETURNHOUR;

	public static int RETURNHOUR_ENTRANCE;

	public bool[] flg_rup;

	public int depart_charm;

	public int depart_topic;

	public int depart_serving;

	public int depart_romance;

	public int depart_upkeep;

	public int depart_averageIncome;

	public int depart_numRegular;

	public int depart_userNum;

	public int depart_lv;

	public int ranking_step;

	public int depart_topMonthIncome;

	public int[] depart_month_numCostomer;

	public const int REPORT_BUILD = 0;

	public const int REPORT_TENANT = 1;

	public const int REPORT_CLERK = 2;

	public const int REPORT_APARTAREA = 3;

	public const int REPORT_ELSE = 4;

	public const int REPORT_BENEFIT = 5;

	public int[][][][] player_income;

	public static readonly int[][] SALE_ADDVALUE;

	private const int SALE_ADD_SEASON = 500;

	private const int SALE_ADD_SPFLOOR_NEW = 700;

	private const int SALE_ADD_SPFLOOR_ANY = 0;

	private static readonly int[][] PARAM_SALE;

	public const int SALEPID_BUILDTENANT = 0;

	public const int SALEPID_DESTRUCT = 1;

	public const int SALEPID_REGULAR = 2;

	public const int SALEPID_SALE = 3;

	public const int SALEPID_SPFLOOR = 4;

	public const int SALEPID_AREACONST = 5;

	public const int SALEPID_MONTH = 6;

	public const int SALEPID_REGULARBONUS = 7;

	public const int SALEPID_USETENANT = 8;

	public const int SALEPID_ADVERTISE = 9;

	public const int SALEPID_EVENT = 10;

	public static int depart_popularPoint;

	public int depart_feverNum;

	public static int DEPART_FEVERP_INIT;

	public static int DEPART_FEVERP_ADD;

	public static int DEPART_FEVERP_MAX;

	public int[] depart_kindPoint;

	public int[] depart_kindParsent;

	public int[] depart_share;

	public const int DEPART_EFPUP_NUM = 3;

	public JampObj[] depart_efPup;

	public bool[] depart_efPup_flgExist;

	public int[] depart_efPup_cnt;

	public int[] depart_efPup_value;

	public int depart_efPup_index;

	public int flg_fever;

	public static int fever_cnt;

	public const int FEVER_TIME = 1200;

	public const int FEVER_ENDANIME = 350;

	public static readonly string[][] BUSINESS_COMMENT;

	public int business_value;

	public int business_goalValue;

	public int business_week;

	public int business_v;

	public int businessValue_middleWindow;

	private int[] BUSINESS_NEXTRANK_RATE;

	public int[] item_numHave;

	public bool[] item_numFind;

	public bool[] item_store;

	public bool[] spFloor_numFind;

	public bool[] spFloor_numExist;

	public bool[] spFloor_numBuild;

	public bool[] spFloor_store;

	public bool[] customer_find;

	public bool[] clerk_find;

	public int[] clerk_id;

	public int[] temp_oldClerkId;

	public const int CLERK_ID_NONE = -1;

	public const int APARTBLOCK_ID_RIVAL = -4;

	public const int APARTBLOCK_ID_NONE2 = -3;

	public const int APARTBLOCK_ID_NONE = -2;

	public const int APARTBLOCK_ID_SALE = -1;

	public const int APARTBLOCK_ID_DEPART = 0;

	public const int DEPART_BLOCK_ID = 1;

	public static int NUM_AREABLOCK;

	public const int WEATHER_SUN = 0;

	public const int WEATHER_CLOUD = 1;

	public const int WEATHER_RAIN = 2;

	public const int WEATHER_SNOW = 3;

	public const int WEATHER_FEVER = 4;

	public static int WEATHER_SPEED_CLOUD;

	public static int WEATHER_SPEED_RAIN;

	public static int WEATHER_SPEED_SNOW;

	public static readonly int[] NOWWEATHER_RATE;

	public int now_weather;

	public int next_weather;

	public int[] nowWeather_point;

	public const int SEASON_SPRING = 0;

	public const int SEASON_SUMMER = 1;

	public const int SEASON_AUTUMN = 2;

	public const int SEASON_WINTER = 3;

	public int[] middleWindow_animeTime;

	public const int MIDDLEWINDOW_MODE_REPORT = 0;

	public const int MIDDLEWINDOW_MODE_SALE = 1;

	public bool flg_middleWindow;

	public int cnt_middleWindow;

	public int mode_middleWindow;

	public JampObj tBonus_jamp;

	public int tBonus_jampCnt;

	public int rival_cnt;

	public int rival_cntWeek;

	public int rival_mode;

	public int rival_id;

	public const int EVENT_ACT_ENDING = 1;

	public const int EVENT_ACT_RIVALAPPEAR = 2;

	public const int EVENT_ACT_INIT_BUILD = 4;

	public const int EVENT_ACT_INIT_BUILDSTEP = 8;

	public const int EVENT_ACT_INIT_BUILDEQUIP = 16;

	public const int EVENT_ACT_INIT_BUILDSPECIAL = 32;

	public const int EVENT_ACT_INIT_BUSINESS = 64;

	public const int EVENT_ACT_INIT_BUYTENANT = 128;

	public const int EVENT_ACT_INIT_BUYTENANT2 = 256;

	public const int EVENT_ACT_INIT_NONROUTE_GROUND = 512;

	public const int EVENT_ACT_INIT_NONROUTE_AIR = 1024;

	public const int EVENT_ACT_INIT_BADTIME = 2048;

	public const int EVENT_ACT_INIT_RAIN = 4096;

	public const int EVENT_ACT_INIT_FEVER = 8192;

	public const int EVENT_ACT_INIT_REGULARBONUS = 16384;

	public const int EVENT_ACT_INIT_CLERK = 32768;

	public const int EVENT_ACT_OPENMENU_SPECIAL = 65536;

	public const int EVENT_ACT_INIT_CUSTOMER = 131072;

	public const int EVENT_ACT_INIT_SALE = 262144;

	public const int EVENT_ACT_SELECT_NONCLERK = 524288;

	public const int EVENT_ACT_INIT_REQUEST = 1048576;

	public const int EVENT_ACT_NOTINVEST_RATE = 2097152;

	public const int EVENT_ACT_NOCLERK = 4194304;

	public const int EVENT_ACT_INIT_NOROUTETENANT = 8388608;

	public const int EVENT_ACT_INIT_SCCESSSERVICE = 16777216;

	public const int EVENT_ACT_INIT_UNDERG = 16777216;

	public const int EVENT_ACT_INIT_CLERK_SELECT = 33554432;

	public const int EVENT_ACT_RANKUP_PUMPKIN = 67108864;

	public const int EVENT_ACT_RANK_UNDERPRIRANK = 134217728;

	public int flg_eventAct;

	public const int EVENT_ACT2_INIT_SDEVELOP = 1;

	public const int EVENT_ACT2_INIT_FALSE_SERVICE = 2;

	public const int EVENT_ACT2_INIT_SELECT_OUT = 4;

	public const int EVENT_ACT2_INIT_LVUP = 8;

	public const int EVENT_ACT2_INIT_ADVER = 16;

	public const int EVENT_ACT2_INIT_FALSE_GOAL = 32;

	public const int EVENT_ACT2_INIT_SPFLOOR_D = 64;

	public const int EVENT_ACT2_INIT_RANKUP = 128;

	public const int EVENT_ACT2_INIT_BONUS = 256;

	public const int EVENT_ACT2_ADVER0 = 512;

	public const int EVENT_ACT2_REQUEST_BUS = 1024;

	public const int EVENT_ACT2_REQUEST_ESCALATOR = 2048;

	public const int EVENT_ACT2_REQUEST_ELEVATOR = 4096;

	public const int EVENT_ACT2_CANNOT_RANKUP = 8192;

	public const int EVENT_ACT2_GO_1STAR = 16384;

	public const int EVENT_ACT2_GO_1STAR2 = 32768;

	public const int EVENT_ACT2_INIT_RANKING = 65536;

	public const int EVENT_ACT2_INIT_REGULAR = 131072;

	public const int EVENT_ACT2_RBONUS_FREND = 262144;

	public const int EVENT_ACT2_RBONUS_MONEY = 524288;

	public const int EVENT_ACT2_RBONUS_HEART = 1048576;

	public const int EVENT_ACT2_RBONUS_TENANT = 2097152;

	public const int EVENT_ACT2_TORANKUP_MIN = 4194304;

	public const int EVENT_ACT2_CAN_CHANGECLERK = 8388608;

	public const int EVENT_ACT2_CHANGE_T = 16777216;

	public int flg_eventAct2;

	public const int EVENT_ACT3_INIT_SPFLOOR = 1;

	public const int EVENT_ACT3_INIT_TICOME_500OVER = 2;

	public const int EVENT_ACT3_INIT_TICOME_5000OVER = 4;

	public const int EVENT_ACT3_CUSTOMER1000 = 8;

	public const int EVENT_ACT3_BUILD_BUS = 16;

	public const int EVENT_ACT3_BUILD_STATION = 32;

	public const int EVENT_ACT3_BUILD_HELI = 64;

	public const int EVENT_ACT3_INIT_BADBUSINESS = 128;

	public const int EVENT_ACT3_INIT_LOSTITEM = 256;

	public const int EVENT_ACT3_INIT_FEVER = 512;

	public const int EVENT_ACT3_INIT_QUALITY100 = 1024;

	public const int EVENT_ACT3_INIT_TOPIC200 = 2048;

	public const int EVENT_ACT3_INIT_REGI100 = 4096;

	public const int EVENT_ACT3_INIT_LV10TENANT = 8192;

	public const int EVENT_ACT3_BUILD_MOVIE = 16384;

	public const int EVENT_ACT3_BUILD_HOSPITAL = 32768;

	public const int EVENT_ACT3_BUILD_AQUARIUM = 65536;

	public const int EVENT_ACT3_BUILD_CAJINO = 131072;

	public const int EVENT_ACT3_BUILD_PURANETA = 262144;

	public const int EVENT_ACT3_BUILD_COVINI = 524288;

	public const int EVENT_ACT3_BUILD_SERVICECOUNTER = 1048576;

	public const int EVENT_ACT3_REGULARNUM88 = 2097152;

	public const int EVENT_ACT3_RANKING1 = 4194304;

	public int flg_eventAct3;

	public const int GAME_OPEN_AREAAPART = 1;

	public const int GAME_OPEN_BUYTENANT = 2;

	public const int GAME_OPEN_SALE = 4;

	public const int GAME_OPEN_CLERK = 8;

	public const int GAME_RANK_TOP = 16;

	public int flg_game;

	public const int NEWMARK_APARTAREA = 1;

	public const int NEWMARK_BUYTENANT = 2;

	public const int NEWMARK_CHANGECLERK = 4;

	public const int NEWMARK_ADVERTISE = 8;

	public const int NEWMARK_SALE = 16;

	public const int NEWMARK_SPFLOOR = 32;

	public int flg_newMark;

	public const int ADVER_TIRASHI = 0;

	public const int ADVER_NET = 1;

	public const int ADVER_CAR = 2;

	public const int ADVER_BALOON = 3;

	public const int ADVER_TV = 4;

	public const int ADVER_NUM = 5;

	public bool[] flg_adverUse;

	public static readonly int[][] ADVER_VALUE;

	public static readonly string[] ADVER_NAME;

	public static readonly string[] ADVER_EXPLAIN;

	public const int NEXTRANKING_TIME = 18360;

	public int nextRank_cnt;

	public bool flg_nextRankWatch;

	public int num_stair;

	public int num_escalator;

	public int num_elevator;

	public int[][] business_valueData;

	public int[] business_changeTarget;

	public EffectObj[] ef_firework;

	public int ef_firework_index;

	public const int MAX_EF_FIREWORK = 14;

	public int[] depart_benefit_month;

	public Vector equipBuild_v;

	public bool flg_serviceDevelopSccess;

	public float[] tenantKind_rate;

	private string[] WEATHER_COMMENT_RAIN;

	private string[] WEATHER_COMMENT_SNOW;

	private int business_revise;

	public static int DEPART_EFPUP_DIS;

	public static int[] DEPART_EFPUP_TIME;

	internal int UP_TIME;

	public int eva_income;

	public int eva_numTenant;

	public int eva_numFindSpFloor;

	public int eva_order;

	public static readonly string[] TOPIC_STR;

	public const int CPOINT_ENDMONEY = 0;

	public const int CPOINT_NUMREGULAR = 1;

	public const int CPOINT_COMENUM = 2;

	public const int CPOINT_GETHEARTNUM = 3;

	public const int CPOINT_DISCOVER_TENANT = 4;

	public const int CPOINT_END = 5;

	public const float MULTI_ENDMONEY = 0.1f;

	public const float MULTI_NUMREGULAR = 1000f;

	public const float MULTI_COMENUM = 10f;

	public const float MULTI_GETHEARTNUM = 10f;

	public const float MULTI_DISCOVER_TENANT = 1000f;

	public long[][] clear_point;

	public long ranking_point;

	private int num_lostItem;

	private const int SP_TENANT_BUS = 6;

	private const int SP_TENANT_STATION = 7;

	private const int SP_TENANT_TENBOUDAI = 66;

	private const int SP_TENANT_PURANETA = 84;

	private const int SP_TENANT_HELI = 8;

	private const int SP_TENANT_LIVE = 82;

	private const int SP_TENANT_MUSIAM = 83;

	private const int SP_TENANT_BAKEN = 81;

	private const int SP_TENANT_FUDOU = 79;

	private const int SP_TENANT_BUSSAN = 76;

	private const int SP_TENANT_OKUGAI = 72;

	private const int SP_TENANT_CAJINO = 85;

	private const int SP_TENANT_MOVIE = 17;

	private const int SP_TENANT_HOSPITAL = 33;

	private const int SP_TENANT_AQUA = 38;

	private const int SP_TENANT_BORING = 46;

	private const int SP_TENANT_SENTOU = 47;

	public static PlayerData GetInstance()
	{
		return null;
	}

	public void NewGame()
	{
	}

	public void SetTenantData(TenantData tenantData)
	{
	}

	public void RemoveTenantData(TenantData tenantData)
	{
	}

	public void Update(int add)
	{
	}

	public void Update_ef()
	{
	}

	public void Update_chEvent(int add)
	{
	}

	public void Update_chEventNext(int add)
	{
	}

	public void Update_year()
	{
	}

	public void Update_monthPri()
	{
	}

	public void Update_month()
	{
	}

	public void Update_priMiddleWindow()
	{
	}

	public void Update_week()
	{
	}

	public void SetCustomerInRivalDepart()
	{
	}

	public int GetNumberShop(int purpose_tenantId)
	{
		return 0;
	}

	private void ChangeWeather()
	{
	}

	public void SetNowWeather()
	{
	}

	public void AddHeart(int value)
	{
	}

	public void SubHeart(int value)
	{
	}

	public void SetDapartData()
	{
	}

	public void CalNumDepartObj()
	{
	}

	public void DiscoverTenant(ChipModel new_model)
	{
	}

	public void LostTenant(ChipModel lost_model)
	{
	}

	public void DiscovertCustomer(Customer new_customer)
	{
	}

	public void DiscoverClerk(Clerk new_clerk)
	{
	}

	public int GetSeason(int month)
	{
		return 0;
	}

	public void Update_business()
	{
	}

	public void SetBusinessValue_middleWindow()
	{
	}

	public void SetFlgStore(int chipModel_id)
	{
	}

	public void SetFlgSpFloor(int spFloor_id)
	{
	}

	public void SetFlgItem(int item_id)
	{
	}

	public int GetFeverPoint()
	{
		return 0;
	}

	public int Cal_departSalePoint(int id, int param1)
	{
		return 0;
	}

	public int GetInitDepartPopularPoint()
	{
		return 0;
	}

	public void Regist_departEfPUp(int param)
	{
	}

	public void Update_departEfPUp()
	{
	}

	private void Draw_departEfUpParam(Graphics g, int draw_value, int dx, int dy)
	{
	}

	public void Draw_departEfPUp(Graphics g)
	{
	}

	public void Draw_firework(Graphics g)
	{
	}

	public void SetEf_fireWork(int screen_start_x, int screen_start_y, int dis_y, int wait)
	{
	}

	public void SetEf_fireWork2(int screen_start_x, int screen_start_y, int dis_y, int wait)
	{
	}

	public void Update_rival()
	{
	}

	public int GetDepartRanking(TenantData t_data)
	{
		return 0;
	}

	public bool ChReturnHour()
	{
		return false;
	}

	public bool ChReturnHour(int week, int time)
	{
		return false;
	}

	public bool ChReturnHour_entrance()
	{
		return false;
	}

	public void AddReportMonthPlus(int value, int mode, bool flg_benefit)
	{
	}

	public void AddReportMonthMinus(int value, int mode, bool flg_benefit)
	{
	}

	public int GetAllTenantIncome(int month)
	{
		return 0;
	}

	public int GetAllTenantIncome(int year_state, int month)
	{
		return 0;
	}

	public bool Ch_saleMonth(int month)
	{
		return false;
	}

	public void CreateEquipBuildV()
	{
	}

	public ChipModel GetEquipBuildModel(int equipBuild_id)
	{
		return null;
	}

	public int GetEquipBuildIndex(ChipModel model)
	{
		return 0;
	}

	public int GetClerkIdFromFloor(int floor)
	{
		return 0;
	}

	public void SetTenantKindRate()
	{
	}

	public void SetTenantKindPoint()
	{
	}

	public int[] GetAreaEva()
	{
		return null;
	}

	public void SetDepartSharePoint()
	{
	}

	public bool[] Ch_monthRankUp(int ch_year, int ch_month)
	{
		return null;
	}

	public void DepartRankUp(SubForm form)
	{
	}

	public int GetDepartRankingPrice(int rank)
	{
		return 0;
	}

	public TenantData GetTopTenantOfYear()
	{
		return null;
	}

	public void DrawNumImage_commnma(Graphics g, long value, int dx, int dy)
	{
	}

	public void DrawMoneyNumImage_commnma(Graphics g, long value, int dx, int dy)
	{
	}

	public bool ChTenantExistDepart(int model_id)
	{
		return false;
	}

	public string GetTopicStr(int topic_param)
	{
		return null;
	}

	public void SetClearPoint()
	{
	}

	public void CreateSecondGameParam()
	{
	}

	public void CntCustomerAllTime()
	{
	}

	public void CntLostItem(TenantData t_data)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public void ChSpecialModel()
	{
	}

	public bool ChExistModel(int model_id)
	{
		return false;
	}
}
