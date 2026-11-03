using System.Runtime.Serialization;

namespace System;

[Serializable]
public sealed class MulticastNotSupportedException : SystemException
{
	public MulticastNotSupportedException()
	{
	}

	public MulticastNotSupportedException(string message)
	{
	}

	internal MulticastNotSupportedException(SerializationInfo info, StreamingContext context)
	{
	}
}
