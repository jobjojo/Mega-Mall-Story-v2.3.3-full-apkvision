using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Text.RegularExpressions;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Match>))]
public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection
{
	[Serializable]
	private sealed class Enumerator : IEnumerator<Match>, IDisposable, IEnumerator
	{
		private readonly MatchCollection _collection;

		private int _index;

		public Match Current => null;

		object IEnumerator.Current => null;

		internal Enumerator(MatchCollection collection)
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

	private readonly Regex _regex;

	private readonly List<Match> _matches;

	private bool _done;

	private readonly string _input;

	private readonly int _beginning;

	private readonly int _length;

	private int _startat;

	private int _prevlen;

	public bool IsReadOnly => false;

	public int Count => 0;

	public virtual Match this[int i] => null;

	public object SyncRoot => null;

	Match IList<Match>.this[int index]
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

	internal MatchCollection(Regex regex, string input, int beginning, int length, int startat)
	{
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	IEnumerator<Match> IEnumerable<Match>.GetEnumerator()
	{
		return null;
	}

	private Match GetMatch(int i)
	{
		return null;
	}

	private void EnsureInitialized()
	{
	}

	public void CopyTo(Array array, int arrayIndex)
	{
	}

	public void CopyTo(Match[] array, int arrayIndex)
	{
	}

	int IList<Match>.IndexOf(Match item)
	{
		return 0;
	}

	void IList<Match>.Insert(int index, Match item)
	{
	}

	void IList<Match>.RemoveAt(int index)
	{
	}

	void ICollection<Match>.Add(Match item)
	{
	}

	void ICollection<Match>.Clear()
	{
	}

	bool ICollection<Match>.Contains(Match item)
	{
		return false;
	}

	bool ICollection<Match>.Remove(Match item)
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

	internal MatchCollection()
	{
	}
}
