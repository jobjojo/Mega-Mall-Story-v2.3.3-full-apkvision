using System.Collections.Generic;

namespace System.Threading.Tasks;

public class TaskFactory<TResult>
{
	private CancellationToken m_defaultCancellationToken;

	private TaskScheduler m_defaultScheduler;

	private TaskCreationOptions m_defaultCreationOptions;

	private TaskContinuationOptions m_defaultContinuationOptions;

	public TaskFactory()
	{
	}

	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
	}
}
public class TaskFactory
{
	internal sealed class CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction
	{
		private IList<Task> _tasks;

		public bool InvokeMayRunArbitraryCode => false;

		public CompleteOnInvokePromise(IList<Task> tasks)
		{
		}

		public void Invoke(Task completingTask)
		{
		}
	}

	private readonly CancellationToken m_defaultCancellationToken;

	private readonly TaskScheduler m_defaultScheduler;

	private readonly TaskCreationOptions m_defaultCreationOptions;

	private readonly TaskContinuationOptions m_defaultContinuationOptions;

	public TaskFactory()
	{
	}

	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
	}

	internal static void CheckCreationOptions(TaskCreationOptions creationOptions)
	{
	}

	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks)
	{
		return null;
	}

	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
	{
	}
}
