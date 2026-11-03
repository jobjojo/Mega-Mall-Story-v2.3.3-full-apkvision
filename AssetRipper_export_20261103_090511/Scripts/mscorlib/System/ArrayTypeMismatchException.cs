using System.Runtime.Serialization;

namespace System;

[Serializable]
public class ArrayTypeMismatchException : SystemException
{
	public ArrayTypeMismatchException()
	{
	}

	protected ArrayTypeMismatchException(SerializationInfo info, StreamingContext context)
	{
	}
}
