using java.io;

namespace game_kasa;

public class EffectObj
{
	public bool flg_exist;

	public int img_id;

	public int ef_id;

	public int wait;

	public int stop_time;

	public int[] pos;

	public int[] v;

	public int[] a;

	public int time;

	public int[] DIS;

	public int END_TIME;

	public int[] START_POS;

	public const int EFMODE_VELOCITY = 0;

	public const int EFMODE_V0 = 1;

	public const int EFID_TENANTICON = 0;

	public const int EFID_TENANTICON_NUM = 64;

	internal static int[] ef_param;

	public void SetInitData(int in_img_id, int in_ef_id, int move_mode, int dis_x, int dis_y, int end_time, int in_wait, int in_stopTime, int start_posX, int start_posY)
	{
	}

	public void Update()
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public static int[] GetEffectParam(int img_id, int ef_id)
	{
		return null;
	}

	public int GetWait()
	{
		return 0;
	}
}
