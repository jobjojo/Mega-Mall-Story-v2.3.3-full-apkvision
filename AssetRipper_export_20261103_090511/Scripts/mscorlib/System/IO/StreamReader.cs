using System.Text;
using System.Threading.Tasks;

namespace System.IO;

[Serializable]
public class StreamReader : TextReader
{
	private class NullStreamReader : StreamReader
	{
		public override Stream BaseStream => null;

		internal NullStreamReader()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override int Peek()
		{
			return 0;
		}

		public override int Read()
		{
			return 0;
		}

		public override int Read(char[] buffer, int index, int count)
		{
			return 0;
		}

		public override string ReadLine()
		{
			return null;
		}

		public override string ReadToEnd()
		{
			return null;
		}

		internal override int ReadBuffer()
		{
			return 0;
		}
	}

	public new static readonly StreamReader Null;

	private const int DefaultBufferSize = 1024;

	private const int DefaultFileStreamBufferSize = 4096;

	private const int MinBufferSize = 128;

	private Stream _stream;

	private Encoding _encoding;

	private Decoder _decoder;

	private byte[] _byteBuffer;

	private char[] _charBuffer;

	private int _charPos;

	private int _charLen;

	private int _byteLen;

	private int _bytePos;

	private int _maxCharsPerBuffer;

	private bool _detectEncoding;

	private bool _checkPreamble;

	private bool _isBlocked;

	private bool _closable;

	private Task _asyncReadTask;

	public virtual Stream BaseStream => null;

	internal bool LeaveOpen => false;

	private void CheckAsyncTaskInProgress()
	{
	}

	private static void ThrowAsyncIOInProgress()
	{
	}

	internal StreamReader()
	{
	}

	public StreamReader(Stream stream, Encoding encoding)
	{
	}

	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
	{
	}

	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
	{
	}

	public StreamReader(string path)
	{
	}

	public StreamReader(string path, bool detectEncodingFromByteOrderMarks)
	{
	}

	public StreamReader(string path, Encoding encoding)
	{
	}

	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
	{
	}

	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
	{
	}

	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
	{
	}

	internal void Init(Stream stream)
	{
	}

	public override void Close()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public override int Peek()
	{
		return 0;
	}

	public override int Read()
	{
		return 0;
	}

	public override int Read(char[] buffer, int index, int count)
	{
		return 0;
	}

	private int ReadSpan(Span<char> buffer)
	{
		return 0;
	}

	public override string ReadToEnd()
	{
		return null;
	}

	private void CompressBuffer(int n)
	{
	}

	private void DetectEncoding()
	{
	}

	private bool IsPreamble()
	{
		return false;
	}

	internal virtual int ReadBuffer()
	{
		return 0;
	}

	private int ReadBuffer(Span<char> userBuffer, out bool readToUserBuffer)
	{
		readToUserBuffer = default;
		return 0;
	}

	public override string ReadLine()
	{
		return null;
	}

	internal bool DataAvailable()
	{
		return false;
	}
}
