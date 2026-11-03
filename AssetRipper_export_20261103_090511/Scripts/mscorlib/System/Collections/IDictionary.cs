namespace System.Collections;

public interface IDictionary : ICollection, IEnumerable
{
	object this[object key] { get; set; }

	bool Contains(object key);

	new IDictionaryEnumerator GetEnumerator();
}
