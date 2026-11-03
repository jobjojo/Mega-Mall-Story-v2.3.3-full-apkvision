using System.Runtime.Serialization;

namespace System.Collections.Generic;

[Serializable]
public class KeyNotFoundException : SystemException
{
	public KeyNotFoundException()
	{
	}

	public KeyNotFoundException(string message)
	{
	}

	protected KeyNotFoundException(SerializationInfo info, StreamingContext context)
	{
	}
}
