using System.Collections.Generic;

namespace Unity.Properties;

public class DictionaryPropertyBag<TKey, TValue> : KeyValueCollectionPropertyBag<Dictionary<TKey, TValue>, TKey, TValue>
{
	protected override InstantiationKind InstantiationKind => InstantiationKind.Activator;

	protected override Dictionary<TKey, TValue> Instantiate()
	{
		return null;
	}
}
