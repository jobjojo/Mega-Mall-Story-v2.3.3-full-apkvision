using System.Diagnostics;
using System.Runtime.Serialization;

namespace System.Collections.Generic;

[Serializable]
[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	internal struct Slot
	{
		internal int hashCode;

		internal int next;

		internal T value;
	}

	[Serializable]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private HashSet<T> _set = null;

		private int _index = 0;

		private int _version = 0;

		private T _current = default;

		public T Current => default;

		object IEnumerator.Current => null;

		internal Enumerator(HashSet<T> set)
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

	private const int Lower31BitMask = int.MaxValue;

	private const int StackAllocThreshold = 100;

	private const int ShrinkThreshold = 3;

	private const string CapacityName = "Capacity";

	private const string ElementsName = "Elements";

	private const string ComparerName = "Comparer";

	private const string VersionName = "Version";

	private int[] _buckets;

	private Slot[] _slots;

	private int _count;

	private int _lastIndex;

	private int _freeList;

	private IEqualityComparer<T> _comparer;

	private int _version;

	private SerializationInfo _siInfo;

	public int Count => 0;

	bool ICollection<T>.IsReadOnly => false;

	public HashSet()
	{
	}

	public HashSet(IEqualityComparer<T> comparer)
	{
	}

	protected HashSet(SerializationInfo info, StreamingContext context)
	{
	}

	void ICollection<T>.Add(T item)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(T item)
	{
		return false;
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	public bool Remove(T item)
	{
		return false;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public virtual void OnDeserialization(object sender)
	{
	}

	public bool Add(T item)
	{
		return false;
	}

	public void CopyTo(T[] array)
	{
	}

	public void CopyTo(T[] array, int arrayIndex, int count)
	{
	}

	private int Initialize(int capacity)
	{
		return 0;
	}

	private void IncreaseCapacity()
	{
	}

	private void SetCapacity(int newSize)
	{
	}

	private bool AddIfNotPresent(T value)
	{
		return false;
	}

	private int InternalGetHashCode(T item)
	{
		return 0;
	}
}
