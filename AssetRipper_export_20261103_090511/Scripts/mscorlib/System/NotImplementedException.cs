using System.Runtime.Serialization;

namespace System;

[Serializable]
public class NotImplementedException : SystemException
{
	public NotImplementedException()
	{
	}

	public NotImplementedException(string message)
	{
	}

	protected NotImplementedException(SerializationInfo info, StreamingContext context)
	{
	}
}
