using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public class FileNotFoundException : IOException
{
	public override string Message => null;

	public string FileName { get; }

	public string FusionLog { get; }

	public FileNotFoundException()
	{
	}

	public FileNotFoundException(string message)
	{
	}

	public FileNotFoundException(string message, string fileName)
	{
	}

	private void SetMessageField()
	{
	}

	public override string ToString()
	{
		return null;
	}

	protected FileNotFoundException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
