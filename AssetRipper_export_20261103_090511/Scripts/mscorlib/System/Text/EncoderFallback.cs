namespace System.Text;

[Serializable]
public abstract class EncoderFallback
{
	private static EncoderFallback s_replacementFallback;

	private static EncoderFallback s_exceptionFallback;

	public static EncoderFallback ReplacementFallback => null;

	public static EncoderFallback ExceptionFallback => null;

	public abstract int MaxCharCount { get; }

	public abstract EncoderFallbackBuffer CreateFallbackBuffer();
}
