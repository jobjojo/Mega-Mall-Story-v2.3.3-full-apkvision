namespace System.Text;

[Serializable]
public class ASCIIEncoding : Encoding
{
	internal sealed class ASCIIEncodingSealed : ASCIIEncoding
	{
	}

	internal static readonly ASCIIEncodingSealed s_default;

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

	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
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

	public override string GetString(byte[] bytes, int byteIndex, int byteCount)
	{
		return null;
	}

	internal unsafe override int GetByteCount(char* chars, int charCount, EncoderNLS encoder)
	{
		return 0;
	}

	internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
	{
		return 0;
	}

	internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
	{
		return 0;
	}

	internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
	{
		return 0;
	}

	public override int GetMaxByteCount(int charCount)
	{
		return 0;
	}

	public override int GetMaxCharCount(int byteCount)
	{
		return 0;
	}

	public override Decoder GetDecoder()
	{
		return null;
	}

	public override Encoder GetEncoder()
	{
		return null;
	}
}
