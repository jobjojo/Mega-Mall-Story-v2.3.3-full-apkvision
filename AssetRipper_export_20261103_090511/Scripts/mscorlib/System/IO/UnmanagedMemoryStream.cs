using System.Runtime.InteropServices;

namespace System.IO;

public class UnmanagedMemoryStream : Stream
{
	private SafeBuffer _buffer;

	private unsafe byte* _mem;

	private long _length;

	private long _capacity;

	private long _position;

	private long _offset;

	private FileAccess _access;

	internal bool _isOpen;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

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

	[CLSCompliant(false)]
	public unsafe byte* PositionPointer => null;

	protected UnmanagedMemoryStream()
	{
	}

	[CLSCompliant(false)]
	public unsafe UnmanagedMemoryStream(byte* pointer, long length)
	{
	}

	[CLSCompliant(false)]
	public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access)
	{
	}

	[CLSCompliant(false)]
	protected unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void EnsureNotClosed()
	{
	}

	private void EnsureReadable()
	{
	}

	private void EnsureWriteable()
	{
	}

	public override void Flush()
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override int Read(Span<byte> buffer)
	{
		return 0;
	}

	internal int ReadCore(Span<byte> buffer)
	{
		return 0;
	}

	public override int ReadByte()
	{
		return 0;
	}

	public override long Seek(long offset, SeekOrigin loc)
	{
		return 0L;
	}

	public override void SetLength(long value)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void Write(ReadOnlySpan<byte> buffer)
	{
	}

	internal void WriteCore(ReadOnlySpan<byte> buffer)
	{
	}

	public override void WriteByte(byte value)
	{
	}
}
