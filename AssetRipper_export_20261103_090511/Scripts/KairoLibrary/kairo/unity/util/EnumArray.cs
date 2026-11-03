using System;
using System.Collections;

namespace kairo.unity.util;

public static class EnumArray
{
	public static int GetLength<T>() where T : struct
	{
		return 0;
	}

	public static int GetLength(Type type)
	{
		return 0;
	}
}
public class EnumArray<T, U> : ICloneable, ICollection, IEnumerable where T : struct, IComparable
{
	protected U[] ary_;

	public U this[int index]
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public U this[T index]
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public int Length => 0;

	public int Count => 0;

	public object SyncRoot => null;

	public bool IsSynchronized => false;

	public EnumArray()
	{
	}

	public EnumArray(params U[] values)
	{
	}

	public EnumArray(ref U[] values)
	{
	}

	public object Clone()
	{
		return null;
	}

	public void CopyTo(Array array, int index)
	{
	}

	public void Clear()
	{
	}

	public void Init(U value)
	{
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	private int GetIndex(T key)
	{
		return 0;
	}
}
