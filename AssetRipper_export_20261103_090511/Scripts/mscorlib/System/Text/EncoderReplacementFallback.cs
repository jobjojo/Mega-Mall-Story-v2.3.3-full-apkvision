using System.Runtime.Serialization;

namespace System.Text;

[Serializable]
public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable
{
	private string _strDefault;

	public string DefaultString => null;

	public override int MaxCharCount => 0;

	public EncoderReplacementFallback()
	{
	}

	internal EncoderReplacementFallback(SerializationInfo info, StreamingContext context)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public EncoderReplacementFallback(string replacement)
	{
	}

	public override EncoderFallbackBuffer CreateFallbackBuffer()
	{
		return null;
	}

	public override bool Equals(object value)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
