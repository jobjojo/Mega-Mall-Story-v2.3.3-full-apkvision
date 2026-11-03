using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

internal struct LargeArrayBuilder<T>
{
	private readonly int _maxCapacity = 0;

	private T[] _first = null;

	private ArrayBuilder<T[]> _buffers = default;

	private T[] _current = null;

	private int _index = 0;

	private int _count = 0;

	public LargeArrayBuilder(bool initialize)
	{
	}

	public LargeArrayBuilder(int maxCapacity)
	{
	}

	public void AddRange(IEnumerable<T> items)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddWithBufferAllocation(T item, ref T[] destination, ref int index)
	{
	}

	public void CopyTo(T[] array, int arrayIndex, int count)
	{
	}

	public T[] GetBuffer(int index)
	{
		return null;
	}

	public T[] ToArray()
	{
		return null;
	}

	public bool TryMove(out T[] array)
	{
		array = null;
		return false;
	}

	private void AllocateBuffer()
	{
	}
}
