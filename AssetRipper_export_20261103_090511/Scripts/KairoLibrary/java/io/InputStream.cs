using System;
using System.Collections.Generic;
using System.IO;

namespace java.io;

public class InputStream : IDisposable
{
	private long mark;

	protected Stream Wrapped;

	protected Stream BaseStream;

	private Stack<int> versionStack_;

	public int Version { get; set; }

	public long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public void PushVersion(int version)
	{
	}

	public void PopVersion()
	{
	}

	public static implicit operator InputStream(Stream s)
	{
		return null;
	}

	public static implicit operator Stream(InputStream s)
	{
		return null;
	}

	public virtual int Available()
	{
		return 0;
	}

	public virtual void Close()
	{
	}

	public void Dispose()
	{
	}

	public virtual void Mark(int readlimit)
	{
	}

	public virtual bool MarkSupported()
	{
		return false;
	}

	public virtual int Read()
	{
		return 0;
	}

	public virtual int Read(byte[] buf)
	{
		return 0;
	}

	public virtual int Read(byte[] b, int off, int len)
	{
		return 0;
	}

	public virtual void Reset()
	{
	}

	public virtual long Skip(long cnt)
	{
		return 0L;
	}

	internal Stream GetWrappedStream()
	{
		return null;
	}

	internal bool CanSeek()
	{
		return false;
	}

	internal static InputStream Wrap(Stream s)
	{
		return null;
	}
}
