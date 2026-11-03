using System.Runtime.ConstrainedExecution;

namespace System.Threading;

public class SynchronizationContext
{
	private SynchronizationContextProperties _props;

	private static Type s_cachedPreparedType1;

	private static Type s_cachedPreparedType2;

	private static Type s_cachedPreparedType3;

	private static Type s_cachedPreparedType4;

	private static Type s_cachedPreparedType5;

	public static SynchronizationContext Current => null;

	internal static SynchronizationContext CurrentExplicit => null;

	public bool IsWaitNotificationRequired()
	{
		return false;
	}

	public virtual void Send(SendOrPostCallback d, object state)
	{
	}

	public virtual void Post(SendOrPostCallback d, object state)
	{
	}

	[PrePrepareMethod]
	[CLSCompliant(false)]
	public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
	{
		return 0;
	}

	[PrePrepareMethod]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[CLSCompliant(false)]
	protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
	{
		return 0;
	}

	public static void SetSynchronizationContext(SynchronizationContext syncContext)
	{
	}

	private static SynchronizationContext GetThreadLocalContext()
	{
		return null;
	}

	public virtual SynchronizationContext CreateCopy()
	{
		return null;
	}
}
