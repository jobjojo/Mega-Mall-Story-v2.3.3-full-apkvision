namespace System.Text;

[Serializable]
public sealed class EncoderExceptionFallback : EncoderFallback
{
	public override int MaxCharCount => 0;

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
