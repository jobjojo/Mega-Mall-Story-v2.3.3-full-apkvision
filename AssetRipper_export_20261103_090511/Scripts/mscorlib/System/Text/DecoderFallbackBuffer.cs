namespace System.Text;

public abstract class DecoderFallbackBuffer
{
	internal unsafe byte* byteStart;

	internal unsafe char* charEnd;

	public abstract bool Fallback(byte[] bytesUnknown, int index);

	public abstract char GetNextChar();

	public virtual void Reset()
	{
	}

	internal void InternalReset()
	{
	}

	internal unsafe void InternalInitialize(byte* byteStart, char* charEnd)
	{
	}

	internal unsafe virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars)
	{
		return false;
	}

	internal unsafe virtual int InternalFallback(byte[] bytes, byte* pBytes)
	{
		return 0;
	}

	internal void ThrowLastBytesRecursive(byte[] bytesUnknown)
	{
	}
}
