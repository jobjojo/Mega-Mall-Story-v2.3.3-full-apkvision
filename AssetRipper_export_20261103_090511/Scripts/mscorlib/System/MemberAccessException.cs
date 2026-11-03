using System.Runtime.Serialization;

namespace System;

[Serializable]
public class MemberAccessException : SystemException
{
	public MemberAccessException()
	{
	}

	public MemberAccessException(string message)
	{
	}

	protected MemberAccessException(SerializationInfo info, StreamingContext context)
	{
	}
}
