using System.Collections.Generic;

namespace UnityEngine.Pool;

public class CollectionPool<TCollection, TItem> where TCollection : class, ICollection<TItem>, new()
{
	internal static readonly ObjectPool<TCollection> s_Pool;

	public static PooledObject<TCollection> Get(out TCollection value)
	{
		value = null;
		return default;
	}
}
