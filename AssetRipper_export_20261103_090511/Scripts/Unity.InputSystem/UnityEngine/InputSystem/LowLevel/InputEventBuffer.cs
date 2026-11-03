using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.InputSystem.LowLevel;

public struct InputEventBuffer : IEnumerable<InputEventPtr>, IEnumerable, IDisposable, ICloneable
{
	private unsafe struct Enumerator(InputEventBuffer buffer) : IEnumerator<InputEventPtr>, IEnumerator, IDisposable
	{
		private unsafe readonly InputEvent* m_Buffer = null;

		private readonly int m_EventCount = 0;

		private unsafe InputEvent* m_CurrentEvent = null;

		private int m_CurrentIndex = 0;

		public InputEventPtr Current => default;

		object IEnumerator.Current => null;

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	public const long BufferSizeUnknown = -1L;

	private NativeArray<byte> m_Buffer = default;

	private long m_SizeInBytes = 0L;

	private int m_EventCount = 0;

	private bool m_WeOwnTheBuffer = false;

	public int eventCount => 0;

	public long sizeInBytes => 0L;

	public long capacityInBytes => 0L;

	public NativeArray<byte> data => default;

	public InputEventPtr bufferPtr => default;

	public unsafe InputEventBuffer(InputEvent* eventPtr, int eventCount, int sizeInBytes = -1, int capacityInBytes = -1)
	{
	}

	public InputEventBuffer(NativeArray<byte> buffer, int eventCount, int sizeInBytes = -1, bool transferNativeArrayOwnership = false)
	{
	}

	public unsafe void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes = 2048, Allocator allocator = Allocator.Persistent)
	{
	}

	public unsafe InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes = 2048, Allocator allocator = Allocator.Persistent)
	{
		return null;
	}

	public unsafe bool Contains(InputEvent* eventPtr)
	{
		return false;
	}

	public void Reset()
	{
	}

	internal unsafe void AdvanceToNextEvent(ref InputEvent* currentReadPos, ref InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer)
	{
	}

	public IEnumerator<InputEventPtr> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Dispose()
	{
	}

	public InputEventBuffer Clone()
	{
		return default;
	}

	object ICloneable.Clone()
	{
		return null;
	}
}
