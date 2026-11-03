namespace System;

public class Random
{
	private int _inext;

	private int _inextp;

	private int[] _seedArray;

	[ThreadStatic]
	private static Random t_threadRandom;

	private static readonly Random s_globalRandom;

	public Random()
	{
	}

	public Random(int Seed)
	{
	}

	protected virtual double Sample()
	{
		return 0.0;
	}

	private int InternalSample()
	{
		return 0;
	}

	private static int GenerateSeed()
	{
		return 0;
	}

	private static int GenerateGlobalSeed()
	{
		return 0;
	}

	public virtual int Next()
	{
		return 0;
	}

	private double GetSampleForLargeRange()
	{
		return 0.0;
	}

	public virtual int Next(int minValue, int maxValue)
	{
		return 0;
	}

	public virtual int Next(int maxValue)
	{
		return 0;
	}
}
