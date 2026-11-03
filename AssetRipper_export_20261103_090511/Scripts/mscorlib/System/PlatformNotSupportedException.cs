using System.Runtime.Serialization;

namespace System;

[Serializable]
public class PlatformNotSupportedException : NotSupportedException
{
	public PlatformNotSupportedException()
	{
	}

	public PlatformNotSupportedException(string message)
	{
	}

	protected PlatformNotSupportedException(SerializationInfo info, StreamingContext context)
	{
	}
}
