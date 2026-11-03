using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public sealed class DirectoryInfo : FileSystemInfo
{
	public DirectoryInfo(string path)
	{
	}

	internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
	{
	}

	private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
	{
	}

	private DirectoryInfo(SerializationInfo info, StreamingContext context)
	{
	}
}
