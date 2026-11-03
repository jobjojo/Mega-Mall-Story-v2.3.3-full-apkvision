using System.Runtime.Serialization;

namespace System.Text;

[Serializable]
public sealed class EncoderFallbackException : ArgumentException
{
	private char _charUnknown;

	private char _charUnknownHigh;

	private char _charUnknownLow;

	private int _index;

	public EncoderFallbackException()
	{
	}

	internal EncoderFallbackException(string message, char charUnknown, int index)
	{
	}

	internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index)
	{
	}

	private EncoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}
}
