using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System;

public static class Math
{
	private static double doubleRoundLimit;

	private static double[] roundPower10Double;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Abs(int value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Abs(long value)
	{
		return 0L;
	}

	[StackTraceHidden]
	private static void ThrowAbsOverflow()
	{
	}

	public static int DivRem(int a, int b, out int result)
	{
		result = default;
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Clamp(int value, int min, int max)
	{
		return 0;
	}

	public static double Max(double val1, double val2)
	{
		return 0.0;
	}

	[NonVersionable]
	public static int Max(int val1, int val2)
	{
		return 0;
	}

	[NonVersionable]
	public static long Max(long val1, long val2)
	{
		return 0L;
	}

	public static float Max(float val1, float val2)
	{
		return 0f;
	}

	[NonVersionable]
	[CLSCompliant(false)]
	public static uint Max(uint val1, uint val2)
	{
		return 0u;
	}

	public static double Min(double val1, double val2)
	{
		return 0.0;
	}

	[NonVersionable]
	public static int Min(int val1, int val2)
	{
		return 0;
	}

	[NonVersionable]
	public static long Min(long val1, long val2)
	{
		return 0L;
	}

	public static float Min(float val1, float val2)
	{
		return 0f;
	}

	[CLSCompliant(false)]
	[NonVersionable]
	public static uint Min(uint val1, uint val2)
	{
		return 0u;
	}

	public static double Round(double a)
	{
		return 0.0;
	}

	public static int Sign(double value)
	{
		return 0;
	}

	public static int Sign(long value)
	{
		return 0;
	}

	private static void ThrowMinMaxException<T>(T min, T max)
	{
	}

	public static double Abs(double value)
	{
		return 0.0;
	}

	public static float Abs(float value)
	{
		return 0f;
	}

	public static double Acos(double d)
	{
		return 0.0;
	}

	public static double Asin(double d)
	{
		return 0.0;
	}

	public static double Atan(double d)
	{
		return 0.0;
	}

	public static double Atan2(double y, double x)
	{
		return 0.0;
	}

	public static double Ceiling(double a)
	{
		return 0.0;
	}

	public static double Cos(double d)
	{
		return 0.0;
	}

	public static double Floor(double d)
	{
		return 0.0;
	}

	public static double Pow(double x, double y)
	{
		return 0.0;
	}

	public static double Sin(double a)
	{
		return 0.0;
	}

	public static double Sqrt(double d)
	{
		return 0.0;
	}

	public static double Tan(double a)
	{
		return 0.0;
	}
}
