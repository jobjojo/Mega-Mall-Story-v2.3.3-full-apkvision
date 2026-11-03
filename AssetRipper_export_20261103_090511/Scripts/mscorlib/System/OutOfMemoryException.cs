using System.Runtime.Serialization;

namespace System;

[Serializable]
public class OutOfMemoryException : SystemException
{
	public OutOfMemoryException()
	{
	}

	public OutOfMemoryException(string message)
	{
	}

	protected OutOfMemoryException(SerializationInfo info, StreamingContext context)
	{
	}
}
