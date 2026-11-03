using System.Runtime.InteropServices;
using System.Threading;

namespace System;

[StructLayout((LayoutKind)0)]
internal abstract class IOAsyncResult
{
	private AsyncCallback async_callback;

	private object async_state;

	private ManualResetEvent wait_handle;

	private bool completed_synchronously;

	private bool completed;
}
