namespace System.Collections;

[Serializable]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
{
	private ArrayList _list;

	protected ArrayList InnerList => null;

	public virtual int Count => 0;

	object ICollection.SyncRoot => null;

	void ICollection.CopyTo(Array array, int index)
	{
	}

	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}
}
