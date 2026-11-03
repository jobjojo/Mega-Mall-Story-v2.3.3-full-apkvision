using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public abstract class RandomNumberGenerator : IDisposable
{
	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
