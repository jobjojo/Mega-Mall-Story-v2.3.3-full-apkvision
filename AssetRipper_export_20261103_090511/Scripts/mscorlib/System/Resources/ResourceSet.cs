using System.Collections;
using System.Runtime.InteropServices;

namespace System.Resources;

[Serializable]
[ComVisible(true)]
public class ResourceSet : IDisposable, IEnumerable
{
	[NonSerialized]
	protected IResourceReader Reader;

	protected Hashtable Table;

	private Hashtable _caseInsensitiveTable;

	protected ResourceSet()
	{
	}

	internal ResourceSet(bool junk)
	{
	}

	private void CommonInit()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public void Dispose()
	{
	}

	[ComVisible(false)]
	public virtual IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	private IDictionaryEnumerator GetEnumeratorHelper()
	{
		return null;
	}

	public virtual string GetString(string name)
	{
		return null;
	}

	public virtual string GetString(string name, bool ignoreCase)
	{
		return null;
	}

	public virtual object GetObject(string name)
	{
		return null;
	}

	public virtual object GetObject(string name, bool ignoreCase)
	{
		return null;
	}

	private object GetObjectInternal(string name)
	{
		return null;
	}

	private object GetCaseInsensitiveObjectInternal(string name)
	{
		return null;
	}
}
