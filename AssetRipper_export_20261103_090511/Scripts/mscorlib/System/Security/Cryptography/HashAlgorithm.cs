namespace System.Security.Cryptography;

public abstract class HashAlgorithm : IDisposable
{
	private bool _disposed;

	protected int HashSizeValue;

	protected internal byte[] HashValue;

	protected int State;

	public virtual byte[] Hash => null;

	public byte[] ComputeHash(byte[] buffer)
	{
		return null;
	}

	private byte[] CaptureHashCodeAndReinitialize()
	{
		return null;
	}

	public void Dispose()
	{
	}

	public void Clear()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		return 0;
	}

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		return null;
	}

	private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
	}

	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	protected abstract byte[] HashFinal();

	public abstract void Initialize();
}
