using System.Runtime.ConstrainedExecution;

namespace System.Runtime.InteropServices;

[StructLayout((LayoutKind)0)]
public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
{
	protected IntPtr handle;

	private int _state;

	private bool _ownsHandle;

	private bool _fullyInitialized;

	private const int RefCount_Mask = 2147483644;

	private const int RefCount_One = 4;

	public bool IsClosed
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return false;
		}
	}

	public abstract bool IsInvalid
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle)
	{
	}

	protected SafeHandle()
	{
	}

	~SafeHandle()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected void SetHandle(IntPtr handle)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public IntPtr DangerousGetHandle()
	{
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void Close()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void Dispose()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected virtual void Dispose(bool disposing)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected abstract bool ReleaseHandle();

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void SetHandleAsInvalid()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public void DangerousAddRef(ref bool success)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void DangerousRelease()
	{
	}

	private void InternalDispose()
	{
	}

	private void InternalFinalize()
	{
	}

	private void DangerousReleaseInternal(bool dispose)
	{
	}
}
