using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[DebuggerTypeProxy(typeof(StackDebugView<>))]
public class Stack<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[Serializable]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly Stack<T> _stack = null;

		private readonly int _version = 0;

		private int _index = 0;

		private T _currentElement = default;

		public T Current => default;

		object IEnumerator.Current => null;

		internal Enumerator(Stack<T> stack)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		private void ThrowEnumerationNotStartedOrEnded()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private T[] _array;

	private int _size;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	public int Count => 0;

	object ICollection.SyncRoot => null;

	public void Clear()
	{
	}

	void ICollection.CopyTo(Array array, int arrayIndex)
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

	public T Peek()
	{
		return default;
	}

	public T Pop()
	{
		return default;
	}

	public void Push(T item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PushWithResize(T item)
	{
	}

	private void ThrowForEmptyStack()
	{
	}
}
