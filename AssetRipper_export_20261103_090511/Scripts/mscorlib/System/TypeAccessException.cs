using System.Runtime.Serialization;

namespace System;

[Serializable]
public class TypeAccessException : TypeLoadException
{
	public TypeAccessException()
	{
	}

	protected TypeAccessException(SerializationInfo info, StreamingContext context)
	{
	}
}
