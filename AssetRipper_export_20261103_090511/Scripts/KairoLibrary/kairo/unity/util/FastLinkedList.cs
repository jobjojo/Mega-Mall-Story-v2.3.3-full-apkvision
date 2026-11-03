namespace kairo.unity.util;

public class FastLinkedList<T>
{
	private const int EXPAND = 50;

	private int bufIndex_;

	private FastLinkedListNode<T>[] buf_;

	private int invalidListNum_;

	private FastLinkedListNode<T>[] invalidList_;

	private int count_;

	public FastLinkedListNode<T> First;

	public FastLinkedListNode<T> Last;

	public int Count => 0;

	public void Clear()
	{
	}

	private FastLinkedListNode<T> Add(T value)
	{
		return null;
	}

	public FastLinkedListNode<T> AddFirst(T value)
	{
		return null;
	}

	public FastLinkedListNode<T> AddLast(T value)
	{
		return null;
	}

	public FastLinkedListNode<T> AddAfter(FastLinkedListNode<T> node, T value)
	{
		return null;
	}

	public FastLinkedListNode<T> AddBefore(FastLinkedListNode<T> node, T value)
	{
		return null;
	}

	public void Remove(FastLinkedListNode<T> node)
	{
	}

	public void RemoveFirst()
	{
	}

	public void RemoveLast()
	{
	}

	public FastLinkedListNode<T> Find(T value)
	{
		return null;
	}

	public FastLinkedListNode<T> FindLast(T value)
	{
		return null;
	}
}
