namespace kairo.unity.ui;

public class DepthInfo
{
	private Seb seb_;

	public int depth;

	public int x;

	public int y;

	public int scale;

	public int start;

	public int length;

	public bool isDefaultDepth;

	private long bound;

	public const int DLINE_X1 = 0;

	public const int DLINE_Y1 = 1;

	public const int DLINE_X2 = 2;

	public const int DLINE_Y2 = 3;

	public const int DLINE_SIZE = 4;

	public int[] depthLines;

	internal DepthInfo(Seb seb)
	{
	}

	internal void CreateDepthLines(int[] sp, int scale)
	{
	}

	public int[] GetBoundingRect(int x = 0, int y = 0)
	{
		return null;
	}

	public void SetBoundingRect(int x, int y, int width, int height)
	{
	}

	public int GetLast()
	{
		return 0;
	}
}
