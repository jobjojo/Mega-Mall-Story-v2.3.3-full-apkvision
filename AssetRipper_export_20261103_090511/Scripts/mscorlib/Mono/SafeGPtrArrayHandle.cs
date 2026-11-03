using System;

namespace Mono;

internal struct SafeGPtrArrayHandle : IDisposable
{
	private RuntimeGPtrArrayHandle handle = default;

	internal int Length => 0;

	internal IntPtr this[int i] => (IntPtr)0;

	internal SafeGPtrArrayHandle(IntPtr ptr)
	{
	}

	public void Dispose()
	{
	}
}
