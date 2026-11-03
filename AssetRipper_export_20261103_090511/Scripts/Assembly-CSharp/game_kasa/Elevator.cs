using data_kasa;
using java.io;

namespace game_kasa;

public class Elevator
{
	public int mode;

	public int door_cnt;

	public int wait_cnt;

	public int[] pro_inElevator;

	public const int MODE_OPEN = 0;

	public const int MODE_CLOSE = 1;

	public const int MODE_OPEN_C = 2;

	public const int MODE_CLOSE_O = 3;

	public static int MAX_NUM;

	public static int MAX_ANIMECNT;

	public static int MAX_WAIT_OUTCUSTOMER;

	public static int MAX_TO_CLOSE;

	public static int MAX_WAIT_TO_OPEN;

	public const int MAX_PROCESSTION = 4;

	public Tenant tenant;

	public int frame;

	public int animeF;

	public int num_inElevator;

	public Elevator(Tenant in_tenant)
	{
	}

	public void Update()
	{
	}

	public void SetAnime()
	{
	}

	public bool ChOpen()
	{
		return false;
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}
