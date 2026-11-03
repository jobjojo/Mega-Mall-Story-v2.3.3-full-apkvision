namespace data_kasa;

public class ApartProject2 : BaseData
{
	public string name_;

	public int area_id_;

	public int block_id_;

	public int task_id_;

	public string comment_;

	public int c_id;

	public string name_request_;

	public int cost_;

	public int develop_term_;

	public int event_id_;

	public int[] term_tenantId_;

	public int[] term_tenantLv_;

	public int event_param_;

	public new int flag_;

	public const int FLAG_INIT = 1;

	public const int FLAG_PLEASE = 2;

	public ApartProject2(int no, string src)
	{
	}

	public ApartProject2()
	{
	}

	public void Load(int no, string src)
	{
	}
}
