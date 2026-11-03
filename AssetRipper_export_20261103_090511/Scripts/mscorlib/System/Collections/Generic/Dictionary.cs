using System.Diagnostics;
using System.Runtime.Serialization;

namespace System.Collections.Generic;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback
{
	private struct Entry
	{
		public int hashCode;

		public int next;

		public TKey key;

		public TValue value;
	}

	[Serializable]
	public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		private Dictionary<TKey, TValue> _dictionary = null;

		private int _version = 0;

		private int _index = 0;

		private KeyValuePair<TKey, TValue> _current = default;

		private int _getEnumeratorRetType = 0;

		public KeyValuePair<TKey, TValue> Current => default;

		object IEnumerator.Current => null;

		DictionaryEntry IDictionaryEnumerator.Entry => default;

		object IDictionaryEnumerator.Key => null;

		object IDictionaryEnumerator.Value => null;

		internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Dispose()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		[Serializable]
		public struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			private Dictionary<TKey, TValue> _dictionary = null;

			private int _index = 0;

			private int _version = 0;

			private TKey _currentKey = default;

			public TKey Current => default;

			object IEnumerator.Current => null;

			internal Enumerator(Dictionary<TKey, TValue> dictionary)
			{
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}
		}

		private Dictionary<TKey, TValue> _dictionary;

		public int Count => 0;

		bool ICollection<TKey>.IsReadOnly => false;

		object ICollection.SyncRoot => null;

		public KeyCollection(Dictionary<TKey, TValue> dictionary)
		{
		}

		public Enumerator GetEnumerator()
		{
			return default;
		}

		public void CopyTo(TKey[] array, int index)
		{
		}

		void ICollection<TKey>.Add(TKey item)
		{
		}

		void ICollection<TKey>.Clear()
		{
		}

		bool ICollection<TKey>.Contains(TKey item)
		{
			return false;
		}

		bool ICollection<TKey>.Remove(TKey item)
		{
			return false;
		}

		IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		[Serializable]
		public struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			private Dictionary<TKey, TValue> _dictionary = null;

			private int _index = 0;

			private int _version = 0;

			private TValue _currentValue = default;

			public TValue Current => default;

			object IEnumerator.Current => null;

			internal Enumerator(Dictionary<TKey, TValue> dictionary)
			{
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}
		}

		private Dictionary<TKey, TValue> _dictionary;

		public int Count => 0;

		bool ICollection<TValue>.IsReadOnly => false;

		object ICollection.SyncRoot => null;

		public ValueCollection(Dictionary<TKey, TValue> dictionary)
		{
		}

		public Enumerator GetEnumerator()
		{
			return default;
		}

		public void CopyTo(TValue[] array, int index)
		{
		}

		void ICollection<TValue>.Add(TValue item)
		{
		}

		bool ICollection<TValue>.Remove(TValue item)
		{
			return false;
		}

		void ICollection<TValue>.Clear()
		{
		}

		bool ICollection<TValue>.Contains(TValue item)
		{
			return false;
		}

		IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}
	}

	private int[] _buckets;

	private Entry[] _entries;

	private int _count;

	private int _freeList;

	private int _freeCount;

	private int _version;

	private IEqualityComparer<TKey> _comparer;

	private KeyCollection _keys;

	private ValueCollection _values;

	private object _syncRoot;

	private const string VersionName = "Version";

	private const string HashSizeName = "HashSize";

	private const string KeyValuePairsName = "KeyValuePairs";

	private const string ComparerName = "Comparer";

	public int Count => 0;

	public KeyCollection Keys => null;

	public ValueCollection Values => null;

	public TValue this[TKey key]
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

	object ICollection.SyncRoot => null;

	object IDictionary.this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary()
	{
	}

	public Dictionary(int capacity)
	{
	}

	public Dictionary(IEqualityComparer<TKey> comparer)
	{
	}

	public Dictionary(int capacity, IEqualityComparer<TKey> comparer)
	{
	}

	public Dictionary(IDictionary<TKey, TValue> dictionary)
	{
	}

	public Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
	{
	}

	protected Dictionary(SerializationInfo info, StreamingContext context)
	{
	}

	public void Add(TKey key, TValue value)
	{
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
	{
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
	{
		return false;
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
	{
		return false;
	}

	public void Clear()
	{
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	public bool ContainsValue(TValue value)
	{
		return false;
	}

	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
	{
	}

	public Enumerator GetEnumerator()
	{
		return default;
	}

	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		return null;
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private int FindEntry(TKey key)
	{
		return 0;
	}

	private int Initialize(int capacity)
	{
		return 0;
	}

	private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior)
	{
		return false;
	}

	public virtual void OnDeserialization(object sender)
	{
	}

	private void Resize()
	{
	}

	private void Resize(int newSize, bool forceNewHashCodes)
	{
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		value = default;
		return false;
	}

	public bool TryAdd(TKey key, TValue value)
	{
		return false;
	}

	void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
	{
	}

	void ICollection.CopyTo(Array array, int index)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	private static bool IsCompatibleKey(object key)
	{
		return false;
	}

	bool IDictionary.Contains(object key)
	{
		return false;
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return null;
	}
}
