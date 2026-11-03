using System.Runtime.ConstrainedExecution;

namespace System.Threading;

public static class Monitor
{
	public static void Enter(object obj)
	{
	}

	public static void Enter(object obj, ref bool lockTaken)
	{
	}

	private static void ThrowLockTakenException()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void Exit(object obj)
	{
	}

	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext)
	{
		return false;
	}

	public static bool Wait(object obj, int millisecondsTimeout)
	{
		return false;
	}

	public static void Pulse(object obj)
	{
	}

	public static void PulseAll(object obj)
	{
	}

	private static bool Monitor_test_synchronised(object obj)
	{
		return false;
	}

	private static void Monitor_pulse(object obj)
	{
	}

	private static void ObjPulse(object obj)
	{
	}

	private static void Monitor_pulse_all(object obj)
	{
	}

	private static void ObjPulseAll(object obj)
	{
	}

	private static bool Monitor_wait(object obj, int ms)
	{
		return false;
	}

	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj)
	{
		return false;
	}

	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken)
	{
	}

	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken)
	{
	}

	private static void ReliableEnter(object obj, ref bool lockTaken)
	{
	}
}
