namespace data_kasa;

public class ChipModel : BaseData
{
	public int sort_;

	public string name_;

	public string base_name_;

	public int[] quality_;

	public int[] topic_;

	public int[] serving_;

	public int[] romance_;

	public int[] income_;

	public int[] upkeep_;

	public int[] stock_;

	public int build_cost_;

	public int buy_price_;

	public int[] necess_lvUpNum;

	public int[] bonus_lvUp;

	public int num_itemEquip;

	public int[] service_id;

	public int rareItem_id;

	public int[] like_floor;

	public int season_id;

	public int kind_;

	public int category_;

	public int img_;

	public int seb_;

	public int frame_;

	public int type_;

	public int size_yoko_;

	public int size_tate_;

	public int[] screen_offset;

	public int[][] mpoint_data;

	public int haveNum_;

	public string explain_;

	public int proc_id_;

	public int regiIcon_id_;

	public int getItemIcon_id_;

	public int[] fukidashi_id_;

	public int store_lv_;

	public int getHeart_min_;

	public int getHeart_max_;

	public int removal_;

	public int buildWait_;

	public const int CATEGORY_ENVIRONMENT = 0;

	public const int CATEGORY_WORKSHOP = 1;

	public const int CATEGORY_SIGHTSEEING = 2;

	public const int FLAG_INIT = 1;

	public const int FLAG_CONTINUE = 2;

	public const int FLAG_TRAIN = 4;

	public const int FLAG_HELI = 8;

	public const int FLAG_BUS = 16;

	public const int FLAG_BUILD_ONLY_GROUND = 32;

	public const int FLAG_BUILD_ONLY_UNDERG = 64;

	public ChipModel()
	{
	}

	public ChipModel(int no, string src)
	{
	}

	public void Load(int no, string src)
	{
	}

	public int GetNumNextLvUp(int now_lv)
	{
		return 0;
	}

	public int GetLvUpBonus(int now_lv)
	{
		return 0;
	}

	public int GetWidthNum()
	{
		return 0;
	}

	public int GetHeightNum()
	{
		return 0;
	}
}
