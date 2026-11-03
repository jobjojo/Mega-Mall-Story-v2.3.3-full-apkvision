using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.IO;

[ComVisible(true)]
public class FileStream : Stream
{
	private delegate int ReadDelegate(byte[] buffer, int offset, int count);

	private delegate void WriteDelegate(byte[] buffer, int offset, int count);

	private static byte[] buf_recycle;

	private static readonly object buf_recycle_lock;

	private byte[] buf;

	private string name;

	private SafeFileHandle safeHandle;

	private bool isExposed;

	private long append_startpos;

	private FileAccess access;

	private bool owner;

	private bool async;

	private bool canseek;

	private bool anonymous;

	private bool buf_dirty;

	private int buf_size;

	private int buf_length;

	private int buf_offset;

	private long buf_start;

	public override bool CanRead => false;

	public override bool CanWrite => false;

	public override bool CanSeek => false;

	public override long Length => 0L;

	public override long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual SafeFileHandle SafeFileHandle => null;

	[Obsolete("Use FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) instead")]
	public FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize)
	{
	}

	internal FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
	{
	}

	public FileStream(string path, FileMode mode)
	{
	}

	public FileStream(string path, FileMode mode, FileAccess access)
	{
	}

	public FileStream(string path, FileMode mode, FileAccess access, FileShare share)
	{
	}

	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
	{
	}

	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
	{
	}

	public FileStream(SafeFileHandle handle, FileAccess access)
	{
	}

	public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync)
	{
	}

	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous)
	{
	}

	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options)
	{
	}

	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
	{
	}

	private void ExposeHandle()
	{
	}

	public override int ReadByte()
	{
		return 0;
	}

	public override void WriteByte(byte value)
	{
	}

	public override int Read([In][Out] byte[] array, int offset, int count)
	{
		return 0;
	}

	private int ReadInternal(byte[] dest, int offset, int count)
	{
		return 0;
	}

	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		return null;
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	public override void Write(byte[] array, int offset, int count)
	{
	}

	private void WriteInternal(byte[] src, int offset, int count)
	{
	}

	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		return null;
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override void SetLength(long value)
	{
	}

	public override void Flush()
	{
	}

	~FileStream()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private int ReadSegment(byte[] dest, int dest_offset, int count)
	{
		return 0;
	}

	private int WriteSegment(byte[] src, int src_offset, int count)
	{
		return 0;
	}

	private void FlushBuffer()
	{
	}

	private void FlushBufferIfDirty()
	{
	}

	private void RefillBuffer()
	{
	}

	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count)
	{
		return 0;
	}

	private void InitBuffer(int size, bool isZeroSize)
	{
	}

	private string GetSecureFileName(string filename)
	{
		return null;
	}

	private string GetSecureFileName(string filename, bool full)
	{
		return null;
	}
}
