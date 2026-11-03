using System.Runtime.Serialization;

namespace System;

[Serializable]
public class BadImageFormatException : SystemException
{
	private string _fileName;

	private string _fusionLog;

	public override string Message => null;

	public BadImageFormatException()
	{
	}

	public BadImageFormatException(string message)
	{
	}

	public BadImageFormatException(string message, Exception inner)
	{
	}

	public BadImageFormatException(string message, string fileName)
	{
	}

	protected BadImageFormatException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private void SetMessageField()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
