namespace System.Threading.Tasks;

internal sealed class ContinuationTaskFromTask : Task
{
	private Task m_antecedent;

	public ContinuationTaskFromTask(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		: base(canceled: false, TaskCreationOptions.None, default)
	{
	}

	internal override void InnerInvoke()
	{
	}
}
