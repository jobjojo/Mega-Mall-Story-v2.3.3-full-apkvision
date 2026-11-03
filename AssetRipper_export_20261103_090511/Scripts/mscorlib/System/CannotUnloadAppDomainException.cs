using System.Runtime.Serialization;

namespace System;

[Serializable]
public class CannotUnloadAppDomainException : SystemException
{
	public CannotUnloadAppDomainException()
	{
	}

	public CannotUnloadAppDomainException(string message)
	{
	}

	protected CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context)
	{
	}
}
