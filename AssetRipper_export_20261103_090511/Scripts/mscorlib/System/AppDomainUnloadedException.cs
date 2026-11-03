using System.Runtime.Serialization;

namespace System;

[Serializable]
public class AppDomainUnloadedException : SystemException
{
	public AppDomainUnloadedException()
	{
	}

	protected AppDomainUnloadedException(SerializationInfo info, StreamingContext context)
	{
	}
}
