using System.Collections;
using System.Collections.Generic;

namespace System.Security.Cryptography;

public sealed class OidCollection : ICollection, IEnumerable
{
	private readonly List<Oid> _list;

	public Oid this[int index] => null;

	public int Count => 0;

	public object SyncRoot => null;

	public int Add(Oid oid)
	{
		return 0;
	}

	public OidEnumerator GetEnumerator()
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
