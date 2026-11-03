using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
[ComVisible(true)]
public class ThreadInterruptedException : SystemException
{
	public ThreadInterruptedException()
	{
	}

	public ThreadInterruptedException(string message)
	{
	}

	protected ThreadInterruptedException(SerializationInfo info, StreamingContext context)
	{
	}
}
