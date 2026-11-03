using System.Runtime.Serialization;

namespace System;

[Serializable]
public class EntryPointNotFoundException : TypeLoadException
{
	public EntryPointNotFoundException()
	{
	}

	public EntryPointNotFoundException(string message)
	{
	}

	protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context)
	{
	}
}
