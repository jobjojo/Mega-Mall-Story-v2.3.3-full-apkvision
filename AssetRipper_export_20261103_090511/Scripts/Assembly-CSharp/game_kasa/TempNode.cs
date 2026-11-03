using data_kasa;
using java.util;

namespace game_kasa;

public class TempNode
{
	public static TempNode instance;

	public static int COST_ROUTE;

	public static int COST_STAIR_1;

	public static int COST_STAIR_2;

	public static int COST_ESCALATOR;

	public static int COST_ELEVATOR;

	public Vector node;

	public static TempNode GetInstance()
	{
		return null;
	}

	public void Init()
	{
	}

	public void ClearNodeData()
	{
	}

	public int Main(MovePoint goal_point)
	{
		return 0;
	}

	public MovePoint MainReturn()
	{
		return null;
	}

	public MovePoint GetMinNode()
	{
		return null;
	}

	public Vector GetRouteData(MovePoint start_point, MovePoint goal_point)
	{
		return null;
	}

	public Vector GetRouteDataReturn(MovePoint start_point)
	{
		return null;
	}

	public void Build_step(ChipModel model, int address_x, int address_y, int direct)
	{
	}

	public void Build_elevator(int address_x, int address_y)
	{
	}

	public void Destruct_step(MovePoint move_point)
	{
	}

	public void Destruct_elevator(int tx, int start_y, int end_y)
	{
	}

	public void SetMovePathData()
	{
	}

	public void Debug_dispOut_movingData()
	{
	}
}
