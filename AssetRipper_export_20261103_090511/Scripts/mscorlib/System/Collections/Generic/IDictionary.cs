using System.Reflection;

namespace System.Collections.Generic;

[DefaultMember("Item")]
public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	void Add(TKey key, TValue value);
}
