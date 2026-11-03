using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Threading;

[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public abstract class WaitHandle : MarshalByRefObject, IDisposable
{
	public const int WaitTimeout = 258;

	private const int MAX_WAITHANDLES = 64;

	private IntPtr waitHandle;

	internal SafeWaitHandle safeWaitHandle;

	internal bool hasThreadAffinity;

	private const int WAIT_OBJECT_0 = 0;

	private const int WAIT_ABANDONED = 128;

	private const int WAIT_FAILED = int.MaxValue;

	private const int ERROR_TOO_MANY_POSTS = 298;

	private const int ERROR_NOT_OWNED_BY_CALLER = 299;

	protected static readonly IntPtr InvalidHandle;

	internal const int MaxWaitHandles = 64;

	[Obsolete("Use the SafeWaitHandle property instead.")]
	public virtual IntPtr Handle
	{
		get
		{
			return (IntPtr)0;
		}
		set
		{
		}
	}

	public SafeWaitHandle SafeWaitHandle
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		get
		{
			return null;
		}
	}

	private void Init()
	{
	}

	internal void SetHandleInternal(SafeWaitHandle handle)
	{
	}

	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
	{
		return false;
	}

	public virtual bool WaitOne()
	{
		return false;
	}

	public virtual bool WaitOne(int millisecondsTimeout)
	{
		return false;
	}

	private bool WaitOne(long timeout, bool exitContext)
	{
		return false;
	}

	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
	{
		return false;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
	{
		return 0;
	}

	private static void ThrowAbandonedMutexException()
	{
	}

	private static void ThrowAbandonedMutexException(int location, WaitHandle handle)
	{
	}

	public virtual void Close()
	{
	}

	protected virtual void Dispose(bool explicitDisposing)
	{
	}

	public void Dispose()
	{
	}

	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
	{
		return 0;
	}

	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll)
	{
		return 0;
	}

	internal unsafe static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms)
	{
		return 0;
	}
}
