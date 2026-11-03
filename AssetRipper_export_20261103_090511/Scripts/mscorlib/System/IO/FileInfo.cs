using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public sealed class FileInfo : FileSystemInfo
{
	public long Length => 0L;

	public override string Name => null;

	private FileInfo()
	{
	}

	public FileInfo(string fileName)
	{
	}

	internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
	{
	}

	private FileInfo(SerializationInfo info, StreamingContext context)
	{
	}
}
