using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Threading;

[ComVisible(true)]
public sealed class Timer : MarshalByRefObject, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	private struct TimerComparer : IComparer, IComparer<Timer>
	{
		int IComparer.Compare(object x, object y)
		{
			return 0;
		}

		public int Compare(Timer tx, Timer ty)
		{
			return 0;
		}
	}

	private sealed class Scheduler
	{
		private static readonly Scheduler instance;

		private bool needReSort;

		private List<Timer> list;

		private long current_next_run;

		private ManualResetEvent changed;

		public static Scheduler Instance => null;

		private void InitScheduler()
		{
		}

		private void WakeupScheduler()
		{
		}

		private void SchedulerThread()
		{
		}

		private Scheduler()
		{
		}

		public void Remove(Timer timer)
		{
		}

		public void Change(Timer timer, long new_next_run)
		{
		}

		private void Add(Timer timer)
		{
		}

		private void InternalRemove(Timer timer)
		{
		}

		private static void TimerCB(object o)
		{
		}

		private void FireTimer(Timer timer)
		{
		}

		private int RunSchedulerLoop()
		{
			return 0;
		}
	}

	private TimerCallback callback;

	private object state;

	private long due_time_ms;

	private long period_ms;

	private long next_run;

	private bool disposed;

	private bool is_dead;

	private bool is_added;

	private const long MaxValue = 4294967294L;

	private static Scheduler scheduler => null;

	public Timer(TimerCallback callback, object state, int dueTime, int period)
	{
	}

	public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period)
	{
	}

	private void Init(TimerCallback callback, object state, long dueTime, long period)
	{
	}

	public bool Change(TimeSpan dueTime, TimeSpan period)
	{
		return false;
	}

	public void Dispose()
	{
	}

	private bool Change(long dueTime, long period, bool first)
	{
		return false;
	}

	internal void KeepRootedWhileScheduled()
	{
	}

	private static long GetTimeMonotonic()
	{
		return 0L;
	}
}
