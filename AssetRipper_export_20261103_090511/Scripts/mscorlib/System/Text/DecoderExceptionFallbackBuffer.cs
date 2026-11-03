namespace System.Text;

public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
{
	public override bool Fallback(byte[] bytesUnknown, int index)
	{
		return false;
	}

	public override char GetNextChar()
	{
		return '\0';
	}

	private void Throw(byte[] bytesUnknown, int index)
	{
	}
}
