using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

public readonly struct ConfiguredTaskAwaitable<TResult>
{
	public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
	{
		private readonly Task<TResult> m_task = null;

		private readonly bool m_continueOnCapturedContext = false;

		public bool IsCompleted => false;

		internal ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext)
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

	private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter = default;

	internal ConfiguredTaskAwaitable(Task<TResult> task, bool continueOnCapturedContext)
	{
	}

	public ConfiguredTaskAwaiter GetAwaiter()
	{
		return default;
	}
}
