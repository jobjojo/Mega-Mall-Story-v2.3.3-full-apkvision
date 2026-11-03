using System.Runtime.Serialization;

namespace System;

[Serializable]
public class MethodAccessException : MemberAccessException
{
	public MethodAccessException()
	{
	}

	public MethodAccessException(string message)
	{
	}

	protected MethodAccessException(SerializationInfo info, StreamingContext context)
	{
	}
}
