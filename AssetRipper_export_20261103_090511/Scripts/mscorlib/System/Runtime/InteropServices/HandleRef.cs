namespace System.Runtime.InteropServices;

public readonly struct HandleRef(object wrapper, IntPtr handle)
{
	private readonly object _wrapper = null;

	private readonly IntPtr _handle = (IntPtr)0;

	public IntPtr Handle => (IntPtr)0;
}
