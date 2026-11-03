using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
public class WaitHandleCannotBeOpenedException : ApplicationException
{
	public WaitHandleCannotBeOpenedException()
	{
	}

	public WaitHandleCannotBeOpenedException(string message)
	{
	}

	protected WaitHandleCannotBeOpenedException(SerializationInfo info, StreamingContext context)
	{
	}
}
