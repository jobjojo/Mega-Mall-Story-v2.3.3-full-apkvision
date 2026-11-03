using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public class FileLoadException : IOException
{
	public override string Message => null;

	public string FileName { get; }

	public string FusionLog { get; }

	public FileLoadException()
	{
	}

	public FileLoadException(string message)
	{
	}

	public override string ToString()
	{
		return null;
	}

	protected FileLoadException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult)
	{
		return null;
	}
}
