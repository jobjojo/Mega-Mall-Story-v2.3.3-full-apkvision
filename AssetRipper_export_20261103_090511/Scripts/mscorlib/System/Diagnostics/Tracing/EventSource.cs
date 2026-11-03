namespace System.Diagnostics.Tracing;

public class EventSource : IDisposable
{
	protected internal struct EventData
	{
		public IntPtr DataPointer { set; }

		public int Size { set; }

		internal int Reserved { set; }
	}

	private string Name { set; }

	protected EventSource()
	{
	}

	public EventSource(string eventSourceName)
	{
	}

	internal EventSource(Guid eventSourceGuid, string eventSourceName)
	{
	}

	~EventSource()
	{
	}

	public bool IsEnabled()
	{
		return false;
	}

	public bool IsEnabled(EventLevel level, EventKeywords keywords)
	{
		return false;
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	protected void WriteEvent(int eventId, int arg1)
	{
	}

	protected void WriteEvent(int eventId, int arg1, int arg2)
	{
	}

	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3)
	{
	}

	protected void WriteEvent(int eventId, params object[] args)
	{
	}

	[CLSCompliant(false)]
	protected unsafe void WriteEventCore(int eventId, int eventDataCount, EventData* data)
	{
	}
}
