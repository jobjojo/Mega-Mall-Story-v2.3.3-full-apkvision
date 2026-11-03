using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public class DriveNotFoundException : IOException
{
	public DriveNotFoundException()
	{
	}

	public DriveNotFoundException(string message)
	{
	}

	protected DriveNotFoundException(SerializationInfo info, StreamingContext context)
	{
	}
}
