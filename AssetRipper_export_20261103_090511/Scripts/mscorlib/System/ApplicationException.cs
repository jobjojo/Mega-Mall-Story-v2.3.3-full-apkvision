using System.Runtime.Serialization;

namespace System;

[Serializable]
public class ApplicationException : Exception
{
	public ApplicationException()
	{
	}

	public ApplicationException(string message)
	{
	}

	public ApplicationException(string message, Exception innerException)
	{
	}

	protected ApplicationException(SerializationInfo info, StreamingContext context)
	{
	}
}
