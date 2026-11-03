using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Threading;

[DebuggerDisplay("Current Count = {m_currentCount}")]
[ComVisible(false)]
public class SemaphoreSlim : IDisposable
{
	private sealed class TaskNode : Task<bool>, IThreadPoolWorkItem
	{
		internal TaskNode Prev;

		internal TaskNode Next;

		internal TaskNode()
		{
		}

		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
		}

		void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWaitUntilCountOrTimeoutAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public TaskNode asyncWaiter;

		public int millisecondsTimeout;

		public SemaphoreSlim _003C_003E4__this;

		private CancellationTokenSource _003Ccts_003E5__2;

		private object _003C_003E7__wrap2;

		private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private int m_currentCount;

	private readonly int m_maxCount;

	private int m_waitCount;

	private object m_lockObj;

	private ManualResetEvent m_waitHandle;

	private TaskNode m_asyncHead;

	private TaskNode m_asyncTail;

	private static readonly Task<bool> s_trueTask;

	private static readonly Task<bool> s_falseTask;

	private const int NO_MAXIMUM = int.MaxValue;

	private static Action<object> s_cancellationTokenCanceledEventHandler;

	public SemaphoreSlim(int initialCount, int maxCount)
	{
	}

	public void Wait()
	{
	}

	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return false;
	}

	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
	{
		return false;
	}

	public Task WaitAsync()
	{
		return null;
	}

	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return null;
	}

	private TaskNode CreateAndAddAsyncWaiter()
	{
		return null;
	}

	private bool RemoveAsyncWaiter(TaskNode task)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CWaitUntilCountOrTimeoutAsync_003Ed__32))]
	private Task<bool> WaitUntilCountOrTimeoutAsync(TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return null;
	}

	public int Release()
	{
		return 0;
	}

	public int Release(int releaseCount)
	{
		return 0;
	}

	private static void QueueWaiterTask(TaskNode waiterTask)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	private static void CancellationTokenCanceledEventHandler(object obj)
	{
	}

	private void CheckDispose()
	{
	}

	private static string GetResourceString(string str)
	{
		return null;
	}
}
