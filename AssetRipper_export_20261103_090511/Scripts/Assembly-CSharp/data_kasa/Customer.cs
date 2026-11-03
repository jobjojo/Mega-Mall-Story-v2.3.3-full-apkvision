using game_kasa;
using java.io;

namespace data_kasa;

public class Customer : BaseData
{
	public string name_;

	public string job_;

	public int imgId_;

	public int apartArea_id_;

	public int appearApart_taskId_;

	public int money_;

	public int[] hobby_;

	public int[] toRegular_kind;

	public int[] toRegular_param;

	public string toRegular_hintParam;

	public string toRegular_hint;

	public int regularBonus_id_;

	public int regularBonus_param_;

	public int[] regular_commentId;

	public int buy_num;

	public int satisfactory_grade;

	public new int flag_;

	public bool flg_inDepart;

	public bool flg_inRivalDepart;

	public int regular_info;

	public int num_comeDepart;

	public int param_happy;

	public int num_buyItem;

	public int[] toRegular_numCome;

	public int satisfactory_lv;

	public const int FLAG_INIT = 1;

	public const int FLAG_REGULAR = 2;

	public const int CUSTOMER_ID_ITIGEN = 0;

	public const int CUSTOMER_ID_REGULAR = 1;

	public const int CUSTOMER_ID_CLERK = 2;

	public static readonly int[][] SATISFACTORY_PARAM;

	public static int CLERK_OFFSET;

	public const int REGULAR_BONUS_ID_NONE = 0;

	public const int REGULAR_BONUS_ID_TENANT = 1;

	public const int REGULAR_BONUS_ID_CUSTOMER = 2;

	public const int REGULAR_BONUS_ID_HEART = 3;

	public const int REGULAR_BONUS_ID_POPULAR = 4;

	public const int REGULAR_BONUS_ID_CLERK = 5;

	public const int REGULAR_BONUS_ID_MONEY = 6;

	public const string HISHOKO_NAME = "姫山ﾃﾞﾊﾟｰｺ";

	public const string PUMPKIN_NAME = "ﾊﾟﾝﾌﾟｷﾝ商会";

	public static int ID_KAIRO;

	public static int ID_ABUFARA;

	public static int ID_TINPANG;

	public static int ID_SOFUKO;

	public int regular_chipModelId;

	public Customer(int no, string src)
	{
	}

	public Customer()
	{
	}

	public void Load(int no, string src)
	{
	}

	public void NewGame()
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public void Depart_out()
	{
	}

	public void Set_regularRoadParam(Human_K human_k, int tenant_id, TenantData t_data)
	{
	}

	public bool Ch_regularRoadTenant(Human_K human_k, int tenant_id)
	{
		return false;
	}

	public int GetSatisfactoryPoint(int satisfactory_id, int satisfactory_lv)
	{
		return 0;
	}

	public static void SetSpecislCharaId()
	{
	}
}
