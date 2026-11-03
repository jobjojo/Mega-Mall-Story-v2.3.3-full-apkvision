namespace System.Text;

[Serializable]
public class UTF8Encoding : Encoding
{
	internal sealed class UTF8EncodingSealed : UTF8Encoding
	{
		public override ReadOnlySpan<byte> Preamble => default;

		public UTF8EncodingSealed(bool encoderShouldEmitUTF8Identifier)
		{
		}
	}

	[Serializable]
	private sealed class UTF8Encoder : EncoderNLS
	{
		internal int surrogateChar;

		public UTF8Encoder(UTF8Encoding encoding)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}

	[Serializable]
	private sealed class UTF8Decoder : DecoderNLS
	{
		internal int bits;

		internal override bool HasState => false;

		public UTF8Decoder(UTF8Encoding encoding)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}

	internal static readonly UTF8EncodingSealed s_default;

	internal static readonly byte[] s_preamble;

	internal readonly bool _emitUTF8Identifier;

	private bool _isThrowException;

	public override ReadOnlySpan<byte> Preamble => default;

	public UTF8Encoding()
	{
	}

	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier)
	{
	}

	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes)
	{
	}

	internal override void SetDefaultFallbacks()
	{
	}

	public override int GetByteCount(char[] chars, int index, int count)
	{
		return 0;
	}

	public override int GetByteCount(string chars)
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

	internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
	{
		return 0;
	}

	private unsafe static int PtrDiff(char* a, char* b)
	{
		return 0;
	}

	private unsafe static int PtrDiff(byte* a, byte* b)
	{
		return 0;
	}

	private static bool InRange(int ch, int start, int end)
	{
		return false;
	}

	internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
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

	private unsafe bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget)
	{
		return false;
	}

	private unsafe int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback)
	{
		return 0;
	}

	private unsafe byte[] GetBytesUnknown(ref byte* pSrc, int ch)
	{
		return null;
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
