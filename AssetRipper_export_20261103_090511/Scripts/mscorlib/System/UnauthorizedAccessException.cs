using System.Runtime.Serialization;

namespace System;

[Serializable]
public class UnauthorizedAccessException : SystemException
{
	public UnauthorizedAccessException()
	{
	}

	public UnauthorizedAccessException(string message)
	{
	}

	public UnauthorizedAccessException(string message, Exception inner)
	{
	}

	protected UnauthorizedAccessException(SerializationInfo info, StreamingContext context)
	{
	}
}
