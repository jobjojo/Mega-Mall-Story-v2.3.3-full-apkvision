using System.Runtime.Serialization;

namespace System;

[Serializable]
public class InvalidCastException : SystemException
{
	public InvalidCastException()
	{
	}

	public InvalidCastException(string message)
	{
	}

	protected InvalidCastException(SerializationInfo info, StreamingContext context)
	{
	}
}
