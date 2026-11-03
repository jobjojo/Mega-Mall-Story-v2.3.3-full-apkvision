using System.Runtime.Serialization;

namespace System;

[Serializable]
public class SystemException : Exception
{
	public SystemException()
	{
	}

	public SystemException(string message)
	{
	}

	public SystemException(string message, Exception innerException)
	{
	}

	protected SystemException(SerializationInfo info, StreamingContext context)
	{
	}
}
