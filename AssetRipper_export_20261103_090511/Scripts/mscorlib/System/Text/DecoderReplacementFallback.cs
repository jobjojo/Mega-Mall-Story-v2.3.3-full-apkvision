using System.Runtime.Serialization;

namespace System.Text;

[Serializable]
public sealed class DecoderReplacementFallback : DecoderFallback, ISerializable
{
	private string _strDefault;

	public string DefaultString => null;

	public override int MaxCharCount => 0;

	public DecoderReplacementFallback()
	{
	}

	internal DecoderReplacementFallback(SerializationInfo info, StreamingContext context)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public DecoderReplacementFallback(string replacement)
	{
	}

	public override DecoderFallbackBuffer CreateFallbackBuffer()
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
