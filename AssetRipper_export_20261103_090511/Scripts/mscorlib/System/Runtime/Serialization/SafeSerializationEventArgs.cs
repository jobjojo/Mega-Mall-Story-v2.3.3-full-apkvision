using System.Collections.Generic;

namespace System.Runtime.Serialization;

public sealed class SafeSerializationEventArgs : EventArgs
{
	private StreamingContext m_streamingContext;

	private List<object> m_serializedStates;

	internal IList<object> SerializedStates => null;

	internal SafeSerializationEventArgs(StreamingContext streamingContext)
	{
	}

	internal SafeSerializationEventArgs()
	{
	}
}
