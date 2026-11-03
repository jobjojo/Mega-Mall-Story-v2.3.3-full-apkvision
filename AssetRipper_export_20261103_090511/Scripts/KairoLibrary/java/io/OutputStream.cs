using System;
using System.IO;

namespace java.io;

public class OutputStream : IDisposable
{
	protected Stream Wrapped;

	public static implicit operator OutputStream(Stream s)
	{
		return null;
	}

	public static implicit operator Stream(OutputStream s)
	{
		return null;
	}

	public virtual void Close()
	{
	}

	public void Dispose()
	{
	}

	public virtual void Flush()
	{
	}

	public virtual void Write(int b)
	{
	}

	public virtual void Write(byte[] b)
	{
	}

	public virtual void Write(byte[] b, int offset, int len)
	{
	}

	internal Stream GetWrappedStream()
	{
		return null;
	}

	internal static OutputStream Wrap(Stream s)
	{
		return null;
	}
}
