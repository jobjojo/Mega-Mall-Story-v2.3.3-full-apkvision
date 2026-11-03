using System.Runtime.Serialization;

namespace System;

[Serializable]
public class UriFormatException : FormatException, ISerializable
{
	public UriFormatException()
	{
	}

	public UriFormatException(string textString)
	{
	}

	protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}
}
