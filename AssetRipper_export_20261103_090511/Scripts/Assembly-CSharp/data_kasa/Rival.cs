using java.io;
using main;

namespace data_kasa;

public class Rival : BaseData
{
	public AppData apdat_;

	public PlayerData p_data;

	private static Rival instance;

	public string name_;

	public int mode_;

	public int rivalCnt_;

	public int[] eva_;

	public int[] strong_;

	public int decline_;

	public int[][] rival_share;

	public int exist_month;

	public int base_incomeData;

	public int[] rival_income;

	public int rival_departLv;

	public const int MODE_SLEEP = 0;

	public const int MODE_NOTAPPEAR = 1;

	public const int MODE_EXIST = 2;

	public const int MODE_TOESCAPE = 3;

	public static readonly string[][] base_name;

	internal int RIVALEVA_GROW_POINT;

	public static Rival GetInstance()
	{
		return null;
	}

	public void NewGame()
	{
	}

	public void Update(int process_time)
	{
	}

	public void Update_month()
	{
	}

	public bool ChExistNow()
	{
		return false;
	}

	public void AppearFirst()
	{
	}

	public void Appear()
	{
	}

	public void Escape()
	{
	}

	public void SetApeearCnt()
	{
	}

	public void DecideName()
	{
	}

	public void SetRivalParam()
	{
	}

	public void SetIncomeParam()
	{
	}

	public void WeakStrongPoint()
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}
