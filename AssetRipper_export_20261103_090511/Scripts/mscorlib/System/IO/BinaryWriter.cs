using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace System.IO;

[Serializable]
[ComVisible(true)]
public class BinaryWriter : IDisposable
{
	public static readonly BinaryWriter Null;

	protected Stream OutStream;

	private byte[] _buffer;

	private Encoding _encoding;

	private Encoder _encoder;

	[OptionalField]
	private bool _leaveOpen;

	private byte[] _largeByteBuffer;

	private int _maxChars;

	protected BinaryWriter()
	{
	}

	public BinaryWriter(Stream output)
	{
	}

	public BinaryWriter(Stream output, Encoding encoding)
	{
	}

	public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen)
	{
	}

	public virtual void Close()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public void Dispose()
	{
	}

	public virtual void Flush()
	{
	}

	public virtual void Write(bool value)
	{
	}

	public virtual void Write(byte value)
	{
	}

	public virtual void Write(byte[] buffer)
	{
	}

	public virtual void Write(byte[] buffer, int index, int count)
	{
	}

	public virtual void Write(char ch)
	{
	}

	public virtual void Write(char[] chars)
	{
	}

	public virtual void Write(double value)
	{
	}

	public virtual void Write(short value)
	{
	}

	[CLSCompliant(false)]
	public virtual void Write(ushort value)
	{
	}

	public virtual void Write(int value)
	{
	}

	[CLSCompliant(false)]
	public virtual void Write(uint value)
	{
	}

	public virtual void Write(long value)
	{
	}

	[CLSCompliant(false)]
	public virtual void Write(ulong value)
	{
	}

	public virtual void Write(float value)
	{
	}

	public virtual void Write(string value)
	{
	}

	protected void Write7BitEncodedInt(int value)
	{
	}
}
