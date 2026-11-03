using System.Runtime.InteropServices;
using System.Threading;

namespace System.Runtime.Remoting.Messaging;

[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem
{
	private object async_state;

	private WaitHandle handle;

	private object async_delegate;

	private IntPtr data;

	private object object_data;

	private bool sync_completed;

	private bool completed;

	private bool endinvoke_called;

	private object async_callback;

	private ExecutionContext current;

	private ExecutionContext original;

	private long add_time;

	private MonoMethodMessage call_message;

	private IMessageCtrl message_ctrl;

	private IMessage reply_message;

	private WaitCallback orig_cb;

	public virtual object AsyncState => null;

	public virtual WaitHandle AsyncWaitHandle => null;

	public virtual bool CompletedSynchronously => false;

	public virtual bool IsCompleted => false;

	public bool EndInvokeCalled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual object AsyncDelegate => null;

	public IMessageSink NextSink => null;

	internal MonoMethodMessage CallMessage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal AsyncResult()
	{
	}

	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
	{
		return null;
	}

	public virtual IMessage GetReplyMessage()
	{
		return null;
	}

	public virtual void SetMessageCtrl(IMessageCtrl mc)
	{
	}

	internal void SetCompletedSynchronously(bool completed)
	{
	}

	internal IMessage EndInvoke()
	{
		return null;
	}

	public virtual IMessage SyncProcessMessage(IMessage msg)
	{
		return null;
	}

	void IThreadPoolWorkItem.ExecuteWorkItem()
	{
	}

	void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
	{
	}

	internal object Invoke()
	{
		return null;
	}
}
