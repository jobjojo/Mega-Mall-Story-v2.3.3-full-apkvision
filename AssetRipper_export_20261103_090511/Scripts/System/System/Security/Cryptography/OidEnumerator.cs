using System.Collections;

namespace System.Security.Cryptography;

public sealed class OidEnumerator : IEnumerator
{
	private readonly OidCollection _oids;

	private int _current;

	public Oid Current => null;

	object IEnumerator.Current => null;

	internal OidEnumerator(OidCollection oids)
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
