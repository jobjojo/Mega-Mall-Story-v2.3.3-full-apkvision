using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

public struct AsyncTaskMethodBuilder<TResult>
{
	internal static readonly Task<TResult> s_defaultResultTask;

	private AsyncMethodBuilderCore m_coreState;

	private Task<TResult> m_task;

	public Task<TResult> Task => null;

	public static AsyncTaskMethodBuilder<TResult> Create()
	{
		return default;
	}

	[DebuggerStepThrough]
	public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
	{
	}

	public void SetStateMachine(IAsyncStateMachine stateMachine)
	{
	}

	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
	{
	}

	public void SetResult(TResult result)
	{
	}

	public void SetException(Exception exception)
	{
	}

	internal static Task<TResult> GetTaskForResult(TResult result)
	{
		return null;
	}
}
