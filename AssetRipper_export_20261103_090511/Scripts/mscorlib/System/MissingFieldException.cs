using System.Runtime.Serialization;

namespace System;

[Serializable]
public class MissingFieldException : MissingMemberException, ISerializable
{
	public override string Message => null;

	public MissingFieldException()
	{
	}

	public MissingFieldException(string message)
	{
	}

	public MissingFieldException(string className, string fieldName)
	{
	}

	protected MissingFieldException(SerializationInfo info, StreamingContext context)
	{
	}
}
