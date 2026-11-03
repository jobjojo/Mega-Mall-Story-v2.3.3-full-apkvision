namespace System.IO;

internal struct FileStatus
{
	private Interop.Sys.FileStatus _fileStatus;

	private int _fileStatusInitialized;

	internal bool _isDirectory;

	private bool _exists;

	internal bool InitiallyDirectory { get; private set; }

	internal static void Initialize(ref FileStatus status, bool isDirectory)
	{
	}

	internal bool IsReadOnly(ReadOnlySpan<char> path, bool continueOnError = false)
	{
		return false;
	}

	public FileAttributes GetAttributes(ReadOnlySpan<char> path, ReadOnlySpan<char> fileName)
	{
		return (FileAttributes)0;
	}

	internal bool GetExists(ReadOnlySpan<char> path)
	{
		return false;
	}

	internal DateTimeOffset GetLastWriteTime(ReadOnlySpan<char> path, bool continueOnError = false)
	{
		return default;
	}

	private DateTimeOffset UnixTimeToDateTimeOffset(long seconds, long nanoseconds)
	{
		return default;
	}

	internal long GetLength(ReadOnlySpan<char> path, bool continueOnError = false)
	{
		return 0L;
	}

	public void Refresh(ReadOnlySpan<char> path)
	{
	}

	internal void EnsureStatInitialized(ReadOnlySpan<char> path, bool continueOnError = false)
	{
	}
}
