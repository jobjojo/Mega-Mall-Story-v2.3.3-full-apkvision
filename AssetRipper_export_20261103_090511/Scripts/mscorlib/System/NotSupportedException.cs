using System.Runtime.Serialization;

namespace System;

[Serializable]
public class NotSupportedException : SystemException
{
	public NotSupportedException()
	{
	}

	public NotSupportedException(string message)
	{
	}

	protected NotSupportedException(SerializationInfo info, StreamingContext context)
	{
	}
}
