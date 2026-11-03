namespace System.Security;

[MonoTODO("work in progress - encryption is missing")]
public sealed class SecureString : IDisposable
{
	private const int BlockSize = 16;

	private const int MaxSize = 65536;

	private int length;

	private bool disposed;

	private bool read_only;

	private byte[] data;

	public int Length => 0;

	public void Dispose()
	{
	}

	private void Encrypt()
	{
	}

	private void Decrypt()
	{
	}

	private void Alloc(int length, bool realloc)
	{
	}

	internal byte[] GetBuffer()
	{
		return null;
	}
}
