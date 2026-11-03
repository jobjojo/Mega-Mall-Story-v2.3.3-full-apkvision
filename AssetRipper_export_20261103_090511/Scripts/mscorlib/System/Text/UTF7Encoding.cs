namespace System.Text;

[Serializable]
public class UTF7Encoding : Encoding
{
	[Serializable]
	private sealed class Decoder : DecoderNLS
	{
		internal int bits;

		internal int bitCount;

		internal bool firstByte;

		internal override bool HasState => false;

		public Decoder(UTF7Encoding encoding)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}

	[Serializable]
	private sealed class Encoder : EncoderNLS
	{
		internal int bits;

		internal int bitCount;

		public Encoder(UTF7Encoding encoding)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}

	[Serializable]
	private sealed class DecoderUTF7Fallback : DecoderFallback
	{
		public override int MaxCharCount => 0;

		public override DecoderFallbackBuffer CreateFallbackBuffer()
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

	private sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
	{
		private char cFallback;

		private int iCount;

		private int iSize;

		public DecoderUTF7FallbackBuffer(DecoderUTF7Fallback fallback)
		{
		}

		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			return false;
		}

		public override char GetNextChar()
		{
			return '\0';
		}

		public override void Reset()
		{
		}

		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			return 0;
		}
	}

	internal static readonly UTF7Encoding s_default;

	private byte[] _base64Bytes;

	private sbyte[] _base64Values;

	private bool[] _directEncode;

	private bool _allowOptionals;

	public UTF7Encoding()
	{
	}

	public UTF7Encoding(bool allowOptionals)
	{
	}

	private void MakeTables()
	{
	}

	internal override void SetDefaultFallbacks()
	{
	}

	public override bool Equals(object value)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
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

	internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
	{
		return 0;
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

	public override System.Text.Decoder GetDecoder()
	{
		return null;
	}

	public override System.Text.Encoder GetEncoder()
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
}
