using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace java.util;

public class Vector : Vector<object>
{
	public Vector()
	{
	}

	public Vector(int initialCapacity)
	{
	}

	public Vector(int initialCapacity, int capacityIncrement)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}
}
public class Vector<T> : IEnumerable, IVector
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__40 : IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Vector<T> _003C_003E4__this;

		private List<object>.Enumerator _003C_003E7__wrap1;

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
		public _003CGetEnumerator_003Ed__40(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	protected List<object> list_;

	public List<object> List => null;

	public static implicit operator Vector(Vector<T> list)
	{
		return null;
	}

	public static bool operator !=(Vector<T> a, Vector b)
	{
		return false;
	}

	public static bool operator ==(Vector<T> a, Vector b)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public Vector()
	{
	}

	public Vector(int initialCapacity)
	{
	}

	public Vector(int initialCapacity, int capacityIncrement)
	{
	}

	public void AddElement(T obj)
	{
	}

	public void Add(T obj)
	{
	}

	public void Add(int index, T obj)
	{
	}

	public int Capacity()
	{
		return 0;
	}

	public bool Contains(T elem)
	{
		return false;
	}

	public void CopyInto(T[] anArray)
	{
	}

	public T Get(int index)
	{
		return default;
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

	public int IndexOf(T elem)
	{
		return 0;
	}

	public int IndexOf(T elem, int index)
	{
		return 0;
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

	public void RemoveAllElements()
	{
	}

	public void Clear()
	{
	}

	public bool Remove(T obj)
	{
		return false;
	}

	public bool RemoveElement(T obj)
	{
		return false;
	}

	public void Remove(int index)
	{
	}

	public void RemoveElementAt(int index)
	{
	}

	public void Set(T obj, int index)
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

	public override string ToString()
	{
		return null;
	}

	public void TrimToSize()
	{
	}

	public T[] ToArray()
	{
		return null;
	}

	[IteratorStateMachine(typeof(Vector<>._003CGetEnumerator_003Ed__40))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
