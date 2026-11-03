namespace System.Threading;

public class CancellationTokenSource : IDisposable
{
	private sealed class Linked1CancellationTokenSource : CancellationTokenSource
	{
		private readonly CancellationTokenRegistration _reg1;

		internal Linked1CancellationTokenSource(CancellationToken token1)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}

	private sealed class Linked2CancellationTokenSource : CancellationTokenSource
	{
		private readonly CancellationTokenRegistration _reg1;

		private readonly CancellationTokenRegistration _reg2;

		internal Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}

	private sealed class LinkedNCancellationTokenSource : CancellationTokenSource
	{
		internal static readonly Action<object> s_linkedTokenCancelDelegate;
	}

	internal static readonly CancellationTokenSource s_canceledSource;

	internal static readonly CancellationTokenSource s_neverCanceledSource;

	private static readonly int s_nLists;

	private ManualResetEvent _kernelEvent;

	private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists;

	private const int CannotBeCanceled = 0;

	private const int NotCanceledState = 1;

	private const int NotifyingState = 2;

	private const int NotifyingCompleteState = 3;

	private int _state;

	private int _threadIDExecutingCallbacks;

	private bool _disposed;

	private CancellationCallbackInfo _executingCallback;

	private Timer _timer;

	private static readonly TimerCallback s_timerCallback;

	public bool IsCancellationRequested => false;

	internal bool IsCancellationCompleted => false;

	internal bool IsDisposed => false;

	internal int ThreadIDExecutingCallbacks
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public CancellationToken Token => default;

	internal CancellationCallbackInfo ExecutingCallback => null;

	public void Cancel()
	{
	}

	public void Cancel(bool throwOnFirstException)
	{
	}

	private static void TimerCallbackLogic(object obj)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	internal void ThrowIfDisposed()
	{
	}

	private static void ThrowObjectDisposedException()
	{
	}

	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext)
	{
		return default;
	}

	private void NotifyCancellation(bool throwOnFirstException)
	{
	}

	private void ExecuteCallbackHandlers(bool throwOnFirstException)
	{
	}

	private void CancellationCallbackCoreWork_OnSyncContext(object obj)
	{
	}

	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args)
	{
	}

	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
	{
		return null;
	}

	internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token)
	{
		return null;
	}

	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo)
	{
	}
}
