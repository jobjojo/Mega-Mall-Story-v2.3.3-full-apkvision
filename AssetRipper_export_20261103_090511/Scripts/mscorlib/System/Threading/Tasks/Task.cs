using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks;

[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<>))]
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
public class Task<TResult> : Task
{
	internal TResult m_result;

	private static TaskFactory<TResult> s_defaultFactory;

	internal TResult ResultOnSuccess => default;

	internal Task()
		: base(canceled: false, TaskCreationOptions.None, default)
	{
	}

	internal Task(TResult result)
		: base(canceled: false, TaskCreationOptions.None, default)
	{
	}

	internal Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct)
		: base(canceled: false, TaskCreationOptions.None, default)
	{
	}

	public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
		: base(canceled: false, TaskCreationOptions.None, default)
	{
	}

	internal Task(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		: base(canceled: false, TaskCreationOptions.None, default)
	{
	}

	internal bool TrySetResult(TResult result)
	{
		return false;
	}

	internal override void InnerInvoke()
	{
	}

	public TaskAwaiter<TResult> GetAwaiter()
	{
		return default;
	}

	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
	{
		return default;
	}
}
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable
{
	internal class ContingentProperties
	{
		internal ExecutionContext m_capturedContext;

		internal ManualResetEventSlim m_completionEvent;

		internal TaskExceptionHolder m_exceptionsHolder;

		internal CancellationToken m_cancellationToken;

		internal object m_cancellationRegistration;

		internal int m_internalCancellationRequested;

		internal int m_completionCountdown;

		internal LowLevelListWithIList<Task> m_exceptionalChildren;

		internal void SetCompleted()
		{
		}

		internal void UnregisterCancellationCallback()
		{
		}
	}

	private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
	{
		public bool InvokeMayRunArbitraryCode => false;

		internal SetOnInvokeMres()
		{
		}

		public void Invoke(Task completingTask)
		{
		}
	}

	private sealed class DelayPromise : Task<VoidTaskResult>
	{
		internal readonly CancellationToken Token;

		internal CancellationTokenRegistration Registration;

		internal Timer Timer;

		internal DelayPromise(CancellationToken token)
		{
		}

		internal void Complete()
		{
		}
	}

	internal static int s_taskIdCounter;

	private int m_taskId;

	internal Delegate m_action;

	internal object m_stateObject;

	internal TaskScheduler m_taskScheduler;

	internal readonly Task m_parent;

	internal int m_stateFlags;

	private const int OptionsMask = 65535;

	internal const int TASK_STATE_STARTED = 65536;

	internal const int TASK_STATE_DELEGATE_INVOKED = 131072;

	internal const int TASK_STATE_DISPOSED = 262144;

	internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288;

	internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576;

	internal const int TASK_STATE_FAULTED = 2097152;

	internal const int TASK_STATE_CANCELED = 4194304;

	internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608;

	internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216;

	internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432;

	internal const int TASK_STATE_COMPLETION_RESERVED = 67108864;

	internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728;

	internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456;

	private const int TASK_STATE_COMPLETED_MASK = 23068672;

	private const int CANCELLATION_REQUESTED = 1;

	private object m_continuationObject;

	private static readonly object s_taskCompletionSentinel;

	internal static bool s_asyncDebuggingEnabled;

	internal ContingentProperties m_contingentProperties;

	private static readonly Action<object> s_taskCancelCallback;

	[ThreadStatic]
	internal static Task t_currentTask;

	[ThreadStatic]
	private static StackGuard t_stackGuard;

	private static readonly Func<ContingentProperties> s_createContingentProperties;

	private static readonly TaskFactory Factory;

	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate;

	private static ContextCallback s_ecCallback;

	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate;

	private static readonly Dictionary<int, Task> s_currentActiveTasks;

	private static readonly object s_activeTasksLock;

	internal TaskCreationOptions Options => TaskCreationOptions.None;

	internal bool IsWaitNotificationEnabledOrNotRanToCompletion
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return false;
		}
	}

	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion => false;

	internal bool IsWaitNotificationEnabled => false;

	public int Id => 0;

	internal static Task InternalCurrent => null;

	internal static StackGuard CurrentStackGuard => null;

	public AggregateException Exception => null;

	public TaskStatus Status => TaskStatus.Created;

	public bool IsCanceled => false;

	internal bool IsCancellationRequested => false;

	internal CancellationToken CancellationToken => default;

	internal bool IsCancellationAcknowledged => false;

	public bool IsCompleted => false;

	public bool IsCompletedSuccessfully => false;

	public TaskCreationOptions CreationOptions => TaskCreationOptions.None;

	WaitHandle IAsyncResult.AsyncWaitHandle => null;

	internal TaskScheduler ExecutingTaskScheduler => null;

	public static Task CompletedTask { get; }

	internal ManualResetEventSlim CompletedEvent => null;

	internal bool ExceptionRecorded => false;

	public bool IsFaulted => false;

	internal ExecutionContext CapturedContext
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool IsExceptionObservedByParent => false;

	internal bool IsDelegateInvoked => false;

	internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
	{
	}

	internal Task()
	{
	}

	internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
	{
	}

	internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
	{
	}

	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
	{
	}

	private static void TaskCancelCallback(object o)
	{
	}

	internal bool TrySetCanceled(CancellationToken tokenToRecord)
	{
		return false;
	}

	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException)
	{
		return false;
	}

	internal bool TrySetException(object exceptionObject)
	{
		return false;
	}

	internal static TaskCreationOptions OptionsMethod(int flags)
	{
		return TaskCreationOptions.None;
	}

	internal bool AtomicStateUpdate(int newBits, int illegalBits)
	{
		return false;
	}

	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
	{
		return false;
	}

	internal void SetNotificationForWaitCompletion(bool enabled)
	{
	}

	internal bool NotifyDebuggerOfWaitCompletionIfNecessary()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void NotifyDebuggerOfWaitCompletion()
	{
	}

	internal bool MarkStarted()
	{
		return false;
	}

	internal void AddNewChild()
	{
	}

	internal void DisregardChild()
	{
	}

	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
	{
		return null;
	}

	internal ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
	{
		return null;
	}

	private ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
	{
		return null;
	}

	private static bool IsCompletedMethod(int flags)
	{
		return false;
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	internal void ScheduleAndStart(bool needsProtection)
	{
	}

	internal void AddException(object exceptionObject)
	{
	}

	internal void AddException(object exceptionObject, bool representsCancellation)
	{
	}

	private AggregateException GetExceptions(bool includeTaskCanceledExceptions)
	{
		return null;
	}

	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
	{
		return null;
	}

	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
	{
		return null;
	}

	internal void Finish(bool bUserDelegateExecuted)
	{
	}

	internal void FinishStageTwo()
	{
	}

	internal void FinishStageThree()
	{
	}

	internal void ProcessChildCompletion(Task childTask)
	{
	}

	internal void AddExceptionsFromChildren()
	{
	}

	private void Execute()
	{
	}

	void IThreadPoolWorkItem.ExecuteWorkItem()
	{
	}

	internal bool ExecuteEntry(bool bPreventDoubleExecution)
	{
		return false;
	}

	private static void ExecutionContextCallback(object obj)
	{
	}

	internal virtual void InnerInvoke()
	{
	}

	private void HandleException(Exception unhandledException)
	{
	}

	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext)
	{
	}

	private bool WrappedTryRunInline()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return false;
	}

	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return false;
	}

	private bool SpinWait(int millisecondsTimeout)
	{
		return false;
	}

	internal bool InternalCancel(bool bCancelNonExecutingOnly)
	{
		return false;
	}

	internal void RecordInternalCancellationRequest()
	{
	}

	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
	{
	}

	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException)
	{
	}

	internal void CancellationCleanupLogic()
	{
	}

	private void SetCancellationAcknowledged()
	{
	}

	internal void FinishContinuations()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void LogFinishCompletionNotification()
	{
	}

	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		return null;
	}

	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
	{
		return null;
	}

	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
	{
		creationOptions = default;
		internalOptions = default;
	}

	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
	{
	}

	internal void AddCompletionAction(ITaskCompletionAction action)
	{
	}

	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
	{
	}

	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers)
	{
		return false;
	}

	private bool AddTaskContinuation(object tc, bool addBeforeOthers)
	{
		return false;
	}

	internal void RemoveContinuation(object continuationObject)
	{
	}

	public static Task<TResult> FromResult<TResult>(TResult result)
	{
		return null;
	}

	internal static Task FromCancellation(CancellationToken cancellationToken)
	{
		return null;
	}

	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
	{
		return null;
	}

	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
	{
		return null;
	}

	public static Task<Task> WhenAny(params Task[] tasks)
	{
		return null;
	}

	[FriendAccessAllowed]
	internal static bool AddToActiveTasks(Task task)
	{
		return false;
	}

	[FriendAccessAllowed]
	internal static void RemoveFromActiveTasks(int taskId)
	{
	}

	public void MarkAborted(ThreadAbortException e)
	{
	}

	private void ExecuteWithThreadLocal(ref Task currentTaskSlot)
	{
	}
}
