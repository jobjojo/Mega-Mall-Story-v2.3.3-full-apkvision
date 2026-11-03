using System.Collections.Generic;
using System.Threading;
using UnityEngine.Scripting;

namespace UnityEngine;

internal sealed class UnitySynchronizationContext : SynchronizationContext
{
	private struct WorkRequest(SendOrPostCallback callback, object state, ManualResetEvent waitHandle = null)
	{
		private readonly SendOrPostCallback m_DelagateCallback = null;

		private readonly object m_DelagateState = null;

		private readonly ManualResetEvent m_WaitHandle = null;

		public void Invoke()
		{
		}
	}

	private readonly List<WorkRequest> m_AsyncWorkQueue;

	private readonly List<WorkRequest> m_CurrentFrameWork;

	private readonly int m_MainThreadID;

	private int m_TrackedCount;

	private UnitySynchronizationContext(int mainThreadID)
	{
	}

	private UnitySynchronizationContext(List<WorkRequest> queue, int mainThreadID)
	{
	}

	public override void Send(SendOrPostCallback callback, object state)
	{
	}

	public override void Post(SendOrPostCallback callback, object state)
	{
	}

	public override SynchronizationContext CreateCopy()
	{
		return null;
	}

	public void Exec()
	{
	}

	private bool HasPendingTasks()
	{
		return false;
	}

	[RequiredByNativeCode]
	private static void InitializeSynchronizationContext()
	{
	}

	[RequiredByNativeCode]
	private static void ExecuteTasks()
	{
	}

	[RequiredByNativeCode]
	private static bool ExecutePendingTasks(long millisecondsTimeout)
	{
		return false;
	}
}
