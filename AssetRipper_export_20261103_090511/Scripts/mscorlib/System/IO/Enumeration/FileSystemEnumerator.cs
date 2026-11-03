using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace System.IO.Enumeration;

public abstract class FileSystemEnumerator<TResult> : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator
{
	private readonly string _originalRootDirectory;

	private readonly string _rootDirectory;

	private readonly EnumerationOptions _options;

	private readonly object _lock;

	private string _currentPath;

	private IntPtr _directoryHandle;

	private bool _lastEntryFound;

	private Queue<string> _pending;

	private Interop.Sys.DirectoryEntry _entry;

	private TResult _current;

	private char[] _pathBuffer;

	private byte[] _entryBuffer;

	public TResult Current => default;

	object IEnumerator.Current => null;

	public FileSystemEnumerator(string directory, EnumerationOptions options = null)
	{
	}

	private bool InternalContinueOnError(Interop.ErrorInfo info, bool ignoreNotFound = false)
	{
		return false;
	}

	private static bool IsDirectoryNotFound(Interop.ErrorInfo info)
	{
		return false;
	}

	private static bool IsAccessError(Interop.ErrorInfo info)
	{
		return false;
	}

	private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false)
	{
		return (IntPtr)0;
	}

	private void CloseDirectoryHandle()
	{
	}

	public bool MoveNext()
	{
		return false;
	}

	private void FindNextEntry()
	{
	}

	private unsafe void FindNextEntry(byte* entryBufferPtr, int bufferLength)
	{
	}

	private bool DequeueNextDirectory()
	{
		return false;
	}

	private void InternalDispose(bool disposing)
	{
	}

	protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry)
	{
		return false;
	}

	protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
	{
		return false;
	}

	protected abstract TResult TransformEntry(ref FileSystemEntry entry);

	protected virtual void OnDirectoryFinished(ReadOnlySpan<char> directory)
	{
	}

	protected virtual bool ContinueOnError(int error)
	{
		return false;
	}

	private void DirectoryFinished()
	{
	}

	public void Reset()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	~FileSystemEnumerator()
	{
	}
}
