using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

[Serializable]
[ComVisible(true)]
public readonly struct StreamingContext
{
	internal readonly object m_additionalContext = null;

	internal readonly StreamingContextStates m_state = (StreamingContextStates)0;

	public StreamingContextStates State => (StreamingContextStates)0;

	public StreamingContext(StreamingContextStates state)
	{
	}

	public StreamingContext(StreamingContextStates state, object additional)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
