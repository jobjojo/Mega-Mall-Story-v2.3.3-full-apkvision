using System.Reflection;

namespace System.Collections.Specialized;

[Serializable]
[DefaultMember("Item")]
public class StringDictionary : IEnumerable
{
	internal Hashtable contents;

	public virtual void Add(string key, string value)
	{
	}

	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}
}
