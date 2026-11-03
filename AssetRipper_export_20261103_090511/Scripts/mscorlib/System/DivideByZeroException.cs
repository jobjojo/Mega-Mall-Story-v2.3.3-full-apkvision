using System.Runtime.Serialization;

namespace System;

[Serializable]
public class DivideByZeroException : ArithmeticException
{
	public DivideByZeroException()
	{
	}

	protected DivideByZeroException(SerializationInfo info, StreamingContext context)
	{
	}
}
