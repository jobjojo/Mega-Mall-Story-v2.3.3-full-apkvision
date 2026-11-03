namespace System.Text;

public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
{
	private string _strDefault;

	private int _fallbackCount;

	private int _fallbackIndex;

	public override int Remaining => 0;

	public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback)
	{
	}

	public override bool Fallback(char charUnknown, int index)
	{
		return false;
	}

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
	{
		return false;
	}

	public override char GetNextChar()
	{
		return '\0';
	}

	public override bool MovePrevious()
	{
		return false;
	}

	public override void Reset()
	{
	}
}
