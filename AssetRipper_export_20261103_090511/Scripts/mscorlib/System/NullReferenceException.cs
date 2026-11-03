using System.Runtime.Serialization;

namespace System;

[Serializable]
public class NullReferenceException : SystemException
{
	public NullReferenceException()
	{
	}

	public NullReferenceException(string message)
	{
	}

	protected NullReferenceException(SerializationInfo info, StreamingContext context)
	{
	}
}
