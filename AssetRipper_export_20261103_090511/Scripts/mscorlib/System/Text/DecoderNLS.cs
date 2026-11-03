namespace System.Text;

internal class DecoderNLS : Decoder
{
	private Encoding _encoding;

	private bool _mustFlush;

	internal bool _throwOnOverflow;

	internal int _bytesUsed;

	public bool MustFlush => false;

	internal virtual bool HasState => false;

	internal DecoderNLS(Encoding encoding)
	{
	}

	public override void Reset()
	{
	}

	public override int GetCharCount(byte[] bytes, int index, int count)
	{
		return 0;
	}

	public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
	{
		return 0;
	}

	public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
	{
		return 0;
	}

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
	{
		return 0;
	}

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
	{
		return 0;
	}

	public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
	{
		return 0;
	}

	internal void ClearMustFlush()
	{
	}
}
