using System.Runtime.Serialization;

namespace System;

[Serializable]
public class ObjectDisposedException : InvalidOperationException
{
	private string _objectName;

	public override string Message => null;

	public string ObjectName => null;

	private ObjectDisposedException()
	{
	}

	public ObjectDisposedException(string objectName)
	{
	}

	public ObjectDisposedException(string objectName, string message)
	{
	}

	protected ObjectDisposedException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
