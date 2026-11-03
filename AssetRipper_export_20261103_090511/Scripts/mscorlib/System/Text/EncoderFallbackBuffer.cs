namespace System.Text;

public abstract class EncoderFallbackBuffer
{
	internal unsafe char* charStart;

	internal unsafe char* charEnd;

	internal EncoderNLS encoder;

	internal bool setEncoder;

	internal bool bUsedEncoder;

	internal bool bFallingBack;

	internal int iRecursionCount;

	private const int iMaxRecursion = 250;

	public abstract int Remaining { get; }

	public abstract bool Fallback(char charUnknown, int index);

	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	public abstract char GetNextChar();

	public abstract bool MovePrevious();

	public virtual void Reset()
	{
	}

	internal void InternalReset()
	{
	}

	internal unsafe void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder)
	{
	}

	internal char InternalGetNextChar()
	{
		return '\0';
	}

	internal unsafe virtual bool InternalFallback(char ch, ref char* chars)
	{
		return false;
	}

	internal void ThrowLastCharRecursive(int charRecursive)
	{
	}
}
