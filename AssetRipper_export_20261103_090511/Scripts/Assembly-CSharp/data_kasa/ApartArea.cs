using game_kasa;
using java.io;
using java.util;
using main;

namespace data_kasa;

public class ApartArea : BaseData
{
	public AppData apdat_;

	public PlayerData p_data;

	public const int AREA_ID_HOUSE = 0;

	public const int AREA_ID_DEPART = 1;

	public const int AREA_ID_OFFICE = 2;

	public const int AREA_ID_PARK = 3;

	public const int TASK_STATE_INIT = -1;

	public const int TASK_STATE_NONSELECT = 0;

	public const int TASK_STATE_ACTING = 1;

	public const int TASK_STATE_CLEAR = 2;

	public const int EVENT_ID_ELSE = 0;

	public const int EVENT_ID_BUILD = 1;

	public const int EVENT_ID_WEATHER = 2;

	public const int EVENT_ID_BUSINESS = 3;

	public const int EVENT_ID_TENANT = 4;

	public const int EVENT_ID_EXPAND = 5;

	public string name_;

	public int[] base_appearRate_;

	public string explain_;

	public int[] apart_img_id;

	public Vector task_data;

	public int task_lv;

	public int task_index;

	public int task_state;

	public int task_restCnt;

	public int appear_cnt;

	public int appear_rate;

	public int step_rain;

	public int step_business;

	public static string[] AREA_NAME;

	private static Vector temp_customer_v;

	public int num_customer;

	public int num_regular;

	public int appearRate_eva_departTopic;

	public int appearRate_eva_business;

	public int appearRate_eva_popular;

	public int appearRate_eva;

	public float appearRate_weatherMulti;

	public ApartArea(int no, string src)
	{
	}

	public void Load(int no, string src)
	{
	}

	public void NewGame()
	{
	}

	public void Update(int progress_time)
	{
	}

	public void Update_week()
	{
	}

	public static void SetTaskData(ApartArea[] apart_area, ApartProject2[] in_task)
	{
	}

	public Human_K Proc_appearCnt()
	{
		return null;
	}

	public Human_K Proc_appearCntFeverVer()
	{
		return null;
	}

	public Human_K Appear()
	{
		return null;
	}

	public int GetNowAppearNum()
	{
		return 0;
	}

	public void SetNumCustomer()
	{
	}

	public void SetAppearRate()
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}
