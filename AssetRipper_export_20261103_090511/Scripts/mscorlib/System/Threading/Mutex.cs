using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading;

[ComVisible(true)]
public sealed class Mutex : WaitHandle
{
	private unsafe static IntPtr CreateMutex_icall(bool initiallyOwned, char* name, int name_length, out bool created)
	{
		created = default;
		return (IntPtr)0;
	}

	private static bool ReleaseMutex_internal(IntPtr handle)
	{
		return false;
	}

	private static IntPtr CreateMutex_internal(bool initiallyOwned, string name, out bool created)
	{
		created = default;
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public Mutex()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public Mutex(bool initiallyOwned)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public void ReleaseMutex()
	{
	}
}
