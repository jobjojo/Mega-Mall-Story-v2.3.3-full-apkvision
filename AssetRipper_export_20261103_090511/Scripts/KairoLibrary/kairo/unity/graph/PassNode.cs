namespace kairo.unity.graph;

internal class PassNode
{
	public int Cost;

	public int Hcost;

	public short Xi;

	public short Yi;

	public short Dist;

	public PassNode From;

	internal sbyte Flag;

	internal const sbyte FLAG_FIX = 1;

	internal const sbyte FLAG_QUEUE = 2;

	internal const sbyte FLAG_GOAL = 4;

	internal const sbyte FLAG_GOAL_GROUP = 8;

	public bool IsFix => false;

	public bool IsGoal => false;

	public bool IsGoalGroup => false;

	internal bool IsQueue => false;

	private PassNode()
	{
	}

	public PassNode(int xi, int yi)
	{
	}

	public PassNode Clone()
	{
		return null;
	}
}
