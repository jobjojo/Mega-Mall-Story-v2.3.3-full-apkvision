using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
[MonoTODO("Serialization format not compatible with .NET")]
public sealed class Evidence : ICollection, IEnumerable
{
	private class EvidenceEnumerator : IEnumerator
	{
		private IEnumerator currentEnum;

		private IEnumerator hostEnum;

		private IEnumerator assemblyEnum;

		public object Current => null;

		public EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum)
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

	private bool _locked;

	private ArrayList hostEvidenceList;

	private ArrayList assemblyEvidenceList;

	[Obsolete]
	public int Count => 0;

	public object SyncRoot => null;

	[Obsolete]
	public void CopyTo(Array array, int index)
	{
	}

	[Obsolete]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
