using System.Collections;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices;

public sealed class ConditionalWeakTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TKey : class where TValue : class
{
	public delegate TValue CreateValueCallback(TKey key);

	private sealed class Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
	{
		private ConditionalWeakTable<TKey, TValue> _table;

		private int _currentIndex;

		private KeyValuePair<TKey, TValue> _current;

		public KeyValuePair<TKey, TValue> Current => default;

		object IEnumerator.Current => null;

		public Enumerator(ConditionalWeakTable<TKey, TValue> table)
		{
		}

		~Enumerator()
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	private const int INITIAL_SIZE = 13;

	private const float LOAD_FACTOR = 0.7f;

	private const float COMPACT_FACTOR = 0.5f;

	private const float EXPAND_FACTOR = 1.1f;

	private Ephemeron[] data;

	private object _lock;

	private int size;

	~ConditionalWeakTable()
	{
	}

	private void RehashWithoutResize()
	{
	}

	private void RecomputeSize()
	{
	}

	private void Rehash()
	{
	}

	public void Add(TKey key, TValue value)
	{
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		value = null;
		return false;
	}

	public TValue GetValue(TKey key, CreateValueCallback createValueCallback)
	{
		return null;
	}

	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
