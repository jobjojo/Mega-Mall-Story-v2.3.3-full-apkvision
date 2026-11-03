namespace System.Text;

[Serializable]
public abstract class DecoderFallback
{
	private static DecoderFallback s_replacementFallback;

	private static DecoderFallback s_exceptionFallback;

	public static DecoderFallback ReplacementFallback => null;

	public static DecoderFallback ExceptionFallback => null;

	public abstract int MaxCharCount { get; }

	public abstract DecoderFallbackBuffer CreateFallbackBuffer();
}
