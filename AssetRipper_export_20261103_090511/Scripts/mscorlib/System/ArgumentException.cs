using System.Runtime.Serialization;

namespace System;

[Serializable]
public class ArgumentException : SystemException
{
	private string _paramName;

	public override string Message => null;

	public ArgumentException()
	{
	}

	public ArgumentException(string message)
	{
	}

	public ArgumentException(string message, Exception innerException)
	{
	}

	public ArgumentException(string message, string paramName)
	{
	}

	protected ArgumentException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
