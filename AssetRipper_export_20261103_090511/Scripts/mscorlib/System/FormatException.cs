using System.Runtime.Serialization;

namespace System;

[Serializable]
public class FormatException : SystemException
{
	public FormatException()
	{
	}

	public FormatException(string message)
	{
	}

	public FormatException(string message, Exception innerException)
	{
	}

	protected FormatException(SerializationInfo info, StreamingContext context)
	{
	}
}
