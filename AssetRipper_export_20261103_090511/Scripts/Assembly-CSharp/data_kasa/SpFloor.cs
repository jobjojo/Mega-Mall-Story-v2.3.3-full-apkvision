namespace data_kasa;

public class SpFloor : BaseData
{
	public string name_;

	public int[] spFloorId;

	public int quality_;

	public int topic_;

	public int serving_;

	public int romance_;

	public int income_;

	public int rangeEffect_;

	public string explain_;

	public int buy_price_;

	public int store_lv_;

	public const int FLAG_INIT = 1;

	public SpFloor()
	{
	}

	public SpFloor(int no, string src)
	{
	}

	public void Load(int no, string src)
	{
	}

	public static void SetSpFloorData(int floor, bool flg_effect)
	{
	}

	public static void SetEquipmentBonus(int floor, bool flg_ef)
	{
	}

	public static void Ch_spFloorMain(Tenant build_tenant)
	{
	}

	private static int Ch_spFloor(Tenant t1, Tenant t2, Tenant t3)
	{
		return 0;
	}

	private static Tenant ChPutTenant(Tenant base_t, int direct)
	{
		return null;
	}

	public static void SetDepartSpFloorInfo()
	{
	}

	public static void SetDepartSpFloorBuild()
	{
	}
}
