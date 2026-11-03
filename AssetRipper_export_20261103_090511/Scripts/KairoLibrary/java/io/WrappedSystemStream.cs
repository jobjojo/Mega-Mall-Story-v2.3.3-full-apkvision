using System.IO;

namespace java.io;

internal class WrappedSystemStream : Stream
{
	private InputStream ist;

	private OutputStream ost;

	private int position;

	private int markedPosition;

	public InputStream InputStream => null;

	public OutputStream OutputStream => null;

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

	public WrappedSystemStream(InputStream ist)
	{
	}

	public WrappedSystemStream(OutputStream ost)
	{
	}

	public override void Close()
	{
	}

	public override void Flush()
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override int ReadByte()
	{
		return 0;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override void SetLength(long value)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void WriteByte(byte value)
	{
	}

	internal void OnMark(int nb)
	{
	}
}
