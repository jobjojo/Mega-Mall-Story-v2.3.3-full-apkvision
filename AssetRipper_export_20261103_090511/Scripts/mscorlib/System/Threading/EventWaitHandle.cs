using System.Runtime.InteropServices;

namespace System.Threading;

[ComVisible(true)]
public class EventWaitHandle : WaitHandle
{
	public EventWaitHandle(bool initialState, EventResetMode mode)
	{
	}

	public EventWaitHandle(bool initialState, EventResetMode mode, string name)
	{
	}

	public bool Reset()
	{
		return false;
	}

	public bool Set()
	{
		return false;
	}
}
