using System.Runtime.Serialization;

namespace System;

[Serializable]
public class TimeoutException : SystemException
{
	public TimeoutException()
	{
	}

	public TimeoutException(string message)
	{
	}

	protected TimeoutException(SerializationInfo info, StreamingContext context)
	{
	}
}
