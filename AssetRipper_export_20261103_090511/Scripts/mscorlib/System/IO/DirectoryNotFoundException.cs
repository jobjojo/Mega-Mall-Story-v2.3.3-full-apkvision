using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public class DirectoryNotFoundException : IOException
{
	public DirectoryNotFoundException()
	{
	}

	public DirectoryNotFoundException(string message)
	{
	}

	protected DirectoryNotFoundException(SerializationInfo info, StreamingContext context)
	{
	}
}
