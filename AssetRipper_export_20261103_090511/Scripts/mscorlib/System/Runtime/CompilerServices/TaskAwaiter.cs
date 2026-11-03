using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

public readonly struct TaskAwaiter : ICriticalNotifyCompletion
{
	internal readonly Task m_task;

	public void UnsafeOnCompleted(Action continuation)
	{
	}

	[StackTraceHidden]
	internal static void ValidateEnd(Task task)
	{
	}

	[StackTraceHidden]
	private static void HandleNonSuccessAndDebuggerNotification(Task task)
	{
	}

	[StackTraceHidden]
	private static void ThrowForNonSuccess(Task task)
	{
	}

	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
	{
	}

	private static Action OutputWaitEtwEvents(Task task, Action continuation)
	{
		return null;
	}
}
public readonly struct TaskAwaiter<TResult> : ICriticalNotifyCompletion
{
	private readonly Task<TResult> m_task = null;

	internal TaskAwaiter(Task<TResult> task)
	{
	}

	public void UnsafeOnCompleted(Action continuation)
	{
	}

	[StackTraceHidden]
	public TResult GetResult()
	{
		return default;
	}
}
