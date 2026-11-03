namespace data_kasa;

public class Clerk : BaseData
{
	public string name_;

	public int imgId_;

	public int sebId_walk;

	public int sebId_action;

	public string comeFrom_;

	public string age_;

	public int tender_;

	public int sharp_;

	public int contract_;

	public int salary_;

	public int bonus_tenantKind_;

	public int bonus_param_;

	public string explain_;

	public int talkId_employ_;

	public int talkId_sack_;

	public int needHeartNum_;

	public int appear_lv_;

	public new int flag_;

	public const int FLAG_INIT = 1;

	public static int DISCOVER_RARESKILL;

	public Clerk(int no, string src)
	{
	}

	public void Load(int no, string src)
	{
	}
}
