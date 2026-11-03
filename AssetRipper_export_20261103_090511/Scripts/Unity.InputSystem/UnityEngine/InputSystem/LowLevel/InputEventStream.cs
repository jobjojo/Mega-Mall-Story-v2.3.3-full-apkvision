namespace UnityEngine.InputSystem.LowLevel;

internal struct InputEventStream
{
	private InputEventBuffer m_NativeBuffer = default;

	private unsafe InputEvent* m_CurrentNativeEventReadPtr = null;

	private unsafe InputEvent* m_CurrentNativeEventWritePtr = null;

	private int m_RemainingNativeEventCount = 0;

	private readonly int m_MaxAppendedEvents = 0;

	private InputEventBuffer m_AppendBuffer = default;

	private unsafe InputEvent* m_CurrentAppendEventReadPtr = null;

	private unsafe InputEvent* m_CurrentAppendEventWritePtr = null;

	private int m_RemainingAppendEventCount = 0;

	private int m_NumEventsRetainedInBuffer = 0;

	private bool m_IsOpen = false;

	public bool isOpen => false;

	public int remainingEventCount => 0;

	public int numEventsRetainedInBuffer => 0;

	public unsafe InputEvent* currentEventPtr => null;

	public uint numBytesRetainedInBuffer => 0u;

	public unsafe InputEventStream(ref InputEventBuffer eventBuffer, int maxAppendedEvents)
	{
	}

	public void Close(ref InputEventBuffer eventBuffer)
	{
	}

	public void CleanUpAfterException()
	{
	}

	public unsafe void Write(InputEvent* eventPtr)
	{
	}

	public unsafe InputEvent* Advance(bool leaveEventInBuffer)
	{
		return null;
	}

	public unsafe InputEvent* Peek()
	{
		return null;
	}
}
