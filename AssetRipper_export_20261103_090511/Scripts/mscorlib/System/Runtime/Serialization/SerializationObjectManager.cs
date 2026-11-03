using System.Collections.Generic;

namespace System.Runtime.Serialization;

public sealed class SerializationObjectManager
{
	private readonly Dictionary<object, object> _objectSeenTable;

	private readonly StreamingContext _context;

	private SerializationEventHandler _onSerializedHandler;

	public SerializationObjectManager(StreamingContext context)
	{
	}

	public void RegisterObject(object obj)
	{
	}

	public void RaiseOnSerializedEvent()
	{
	}

	private void AddOnSerialized(object obj)
	{
	}
}
