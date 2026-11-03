namespace System.ComponentModel;

public sealed class EventHandlerList : IDisposable
{
	private sealed class ListEntry
	{
		internal ListEntry _next;

		internal object _key;

		internal Delegate _handler;
	}

	private ListEntry _head;

	private Component _parent;

	public Delegate this[object key] => null;

	public void Dispose()
	{
	}

	private ListEntry Find(object key)
	{
		return null;
	}
}
