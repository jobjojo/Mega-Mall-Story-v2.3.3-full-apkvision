using System.Diagnostics;

namespace System.Threading;

[DebuggerDisplay("Set = {IsSet}")]
public class ManualResetEventSlim : IDisposable
{
	private const int DEFAULT_SPIN_SP = 1;

	private object m_lock;

	private ManualResetEvent m_eventObj;

	private int m_combinedState;

	private const int SignalledState_BitMask = int.MinValue;

	private const int SignalledState_ShiftCount = 31;

	private const int Dispose_BitMask = 1073741824;

	private const int SpinCountState_BitMask = 1073217536;

	private const int SpinCountState_ShiftCount = 19;

	private const int SpinCountState_MaxValue = 2047;

	private const int NumWaitersState_BitMask = 524287;

	private const int NumWaitersState_ShiftCount = 0;

	private const int NumWaitersState_MaxValue = 524287;

	private static Action<object> s_cancellationTokenCallback;

	public WaitHandle WaitHandle => null;

	public bool IsSet
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public int SpinCount
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	private int Waiters
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public ManualResetEventSlim()
	{
	}

	public ManualResetEventSlim(bool initialState)
	{
	}

	public ManualResetEventSlim(bool initialState, int spinCount)
	{
	}

	private void Initialize(bool initialState, int spinCount)
	{
	}

	private void EnsureLockObjectCreated()
	{
	}

	private bool LazyInitializeEvent()
	{
		return false;
	}

	public void Set()
	{
	}

	private void Set(bool duringCancellation)
	{
	}

	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return false;
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	private void ThrowIfDisposed()
	{
	}

	private static void CancellationTokenCallback(object obj)
	{
	}

	private void UpdateStateAtomically(int newBits, int updateBitsMask)
	{
	}

	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount)
	{
		return 0;
	}

	private static int ExtractStatePortion(int state, int mask)
	{
		return 0;
	}
}
