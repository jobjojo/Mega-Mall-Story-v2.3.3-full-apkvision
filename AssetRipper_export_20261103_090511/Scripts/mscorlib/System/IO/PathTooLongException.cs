using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public class PathTooLongException : IOException
{
	public PathTooLongException()
	{
	}

	public PathTooLongException(string message)
	{
	}

	protected PathTooLongException(SerializationInfo info, StreamingContext context)
	{
	}
}
