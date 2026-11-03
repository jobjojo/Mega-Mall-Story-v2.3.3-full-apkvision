using Microsoft.Win32.SafeHandles;

namespace System.Runtime.InteropServices;

public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
{
	private static readonly UIntPtr Uninitialized;

	private UIntPtr _numBytes;

	[CLSCompliant(false)]
	public unsafe void AcquirePointer(ref byte* pointer)
	{
	}

	public void ReleasePointer()
	{
	}

	private static InvalidOperationException NotInitialized()
	{
		return null;
	}
}
