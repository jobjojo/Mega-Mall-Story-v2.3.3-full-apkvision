using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

public static class Enumerable
{
	private abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int threadId;

		internal int state;

		internal TSource current;

		public TSource Current => default;

		object IEnumerator.Current => null;

		public Iterator()
		{
		}

		public abstract Iterator<TSource> Clone();

		public virtual void Dispose()
		{
		}

		public IEnumerator<TSource> GetEnumerator()
		{
			return null;
		}

		public abstract bool MoveNext();

		public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);

		public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void IEnumerator.Reset()
		{
		}
	}

	private class WhereEnumerableIterator<TSource> : Iterator<TSource>
	{
		private IEnumerable<TSource> source;

		private Func<TSource, bool> predicate;

		private IEnumerator<TSource> enumerator;

		public WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
		}

		public override Iterator<TSource> Clone()
		{
			return null;
		}

		public override void Dispose()
		{
		}

		public override bool MoveNext()
		{
			return false;
		}

		public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
		{
			return null;
		}

		public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
		{
			return null;
		}
	}

	private class WhereArrayIterator<TSource> : Iterator<TSource>
	{
		private TSource[] source;

		private Func<TSource, bool> predicate;

		private int index;

		public WhereArrayIterator(TSource[] source, Func<TSource, bool> predicate)
		{
		}

		public override Iterator<TSource> Clone()
		{
			return null;
		}

		public override bool MoveNext()
		{
			return false;
		}

		public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
		{
			return null;
		}

		public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
		{
			return null;
		}
	}

	private class WhereListIterator<TSource> : Iterator<TSource>
	{
		private List<TSource> source;

		private Func<TSource, bool> predicate;

		private List<TSource>.Enumerator enumerator;

		public WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
		{
		}

		public override Iterator<TSource> Clone()
		{
			return null;
		}

		public override bool MoveNext()
		{
			return false;
		}

		public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
		{
			return null;
		}

		public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
		{
			return null;
		}
	}

	private class WhereSelectEnumerableIterator<TSource, TResult> : Iterator<TResult>
	{
		private IEnumerable<TSource> source;

		private Func<TSource, bool> predicate;

		private Func<TSource, TResult> selector;

		private IEnumerator<TSource> enumerator;

		public WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
		{
		}

		public override Iterator<TResult> Clone()
		{
			return null;
		}

		public override void Dispose()
		{
		}

		public override bool MoveNext()
		{
			return false;
		}

		public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
		{
			return null;
		}

		public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
		{
			return null;
		}
	}

	private class WhereSelectArrayIterator<TSource, TResult> : Iterator<TResult>
	{
		private TSource[] source;

		private Func<TSource, bool> predicate;

		private Func<TSource, TResult> selector;

		private int index;

		public WhereSelectArrayIterator(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
		{
		}

		public override Iterator<TResult> Clone()
		{
			return null;
		}

		public override bool MoveNext()
		{
			return false;
		}

		public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
		{
			return null;
		}

		public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
		{
			return null;
		}
	}

	private class WhereSelectListIterator<TSource, TResult> : Iterator<TResult>
	{
		private List<TSource> source;

		private Func<TSource, bool> predicate;

		private Func<TSource, TResult> selector;

		private List<TSource>.Enumerator enumerator;

		public WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
		{
		}

		public override Iterator<TResult> Clone()
		{
			return null;
		}

		public override bool MoveNext()
		{
			return false;
		}

		public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
		{
			return null;
		}

		public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
		{
			return null;
		}
	}

	public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return null;
	}

	public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
	{
		return null;
	}

	private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
	{
		return null;
	}

	private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
	{
		return null;
	}

	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return null;
	}

	public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		return false;
	}

	public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		return false;
	}

	public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
	{
		return null;
	}

	public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
	{
		return null;
	}

	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
	{
		return null;
	}

	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
		return null;
	}

	public static TSource First<TSource>(this IEnumerable<TSource> source)
	{
		return default;
	}

	public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return default;
	}

	public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
	{
		return default;
	}

	public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return default;
	}

	public static TSource Last<TSource>(this IEnumerable<TSource> source)
	{
		return default;
	}

	public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return default;
	}

	public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
	{
		return default;
	}

	public static IEnumerable<TResult> Empty<TResult>()
	{
		return null;
	}

	public static bool Any<TSource>(this IEnumerable<TSource> source)
	{
		return false;
	}

	public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return false;
	}

	public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return false;
	}

	public static int Count<TSource>(this IEnumerable<TSource> source)
	{
		return 0;
	}

	public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
	{
		return false;
	}

	public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
	{
		return false;
	}
}
