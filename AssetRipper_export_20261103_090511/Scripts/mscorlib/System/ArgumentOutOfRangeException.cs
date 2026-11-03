using System.Runtime.Serialization;

namespace System;

[Serializable]
public class ArgumentOutOfRangeException : ArgumentException
{
	private object _actualValue;

	public override string Message => null;

	public ArgumentOutOfRangeException()
	{
	}

	public ArgumentOutOfRangeException(string paramName)
	{
	}

	public ArgumentOutOfRangeException(string paramName, string message)
	{
	}

	public ArgumentOutOfRangeException(string paramName, object actualValue, string message)
	{
	}

	protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
