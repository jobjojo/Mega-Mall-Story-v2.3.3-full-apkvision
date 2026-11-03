using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

[Serializable]
[TypeDependency("System.Collections.Generic.ObjectComparer`1")]
public abstract class Comparer<T> : IComparer, IComparer<T>
{
	private static Comparer<T> defaultComparer;

	public static Comparer<T> Default => null;

	private static Comparer<T> CreateComparer()
	{
		return null;
	}

	public abstract int Compare(T x, T y);

	int IComparer.Compare(object x, object y)
	{
		return 0;
	}
}
