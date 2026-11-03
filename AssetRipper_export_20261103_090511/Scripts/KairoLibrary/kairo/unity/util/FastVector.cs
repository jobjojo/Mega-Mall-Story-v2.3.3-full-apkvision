using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace kairo.unity.util;

public class FastVector : FastVector<object>
{
}
public class FastVector<T> : IEnumerable
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__42 : IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FastVector<T> _003C_003E4__this;

		private T[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__42(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public int capacityIncrement;

	public int elementCount;

	public T[] elementData;

	public int bufSize_;

	public FastVector()
	{
	}

	public FastVector(int initialCapacity)
	{
	}

	public FastVector(int initialCapacity, int capacityIncrement)
	{
	}

	public void AddElement(T obj)
	{
	}

	public void Add(T obj)
	{
	}

	public int Capacity()
	{
		return 0;
	}

	public void CopyInto(T[] anArray)
	{
	}

	public T ElementAt(int index)
	{
		return default;
	}

	public void EnsureCapacity(int minCapacity)
	{
	}

	public T FirstElement()
	{
		return default;
	}

	public bool Contains(T elem)
	{
		return false;
	}

	public int IndexOf(T elem)
	{
		return 0;
	}

	public int IndexOf(T elem, int index)
	{
		return 0;
	}

	public bool ContainsFast(T elem)
	{
		return false;
	}

	public int IndexOfFast(T elem)
	{
		return 0;
	}

	public int IndexOfFast(T elem, int index)
	{
		return 0;
	}

	public int LastIndexOfFast(T elem)
	{
		return 0;
	}

	public int LastIndexOfFast(T elem, int index)
	{
		return 0;
	}

	public bool RemoveElementFast(T obj)
	{
		return false;
	}

	public void InsertElementAt(T obj, int index)
	{
	}

	public bool IsEmpty()
	{
		return false;
	}

	public T LastElement()
	{
		return default;
	}

	public int LastIndexOf(T elem)
	{
		return 0;
	}

	public int LastIndexOf(T elem, int index)
	{
		return 0;
	}

	public bool RemoveElement(T obj)
	{
		return false;
	}

	public bool Remove(T obj)
	{
		return false;
	}

	public void RemoveAllElements()
	{
	}

	public void RemoveAll()
	{
	}

	public void Clear()
	{
	}

	public void RemoveAllElementsKeep()
	{
	}

	public void RemoveElementAt(int index)
	{
	}

	public void Remove(int index)
	{
	}

	public void SetElementAt(T obj, int index)
	{
	}

	public void SetSize(int newSize)
	{
	}

	public int Size()
	{
		return 0;
	}

	public void TrimToSize()
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	[IteratorStateMachine(typeof(FastVector<>._003CGetEnumerator_003Ed__42))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
