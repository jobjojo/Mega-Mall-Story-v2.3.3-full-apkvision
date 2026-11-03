using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace System;

public static class Tuple
{
	internal static int CombineHashCodes(int h1, int h2)
	{
		return 0;
	}

	internal static int CombineHashCodes(int h1, int h2, int h3)
	{
		return 0;
	}
}
[Serializable]
public class Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
{
	private readonly T1 m_Item1;

	private readonly T2 m_Item2;

	private readonly T3 m_Item3;

	public T1 Item1 => default;

	public T2 Item2 => default;

	public T3 Item3 => default;

	int ITuple.Length => 0;

	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		return false;
	}

	int IComparable.CompareTo(object obj)
	{
		return 0;
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		return 0;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	string ITupleInternal.ToString(StringBuilder sb)
	{
		return null;
	}
}
