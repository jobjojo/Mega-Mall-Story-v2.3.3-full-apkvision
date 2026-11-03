using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

[Serializable]
[TypeDependency("System.Collections.Generic.ObjectEqualityComparer`1")]
public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
{
	private static EqualityComparer<T> defaultComparer;

	public static EqualityComparer<T> Default
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return null;
		}
	}

	private static EqualityComparer<T> CreateComparer()
	{
		return null;
	}

	public abstract bool Equals(T x, T y);

	public abstract int GetHashCode(T obj);

	internal virtual int IndexOf(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	int IEqualityComparer.GetHashCode(object obj)
	{
		return 0;
	}

	bool IEqualityComparer.Equals(object x, object y)
	{
		return false;
	}
}
