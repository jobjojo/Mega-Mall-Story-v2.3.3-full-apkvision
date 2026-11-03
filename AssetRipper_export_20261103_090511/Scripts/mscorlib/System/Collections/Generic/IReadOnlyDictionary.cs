using System.Reflection;

namespace System.Collections.Generic;

[DefaultMember("Item")]
public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	bool TryGetValue(TKey key, out TValue value);
}
