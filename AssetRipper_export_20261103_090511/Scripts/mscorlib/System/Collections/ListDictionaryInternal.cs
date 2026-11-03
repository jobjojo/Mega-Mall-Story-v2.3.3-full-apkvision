namespace System.Collections;

[Serializable]
internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable
{
	private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private ListDictionaryInternal list;

		private DictionaryNode current;

		private int version;

		private bool start;

		public object Current => null;

		public DictionaryEntry Entry => default;

		public object Key => null;

		public object Value => null;

		public NodeEnumerator(ListDictionaryInternal list)
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

	[Serializable]
	private class DictionaryNode
	{
		public object key;

		public object value;

		public DictionaryNode next;
	}

	private DictionaryNode head;

	private int version;

	private int count;

	[NonSerialized]
	private object _syncRoot;

	public object this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Count => 0;

	public object SyncRoot => null;

	public bool Contains(object key)
	{
		return false;
	}

	public void CopyTo(Array array, int index)
	{
	}

	public IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
