namespace System.Security.Cryptography;

public sealed class SHA256CryptoServiceProvider : SHA256
{
	private static byte[] Empty;

	private SHA256 hash;

	public override void Initialize()
	{
	}

	protected override void HashCore(byte[] array, int ibStart, int cbSize)
	{
	}

	protected override byte[] HashFinal()
	{
		return null;
	}

	protected override void Dispose(bool disposing)
	{
	}
}
