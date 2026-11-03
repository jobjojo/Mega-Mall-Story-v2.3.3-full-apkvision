using System.Collections.Generic;
using kairo.unity.type;

namespace kairo.unity.graph;

public class PassFinder
{
	private int[][] graph_;

	private static PassNode[] routeQueue_;

	private int routeQueueIndex_;

	private int routeQueueSize_;

	private static PassNode[][] route_;

	private const int ONE_STEP_COST = 10;

	public void Init(int[][] map)
	{
	}

	public Location[] Search(int xi1, int yi1, int xi2, int yi2, int priorityDir = -1)
	{
		return null;
	}

	public Location[] Search(int xi1, int yi1, int xi2, int yi2, out int routeCost, int priorityDir = -1)
	{
		routeCost = default;
		return null;
	}

	public Location[] Search(Location start, Location goal, int priorityDir = -1)
	{
		return null;
	}

	public Location[] Search(Location start, Location goal, out int routeCost, int priorityDir = -1)
	{
		routeCost = default;
		return null;
	}

	public Location[] Search(int xi, int yi, Rect goal, int priorityDir = -1)
	{
		return null;
	}

	public Location[] Search(int xi, int yi, Rect goal, out int routeCost, int priorityDir = -1)
	{
		routeCost = default;
		return null;
	}

	public Location[] Search(Location start, Rect goal, int priorityDir = -1)
	{
		return null;
	}

	public Location[] Search(Location start, Rect goal, out int routeCost, int priorityDir = -1)
	{
		routeCost = default;
		return null;
	}

	public Location[] Search(Location start, List<Location> goals, int priorityDir = -1)
	{
		return null;
	}

	public Location[] Search(Location start, List<Location> goals, out int routeCost, int priorityDir = -1)
	{
		routeCost = default;
		return null;
	}
}
