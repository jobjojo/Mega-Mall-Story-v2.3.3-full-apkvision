using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading;

[ComVisible(false)]
[DebuggerTypeProxy(typeof(SystemThreading_SpinLockDebugView))]
[DebuggerDisplay("IsHeld = {IsHeld}")]
public struct SpinLock(bool enableThreadOwnerTracking)
{
	internal class SystemThreading_SpinLockDebugView
	{
	}

	private int m_owner = 0;

	private static int MAXIMUM_WAITERS;

	public bool IsHeldByCurrentThread
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return false;
		}
	}

	public bool IsThreadOwnerTrackingEnabled
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return false;
		}
	}

	public void Enter(ref bool lockTaken)
	{
	}

	public void TryEnter(int millisecondsTimeout, ref bool lockTaken)
	{
	}

	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken)
	{
	}

	private void DecrementWaiters()
	{
	}

	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void Exit(bool useMemoryBarrier)
	{
	}

	private void ExitSlowPath(bool useMemoryBarrier)
	{
	}
}
