using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
public class AbandonedMutexException : SystemException
{
	private int _mutexIndex;

	private Mutex _mutex;

	public AbandonedMutexException()
	{
	}

	public AbandonedMutexException(int location, WaitHandle handle)
	{
	}

	protected AbandonedMutexException(SerializationInfo info, StreamingContext context)
	{
	}

	private void SetupException(int location, WaitHandle handle)
	{
	}
}
