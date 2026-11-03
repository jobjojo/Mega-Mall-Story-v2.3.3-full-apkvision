namespace System.Text;

[Serializable]
public sealed class UTF32Encoding : Encoding
{
	[Serializable]
	private sealed class UTF32Decoder : DecoderNLS
	{
		internal int iChar;

		internal int readByteCount;

		internal override bool HasState => false;

		public UTF32Decoder(UTF32Encoding encoding)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}

	internal static readonly UTF32Encoding s_default;

	internal static readonly UTF32Encoding s_bigEndianDefault;

	private static readonly byte[] s_bigEndianPreamble;

	private static readonly byte[] s_littleEndianPreamble;

	private bool _emitUTF32ByteOrderMark;

	private bool _isThrowException;

	private bool _bigEndian;

	public override ReadOnlySpan<byte> Preamble => default;

	public UTF32Encoding()
	{
	}

	public UTF32Encoding(bool bigEndian, bool byteOrderMark)
	{
	}

	public UTF32Encoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters)
	{
	}

	internal override void SetDefaultFallbacks()
	{
	}

	public override int GetByteCount(char[] chars, int index, int count)
	{
		return 0;
	}

	public override int GetByteCount(string s)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public unsafe override int GetByteCount(char* chars, int count)
	{
		return 0;
	}

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		return 0;
	}

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
	{
		return 0;
	}

	public override int GetCharCount(byte[] bytes, int index, int count)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public unsafe override int GetCharCount(byte* bytes, int count)
	{
		return 0;
	}

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
	{
		return 0;
	}

	public override string GetString(byte[] bytes, int index, int count)
	{
		return null;
	}

	internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
	{
		return 0;
	}

	internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
	{
		return 0;
	}

	internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
	{
		return 0;
	}

	internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
	{
		return 0;
	}

	private uint GetSurrogate(char cHigh, char cLow)
	{
		return 0u;
	}

	private char GetHighSurrogate(uint iChar)
	{
		return '\0';
	}

	private char GetLowSurrogate(uint iChar)
	{
		return '\0';
	}

	public override Decoder GetDecoder()
	{
		return null;
	}

	public override Encoder GetEncoder()
	{
		return null;
	}

	public override int GetMaxByteCount(int charCount)
	{
		return 0;
	}

	public override int GetMaxCharCount(int byteCount)
	{
		return 0;
	}

	public override byte[] GetPreamble()
	{
		return null;
	}

	public override bool Equals(object value)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
