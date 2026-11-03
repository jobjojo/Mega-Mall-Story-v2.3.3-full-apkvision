using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Text.RegularExpressions;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Group>))]
public class GroupCollection : IList<Group>, ICollection<Group>, IEnumerable<Group>, IEnumerable, IReadOnlyList<Group>, IReadOnlyCollection<Group>, IList, ICollection
{
	private sealed class Enumerator : IEnumerator<Group>, IDisposable, IEnumerator
	{
		private readonly GroupCollection _collection;

		private int _index;

		public Group Current => null;

		object IEnumerator.Current => null;

		internal Enumerator(GroupCollection collection)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}

		void IDisposable.Dispose()
		{
		}
	}

	private readonly Match _match;

	private readonly Hashtable _captureMap;

	private Group[] _groups;

	public bool IsReadOnly => false;

	public int Count => 0;

	public Group this[int groupnum] => null;

	public object SyncRoot => null;

	Group IList<Group>.this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	internal GroupCollection(Match match, Hashtable caps)
	{
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	IEnumerator<Group> IEnumerable<Group>.GetEnumerator()
	{
		return null;
	}

	private Group GetGroup(int groupnum)
	{
		return null;
	}

	private Group GetGroupImpl(int groupnum)
	{
		return null;
	}

	public void CopyTo(Array array, int arrayIndex)
	{
	}

	public void CopyTo(Group[] array, int arrayIndex)
	{
	}

	int IList<Group>.IndexOf(Group item)
	{
		return 0;
	}

	void IList<Group>.Insert(int index, Group item)
	{
	}

	void IList<Group>.RemoveAt(int index)
	{
	}

	void ICollection<Group>.Add(Group item)
	{
	}

	void ICollection<Group>.Clear()
	{
	}

	bool ICollection<Group>.Contains(Group item)
	{
		return false;
	}

	bool ICollection<Group>.Remove(Group item)
	{
		return false;
	}

	int IList.Add(object value)
	{
		return 0;
	}

	void IList.Clear()
	{
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

	internal GroupCollection()
	{
	}
}
