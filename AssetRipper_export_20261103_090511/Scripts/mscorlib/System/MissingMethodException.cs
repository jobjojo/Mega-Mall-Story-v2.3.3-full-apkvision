using System.Runtime.Serialization;

namespace System;

[Serializable]
public class MissingMethodException : MissingMemberException
{
	public override string Message => null;

	public MissingMethodException()
	{
	}

	public MissingMethodException(string message)
	{
	}

	public MissingMethodException(string className, string methodName)
	{
	}

	protected MissingMethodException(SerializationInfo info, StreamingContext context)
	{
	}
}
