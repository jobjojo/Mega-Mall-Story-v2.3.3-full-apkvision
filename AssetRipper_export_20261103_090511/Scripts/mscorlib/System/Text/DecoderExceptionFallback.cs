namespace System.Text;

[Serializable]
public sealed class DecoderExceptionFallback : DecoderFallback
{
	public override int MaxCharCount => 0;

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
