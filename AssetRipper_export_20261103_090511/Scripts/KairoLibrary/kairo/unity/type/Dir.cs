namespace kairo.unity.type;

public static class Dir
{
	public static readonly int UP;

	public static readonly int RIGHT;

	public static readonly int DOWN;

	public static readonly int LEFT;

	public static readonly int END;

	public static readonly int[][] VECTOR;

	public static readonly int[][] CELL_OFFSET;

	public static readonly int[][] ISOMETRIC_OFFSET;

	public static Point GetIsometricOffset(int dir)
	{
		return default;
	}

	public static Location GetCellOffset(int dir)
	{
		return default;
	}

	public static int GetDirect(int xi1, int yi1, int xi2, int yi2, bool adjacentOnly = true)
	{
		return 0;
	}

	public static int GetDirect(Location loc1, Location loc2, bool adjacentOnly = true)
	{
		return 0;
	}
}
