namespace System.Security.Cryptography;

public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
{
	private static object _lock;

	private IntPtr _handle;

	static RNGCryptoServiceProvider()
	{
	}

	private void Check()
	{
	}

	private static bool RngOpen()
	{
		return false;
	}

	private unsafe static IntPtr RngInitialize(byte* seed, IntPtr seed_length)
	{
		return (IntPtr)0;
	}

	private static void RngClose(IntPtr handle)
	{
	}

	~RNGCryptoServiceProvider()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
