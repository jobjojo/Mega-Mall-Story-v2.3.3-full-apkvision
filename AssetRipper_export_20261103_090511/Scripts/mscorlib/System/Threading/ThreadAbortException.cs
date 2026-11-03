using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
[ComVisible(true)]
public sealed class ThreadAbortException : SystemException
{
	private ThreadAbortException()
	{
	}

	internal ThreadAbortException(SerializationInfo info, StreamingContext context)
	{
	}
}
