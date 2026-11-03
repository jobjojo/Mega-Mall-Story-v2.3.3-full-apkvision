using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
public class SemaphoreFullException : SystemException
{
	public SemaphoreFullException()
	{
	}

	protected SemaphoreFullException(SerializationInfo info, StreamingContext context)
	{
	}
}
