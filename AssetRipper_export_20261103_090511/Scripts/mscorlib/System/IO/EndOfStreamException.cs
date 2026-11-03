using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public class EndOfStreamException : IOException
{
	public EndOfStreamException()
	{
	}

	public EndOfStreamException(string message)
	{
	}

	protected EndOfStreamException(SerializationInfo info, StreamingContext context)
	{
	}
}
