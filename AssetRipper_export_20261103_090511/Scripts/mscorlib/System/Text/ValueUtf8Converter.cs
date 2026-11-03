namespace System.Text;

internal ref struct ValueUtf8Converter(Span<byte> initialBuffer)
{
	private byte[] _arrayToReturnToPool = null;

	private Span<byte> _bytes = default;

	public Span<byte> ConvertAndTerminateString(ReadOnlySpan<char> value)
	{
		return default;
	}

	public void Dispose()
	{
	}
}
