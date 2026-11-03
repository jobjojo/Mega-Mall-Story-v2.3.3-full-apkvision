namespace data_kasa;

public class Service : BaseData
{
	public string name_;

	public int kind_;

	public int quality_;

	public int topic_;

	public int serving_;

	public int romance_;

	public int income_;

	public int upkeep_;

	public int stockMax_;

	public int buy_price_;

	public string explain_;

	public int challenge_cost_;

	public int challenge_difficult_;

	public const int KIND_NORMAL = 0;

	public const int KIND_LOVE = 1;

	public const int KIND_SPEND = 2;

	public const int KIND_ATTACK = 3;

	public const int KIND_LIMIT = 4;

	public const int FLAG_INIT = 1;

	public const int HIGHQUALITYITEM_ID = 0;

	public static int RATE_GETHQITEM;

	public Service(int no, string src)
	{
	}

	public void Load(int no, string src)
	{
	}
}
