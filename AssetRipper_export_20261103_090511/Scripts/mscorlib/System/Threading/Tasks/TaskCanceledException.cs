using System.Runtime.Serialization;

namespace System.Threading.Tasks;

[Serializable]
public class TaskCanceledException : OperationCanceledException
{
	[NonSerialized]
	private readonly Task _canceledTask;

	public TaskCanceledException()
	{
	}

	public TaskCanceledException(Task task)
	{
	}

	protected TaskCanceledException(SerializationInfo info, StreamingContext context)
	{
	}
}
