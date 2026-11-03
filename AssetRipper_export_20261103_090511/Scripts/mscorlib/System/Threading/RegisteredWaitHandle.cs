using System.Runtime.InteropServices;

namespace System.Threading;

[ComVisible(true)]
public sealed class RegisteredWaitHandle : MarshalByRefObject
{
	private WaitHandle _waitObject;

	private WaitOrTimerCallback _callback;

	private object _state;

	private WaitHandle _finalEvent;

	private ManualResetEvent _cancelEvent;

	private TimeSpan _timeout;

	private int _callsInProcess;

	private bool _executeOnlyOnce;

	private bool _unregistered;

	internal RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce)
	{
	}

	internal void Wait(object state)
	{
	}

	private void DoCallBack(object timedOut)
	{
	}

	[ComVisible(true)]
	public bool Unregister(WaitHandle waitObject)
	{
		return false;
	}

	internal RegisteredWaitHandle()
	{
	}
}
