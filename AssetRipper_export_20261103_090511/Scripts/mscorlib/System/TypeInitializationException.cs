using System.Runtime.Serialization;

namespace System;

[Serializable]
public sealed class TypeInitializationException : SystemException
{
	private string _typeName;

	public string TypeName => null;

	private TypeInitializationException()
	{
	}

	public TypeInitializationException(string fullTypeName, Exception innerException)
	{
	}

	internal TypeInitializationException(string fullTypeName, string message, Exception innerException)
	{
	}

	internal TypeInitializationException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
