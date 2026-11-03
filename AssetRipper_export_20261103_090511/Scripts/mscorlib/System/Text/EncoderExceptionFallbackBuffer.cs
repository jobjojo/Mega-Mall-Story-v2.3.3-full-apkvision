namespace System.Text;

public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
{
	public override int Remaining => 0;

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
}
