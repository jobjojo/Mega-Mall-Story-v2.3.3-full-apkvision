using System.Runtime.Serialization;

namespace System;

[Serializable]
public class DllNotFoundException : TypeLoadException
{
	public DllNotFoundException()
	{
	}

	public DllNotFoundException(string message)
	{
	}

	protected DllNotFoundException(SerializationInfo info, StreamingContext context)
	{
	}
}
