using System.Runtime.Serialization;

namespace System.Threading.Tasks;

[Serializable]
public class TaskSchedulerException : Exception
{
	public TaskSchedulerException()
	{
	}

	public TaskSchedulerException(Exception innerException)
	{
	}

	protected TaskSchedulerException(SerializationInfo info, StreamingContext context)
	{
	}
}
