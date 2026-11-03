namespace System.Text;

[Serializable]
public class UnicodeEncoding : Encoding
{
	[Serializable]
	private sealed class Decoder : DecoderNLS
	{
		internal int lastByte;

		internal char lastChar;

		internal override bool HasState => false;

		public Decoder(UnicodeEncoding encoding)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}

	internal static readonly UnicodeEncoding s_bigEndianDefault;

	internal static readonly UnicodeEncoding s_littleEndianDefault;

	private static readonly byte[] s_bigEndianPreamble;

	private static readonly byte[] s_littleEndianPreamble;

	internal bool isThrowException;

	internal bool bigEndian;

	internal bool byteOrderMark;

	private static readonly ulong highLowPatternMask;

	public override ReadOnlySpan<byte> Preamble => default;

	public UnicodeEncoding()
	{
	}

	public UnicodeEncoding(bool bigEndian, bool byteOrderMark)
	{
	}

	public UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes)
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

	public override Encoder GetEncoder()
	{
		return null;
	}

	public override System.Text.Decoder GetDecoder()
	{
		return null;
	}

	public override byte[] GetPreamble()
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

	public override bool Equals(object value)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
