namespace kairo.unity.util;

public sealed class FastLinkedListNode<T>
{
	public T Value;

	public FastLinkedListNode<T> Next;

	public FastLinkedListNode<T> Previous;

	public FastLinkedListNode()
	{
	}

	public FastLinkedListNode(T value)
	{
	}
}
