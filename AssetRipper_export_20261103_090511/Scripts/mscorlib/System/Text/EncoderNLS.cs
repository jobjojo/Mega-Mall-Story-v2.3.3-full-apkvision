namespace System.Text;

internal class EncoderNLS : Encoder
{
	internal char _charLeftOver;

	private Encoding _encoding;

	private bool _mustFlush;

	internal bool _throwOnOverflow;

	internal int _charsUsed;

	public Encoding Encoding => null;

	public bool MustFlush => false;

	internal EncoderNLS(Encoding encoding)
	{
	}

	internal EncoderNLS()
	{
	}

	public override void Reset()
	{
	}

	public override int GetByteCount(char[] chars, int index, int count, bool flush)
	{
		return 0;
	}

	public unsafe override int GetByteCount(char* chars, int count, bool flush)
	{
		return 0;
	}

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
	{
		return 0;
	}

	public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
	{
		return 0;
	}

	internal void ClearMustFlush()
	{
	}
}
