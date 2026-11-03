using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.InputSystem.Utilities;

public struct ReadOnlyArray<TValue> : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue>
{
	public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		private readonly TValue[] m_Array = null;

		private readonly int m_IndexStart = 0;

		private readonly int m_IndexEnd = 0;

		private int m_Index = 0;

		public TValue Current => default;

		object IEnumerator.Current => null;

		internal Enumerator(TValue[] array, int index, int length)
		{
		}

		public void Dispose()
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

	internal TValue[] m_Array = null;

	internal int m_StartIndex = 0;

	internal int m_Length = 0;

	public int Count => 0;

	public TValue this[int index] => default;

	public ReadOnlyArray(TValue[] array)
	{
	}

	public ReadOnlyArray(TValue[] array, int index, int length)
	{
	}

	public TValue[] ToArray()
	{
		return null;
	}

	public int IndexOf(Predicate<TValue> predicate)
	{
		return 0;
	}

	public Enumerator GetEnumerator()
	{
		return default;
	}

	IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public static implicit operator ReadOnlyArray<TValue>(TValue[] array)
	{
		return default;
	}
}
