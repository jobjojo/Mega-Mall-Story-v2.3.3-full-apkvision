using System.Runtime.CompilerServices;

namespace System.Threading;

public static class ThreadPool
{
	internal static bool IsThreadPoolThread => false;

	public static bool SetMaxThreads(int workerThreads, int completionPortThreads)
	{
		return false;
	}

	public static void GetMaxThreads(out int workerThreads, out int completionPortThreads)
	{
		workerThreads = default;
		completionPortThreads = default;
	}

	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool QueueUserWorkItem(WaitCallback callBack, object state)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state)
	{
		return false;
	}

	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true)
	{
		return false;
	}

	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
	{
	}

	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
	{
		return false;
	}

	internal static bool RequestWorkerThread()
	{
		return false;
	}

	private static void EnsureVMInitialized()
	{
	}

	private static bool SetMaxThreadsNative(int workerThreads, int completionPortThreads)
	{
		return false;
	}

	private static void GetMaxThreadsNative(out int workerThreads, out int completionPortThreads)
	{
		workerThreads = default;
		completionPortThreads = default;
	}

	internal static bool NotifyWorkItemComplete()
	{
		return false;
	}

	internal static void ReportThreadStatus(bool isWorking)
	{
	}

	internal static void NotifyWorkItemProgress()
	{
	}

	internal static void NotifyWorkItemProgressNative()
	{
	}

	internal static void NotifyWorkItemQueued()
	{
	}

	private static void InitializeVMTp(ref bool enableWorkerTracking)
	{
	}
}
