namespace System.Text;

public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
{
	private string _strDefault;

	private int _fallbackCount;

	private int _fallbackIndex;

	public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
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
