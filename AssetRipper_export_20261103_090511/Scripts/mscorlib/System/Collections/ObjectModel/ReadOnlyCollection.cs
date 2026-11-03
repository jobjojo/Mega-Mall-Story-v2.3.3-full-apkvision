using System.Collections.Generic;
using System.Diagnostics;

namespace System.Collections.ObjectModel;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
public class ReadOnlyCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	private IList<T> list;

	[NonSerialized]
	private object _syncRoot;

	public int Count => 0;

	public T this[int index] => default;

	bool ICollection<T>.IsReadOnly => false;

	T IList<T>.this[int index]
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	object ICollection.SyncRoot => null;

	bool IList.IsReadOnly => false;

	object IList.this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyCollection(IList<T> list)
	{
	}

	public bool Contains(T value)
	{
		return false;
	}

	public void CopyTo(T[] array, int index)
	{
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	public int IndexOf(T value)
	{
		return 0;
	}

	void ICollection<T>.Add(T value)
	{
	}

	void ICollection<T>.Clear()
	{
	}

	void IList<T>.Insert(int index, T value)
	{
	}

	bool ICollection<T>.Remove(T value)
	{
		return false;
	}

	void IList<T>.RemoveAt(int index)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	void ICollection.CopyTo(Array array, int index)
	{
	}

	int IList.Add(object value)
	{
		return 0;
	}

	void IList.Clear()
	{
	}

	private static bool IsCompatibleObject(object value)
	{
		return false;
	}

	bool IList.Contains(object value)
	{
		return false;
	}

	int IList.IndexOf(object value)
	{
		return 0;
	}

	void IList.Insert(int index, object value)
	{
	}

	void IList.Remove(object value)
	{
	}

	void IList.RemoveAt(int index)
	{
	}
}
