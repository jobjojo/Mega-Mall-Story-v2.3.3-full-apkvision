namespace System.Text;

[Serializable]
public abstract class Decoder
{
	internal DecoderFallback _fallback;

	internal DecoderFallbackBuffer _fallbackBuffer;

	public DecoderFallback Fallback => null;

	public DecoderFallbackBuffer FallbackBuffer => null;

	internal bool InternalHasFallbackBuffer => false;

	public virtual void Reset()
	{
	}

	public abstract int GetCharCount(byte[] bytes, int index, int count);

	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public unsafe virtual int GetCharCount(byte* bytes, int count, bool flush)
	{
		return 0;
	}

	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
	{
		return 0;
	}

	public virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush)
	{
		return 0;
	}
}
