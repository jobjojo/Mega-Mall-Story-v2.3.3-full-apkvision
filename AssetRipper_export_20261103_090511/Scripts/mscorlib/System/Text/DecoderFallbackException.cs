using System.Runtime.Serialization;

namespace System.Text;

[Serializable]
public sealed class DecoderFallbackException : ArgumentException
{
	private byte[] _bytesUnknown;

	private int _index;

	public DecoderFallbackException()
	{
	}

	public DecoderFallbackException(string message, byte[] bytesUnknown, int index)
	{
	}

	private DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}
}
