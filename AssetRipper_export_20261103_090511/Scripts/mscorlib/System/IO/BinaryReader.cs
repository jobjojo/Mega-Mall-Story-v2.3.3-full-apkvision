using System.Runtime.InteropServices;
using System.Text;

namespace System.IO;

[ComVisible(true)]
public class BinaryReader : IDisposable
{
	private Stream m_stream;

	private byte[] m_buffer;

	private Decoder m_decoder;

	private byte[] m_charBytes;

	private char[] m_singleChar;

	private char[] m_charBuffer;

	private int m_maxCharsSize;

	private bool m_2BytesPerChar;

	private bool m_isMemoryStream;

	private bool m_leaveOpen;

	public virtual Stream BaseStream => null;

	public BinaryReader(Stream input)
	{
	}

	public BinaryReader(Stream input, Encoding encoding)
	{
	}

	public BinaryReader(Stream input, Encoding encoding, bool leaveOpen)
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

	public virtual int Read()
	{
		return 0;
	}

	public virtual bool ReadBoolean()
	{
		return false;
	}

	public virtual byte ReadByte()
	{
		return 0;
	}

	[CLSCompliant(false)]
	public virtual sbyte ReadSByte()
	{
		return 0;
	}

	public virtual char ReadChar()
	{
		return '\0';
	}

	public virtual short ReadInt16()
	{
		return 0;
	}

	[CLSCompliant(false)]
	public virtual ushort ReadUInt16()
	{
		return 0;
	}

	public virtual int ReadInt32()
	{
		return 0;
	}

	[CLSCompliant(false)]
	public virtual uint ReadUInt32()
	{
		return 0u;
	}

	public virtual long ReadInt64()
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public virtual ulong ReadUInt64()
	{
		return 0uL;
	}

	public virtual float ReadSingle()
	{
		return 0f;
	}

	public virtual double ReadDouble()
	{
		return 0.0;
	}

	public virtual decimal ReadDecimal()
	{
		return 0m;
	}

	public virtual string ReadString()
	{
		return null;
	}

	private int InternalReadChars(char[] buffer, int index, int count)
	{
		return 0;
	}

	private int InternalReadOneChar()
	{
		return 0;
	}

	public virtual char[] ReadChars(int count)
	{
		return null;
	}

	public virtual int Read(byte[] buffer, int index, int count)
	{
		return 0;
	}

	public virtual byte[] ReadBytes(int count)
	{
		return null;
	}

	protected virtual void FillBuffer(int numBytes)
	{
	}

	protected internal int Read7BitEncodedInt()
	{
		return 0;
	}
}
