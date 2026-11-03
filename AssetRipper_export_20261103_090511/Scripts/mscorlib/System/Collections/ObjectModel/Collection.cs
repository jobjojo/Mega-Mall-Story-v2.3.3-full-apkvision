using System.Collections.Generic;
using System.Diagnostics;

namespace System.Collections.ObjectModel;

[Serializable]
[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	private IList<T> items;

	public int Count => 0;

	public T this[int index]
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	bool ICollection<T>.IsReadOnly => false;

	object ICollection.SyncRoot => null;

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

	bool IList.IsReadOnly => false;

	public void Add(T item)
	{
	}

	public void Clear()
	{
	}

	public void CopyTo(T[] array, int index)
	{
	}

	public bool Contains(T item)
	{
		return false;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	public int IndexOf(T item)
	{
		return 0;
	}

	public void Insert(int index, T item)
	{
	}

	public bool Remove(T item)
	{
		return false;
	}

	public void RemoveAt(int index)
	{
	}

	protected virtual void ClearItems()
	{
	}

	protected virtual void InsertItem(int index, T item)
	{
	}

	protected virtual void RemoveItem(int index)
	{
	}

	protected virtual void SetItem(int index, T item)
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

	private static bool IsCompatibleObject(object value)
	{
		return false;
	}
}
