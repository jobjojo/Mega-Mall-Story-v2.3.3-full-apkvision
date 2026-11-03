using System.Runtime.Serialization;

namespace System.Runtime.CompilerServices;

[Serializable]
public sealed class RuntimeWrappedException : Exception
{
	private object _wrappedException;

	public RuntimeWrappedException(object thrownObject)
	{
	}

	private RuntimeWrappedException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal RuntimeWrappedException()
	{
	}
}
