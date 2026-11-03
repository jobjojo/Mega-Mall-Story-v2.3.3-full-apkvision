using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading;

public static class Interlocked
{
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int CompareExchange(ref int location1, int value, int comparand)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static object CompareExchange(ref object location1, object value, object comparand)
	{
		return null;
	}

	public static float CompareExchange(ref float location1, float value, float comparand)
	{
		return 0f;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int Decrement(ref int location)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int Increment(ref int location)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int Exchange(ref int location1, int value)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static void Exchange(ref object location1, ref object value, ref object result)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static object Exchange(ref object location1, object value)
	{
		return null;
	}

	public static float Exchange(ref float location1, float value)
	{
		return 0f;
	}

	public static long CompareExchange(ref long location1, long value, long comparand)
	{
		return 0L;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand)
	{
		return (IntPtr)0;
	}

	public static double CompareExchange(ref double location1, double value, double comparand)
	{
		return 0.0;
	}

	[ComVisible(false)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[Intrinsic]
	public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
	{
		return null;
	}

	public static long Exchange(ref long location1, long value)
	{
		return 0L;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value)
	{
		return (IntPtr)0;
	}

	public static double Exchange(ref double location1, double value)
	{
		return 0.0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[Intrinsic]
	[ComVisible(false)]
	public static T Exchange<T>(ref T location1, T value) where T : class
	{
		return null;
	}

	public static long Read(ref long location)
	{
		return 0L;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int Add(ref int location1, int value)
	{
		return 0;
	}

	public static void MemoryBarrier()
	{
	}
}
