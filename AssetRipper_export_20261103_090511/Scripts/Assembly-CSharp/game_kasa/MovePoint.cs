using java.util;

namespace game_kasa;

public class MovePoint
{
	public int flg_connect;

	public int step_direct;

	public int[] address;

	public int[] upper_address;

	public int[] downer_address;

	public const int FLG_NOTEXIST = 0;

	public const int FLG_ELEVATOR = 2;

	public const int FLG_UP_STEP_STAIR_1 = 4;

	public const int FLG_UP_STEP_STAIR_2 = 8;

	public const int FLG_UP_STEP_ESCALATOR = 16;

	public const int FLG_DOWN_STEP_STAIR_1 = 32;

	public const int FLG_DOWN_STEP_STAIR_2 = 64;

	public const int FLG_DOWN_STEP_ESCALATOR = 128;

	public const int FLG_CUSTOMER = 256;

	public Vector edges_to;

	public Vector edges_cost;

	public bool done;

	public int cost;

	public MovePoint from;

	public MovePoint(int address_x, int address_y)
	{
	}

	public void ClearMoveRouteData()
	{
	}
}
