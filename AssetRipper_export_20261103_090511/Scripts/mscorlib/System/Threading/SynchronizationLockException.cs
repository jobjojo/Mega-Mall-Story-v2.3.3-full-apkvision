using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
public class SynchronizationLockException : SystemException
{
	public SynchronizationLockException()
	{
	}

	public SynchronizationLockException(string message)
	{
	}

	protected SynchronizationLockException(SerializationInfo info, StreamingContext context)
	{
	}
}
