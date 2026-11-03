namespace System.Collections.Generic;

internal sealed class LowLevelListWithIList<T> : LowLevelList<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	private struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private LowLevelListWithIList<T> _list = null;

		private int _index = 0;

		private int _version = 0;

		private T _current = default;

		public T Current => default;

		object IEnumerator.Current => null;

		internal Enumerator(LowLevelListWithIList<T> list)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		private bool MoveNextRare()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	bool ICollection<T>.IsReadOnly => false;

	public LowLevelListWithIList()
	{
	}

	public LowLevelListWithIList(int capacity)
	{
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
