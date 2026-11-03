using System.Diagnostics;

namespace System.Collections;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ArrayListDebugView))]
public class ArrayList : IList, ICollection, IEnumerable, ICloneable
{
	[Serializable]
	private sealed class ArrayListEnumeratorSimple : IEnumerator, ICloneable
	{
		private ArrayList _list;

		private int _index;

		private int _version;

		private object _currentElement;

		private bool _isArrayList;

		private static object s_dummyObject;

		public object Current => null;

		internal ArrayListEnumeratorSimple(ArrayList list)
		{
		}

		public object Clone()
		{
			return null;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	internal class ArrayListDebugView
	{
	}

	private object[] _items;

	private int _size;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	private const int _defaultCapacity = 4;

	internal const int MaxArrayLength = 2146435071;

	public virtual int Capacity
	{
		set
		{
		}
	}

	public virtual int Count => 0;

	public virtual bool IsReadOnly => false;

	public virtual object SyncRoot => null;

	public virtual object this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ArrayList()
	{
	}

	public ArrayList(int capacity)
	{
	}

	public ArrayList(ICollection c)
	{
	}

	public virtual int Add(object value)
	{
		return 0;
	}

	public virtual void AddRange(ICollection c)
	{
	}

	public virtual void Clear()
	{
	}

	public virtual object Clone()
	{
		return null;
	}

	public virtual bool Contains(object item)
	{
		return false;
	}

	public virtual void CopyTo(Array array, int arrayIndex)
	{
	}

	private void EnsureCapacity(int min)
	{
	}

	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}

	public virtual int IndexOf(object value)
	{
		return 0;
	}

	public virtual void Insert(int index, object value)
	{
	}

	public virtual void InsertRange(int index, ICollection c)
	{
	}

	public virtual void Remove(object obj)
	{
	}

	public virtual void RemoveAt(int index)
	{
	}

	public virtual object[] ToArray()
	{
		return null;
	}

	public virtual Array ToArray(Type type)
	{
		return null;
	}
}
