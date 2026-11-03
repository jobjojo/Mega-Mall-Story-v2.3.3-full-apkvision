using java.util;

namespace game_kasa;

public class GameUtil
{
	public static readonly int[][] DRAW_DIRECT;

	public static readonly int[][] DIRECT;

	public const int UP = 0;

	public const int DOWN = 1;

	public const int LEFT = 2;

	public const int RIGHT = 3;

	private static JRandom random;

	public static int ConvertGameEva(int param)
	{
		return 0;
	}

	public static int RateConvert(int x, int c1min, int c1max, int c2min, int c2max, bool ch_limit)
	{
		return 0;
	}

	public static long RateConvert(long x, long c1min, long c1max, long c2min, long c2max, bool ch_limit)
	{
		return 0L;
	}

	public static float RateConvert(float x, float c1min, float c1max, float c2min, float c2max, bool ch_limit)
	{
		return 0f;
	}

	public static int AddRand(int value, int rand_min, int rand_max, int ret_min, int ret_max)
	{
		return 0;
	}

	public static float RateChA(float a2, float b2, float X)
	{
		return 0f;
	}

	public static float RateChB(float a2, float b2, float X)
	{
		return 0f;
	}

	public int[] Bezier(long x1, long y1, long x2, long y2, long x3, long y3, int t, int[] result)
	{
		return null;
	}

	public static bool ChRectHitRect(int x1, int y1, int w1, int h1, int x2, int y2, int w2, int h2)
	{
		return false;
	}

	public static bool ChRectHitRect(float x1, float y1, float w1, float h1, float x2, float y2, float w2, float h2)
	{
		return false;
	}

	public int Pow(int x, int y)
	{
		return 0;
	}

	public static int Random(int n)
	{
		return 0;
	}

	public static int Clamp(int val, int min, int max)
	{
		return 0;
	}

	public static long Clamp(long val, long min, long max)
	{
		return 0L;
	}

	public static int ClampMin(int val, int min)
	{
		return 0;
	}

	public static int ClampMax(int val, int max)
	{
		return 0;
	}

	public static long ClampMin(long val, long min)
	{
		return 0L;
	}

	public static long ClampMax(long val, long max)
	{
		return 0L;
	}

	public static int ConvertKeyToGameKey(int input_key)
	{
		return 0;
	}

	public static float SetAMSet(float dis, int t1, int t2)
	{
		return 0f;
	}

	public static float SetVStop(float dis, int t)
	{
		return 0f;
	}

	public static float SetAStop(float dis, int t)
	{
		return 0f;
	}

	public static float SetVReturn(float dis, int t)
	{
		return 0f;
	}

	public static float SetAReturn(float dis, int t)
	{
		return 0f;
	}

	public static float SetVVelocity(float dis, int t)
	{
		return 0f;
	}

	public static float SetAVelocity(float dis, int t)
	{
		return 0f;
	}

	public static float Convert_return(float time, int TIME, float DIS)
	{
		return 0f;
	}

	public static float SetVdecreV(float decre_rate, float DIS, int TIME)
	{
		return 0f;
	}

	public static float SetAdecreV(float decre_rate, float DIS, int TIME)
	{
		return 0f;
	}

	public static float SetV(float a, float DIS, int TIME)
	{
		return 0f;
	}

	public static float GetA_fixV0DIS(float v0, float DIS, int TIME)
	{
		return 0f;
	}
}
