namespace System.Collections;

public interface ICollection : IEnumerable
{
	int Count { get; }

	object SyncRoot { get; }

	void CopyTo(Array array, int index);
}
