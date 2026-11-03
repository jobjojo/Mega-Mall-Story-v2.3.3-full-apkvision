using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
public class ThreadStateException : SystemException
{
	public ThreadStateException()
	{
	}

	public ThreadStateException(string message)
	{
	}

	protected ThreadStateException(SerializationInfo info, StreamingContext context)
	{
	}
}
