using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
{
	private FileStatus _fileStatus;

	protected string FullPath;

	protected string OriginalPath;

	internal string _name;

	public FileAttributes Attributes => (FileAttributes)0;

	internal bool ExistsCore => false;

	internal DateTimeOffset LastWriteTimeCore => default;

	internal long LengthCore => 0L;

	public virtual string FullName => null;

	public virtual string Name => null;

	public virtual bool Exists => false;

	public DateTime LastWriteTime => default;

	public DateTime LastWriteTimeUtc => default;

	protected FileSystemInfo()
	{
	}

	protected FileSystemInfo(SerializationInfo info, StreamingContext context)
	{
	}

	[ComVisible(false)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
