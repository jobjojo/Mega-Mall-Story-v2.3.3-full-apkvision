using System.Threading;

namespace System.IO;

internal class FileStreamAsyncResult : IAsyncResult
{
	private object state;

	private bool completed;

	private ManualResetEvent wh;

	private AsyncCallback cb;

	public int Count;

	public int OriginalCount;

	public int BytesRead;

	private AsyncCallback realcb;

	public WaitHandle AsyncWaitHandle => null;

	public bool IsCompleted => false;

	public FileStreamAsyncResult(AsyncCallback cb, object state)
	{
	}

	private static void CBWrapper(IAsyncResult ares)
	{
	}
}
