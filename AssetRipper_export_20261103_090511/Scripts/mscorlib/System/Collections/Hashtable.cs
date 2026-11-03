using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;

namespace System.Collections;

[Serializable]
[DebuggerTypeProxy(typeof(HashtableDebugView))]
[DebuggerDisplay("Count = {Count}")]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable
{
	private struct bucket
	{
		public object key;

		public object val;

		public int hash_coll;
	}

	[Serializable]
	private class KeyCollection : ICollection, IEnumerable
	{
		private Hashtable _hashtable;

		public virtual object SyncRoot => null;

		public virtual int Count => 0;

		internal KeyCollection(Hashtable hashtable)
		{
		}

		public virtual void CopyTo(Array array, int arrayIndex)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Serializable]
	private class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
	{
		private Hashtable _hashtable;

		private int _bucket;

		private int _version;

		private bool _current;

		private int _getObjectRetType;

		private object _currentKey;

		private object _currentValue;

		public virtual object Key => null;

		public virtual DictionaryEntry Entry => default;

		public virtual object Current => null;

		public virtual object Value => null;

		internal HashtableEnumerator(Hashtable hashtable, int getObjRetType)
		{
		}

		public object Clone()
		{
			return null;
		}

		public virtual bool MoveNext()
		{
			return false;
		}

		public virtual void Reset()
		{
		}
	}

	internal class HashtableDebugView
	{
	}

	internal const int HashPrime = 101;

	private const int InitialSize = 3;

	private const string LoadFactorName = "LoadFactor";

	private const string VersionName = "Version";

	private const string ComparerName = "Comparer";

	private const string HashCodeProviderName = "HashCodeProvider";

	private const string HashSizeName = "HashSize";

	private const string KeysName = "Keys";

	private const string ValuesName = "Values";

	private const string KeyComparerName = "KeyComparer";

	private bucket[] _buckets;

	private int _count;

	private int _occupancy;

	private int _loadsize;

	private float _loadFactor;

	private int _version;

	private bool _isWriterInProgress;

	private ICollection _keys;

	private ICollection _values;

	private IEqualityComparer _keycomparer;

	private object _syncRoot;

	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable;

	private static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable => null;

	public virtual object this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual ICollection Keys => null;

	public virtual object SyncRoot => null;

	public virtual int Count => 0;

	public Hashtable()
	{
	}

	public Hashtable(int capacity)
	{
	}

	public Hashtable(int capacity, float loadFactor)
	{
	}

	public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer)
	{
	}

	public Hashtable(IEqualityComparer equalityComparer)
	{
	}

	public Hashtable(int capacity, IEqualityComparer equalityComparer)
	{
	}

	protected Hashtable(SerializationInfo info, StreamingContext context)
	{
	}

	private uint InitHash(object key, int hashsize, out uint seed, out uint incr)
	{
		seed = default;
		incr = default;
		return 0u;
	}

	public virtual void Add(object key, object value)
	{
	}

	public virtual object Clone()
	{
		return null;
	}

	public virtual bool Contains(object key)
	{
		return false;
	}

	public virtual bool ContainsKey(object key)
	{
		return false;
	}

	private void CopyKeys(Array array, int arrayIndex)
	{
	}

	private void CopyEntries(Array array, int arrayIndex)
	{
	}

	public virtual void CopyTo(Array array, int arrayIndex)
	{
	}

	private void CopyValues(Array array, int arrayIndex)
	{
	}

	private void expand()
	{
	}

	private void rehash()
	{
	}

	private void UpdateVersion()
	{
	}

	private void rehash(int newsize)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public virtual IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}

	protected virtual int GetHash(object key)
	{
		return 0;
	}

	protected virtual bool KeyEquals(object item, object key)
	{
		return false;
	}

	private void Insert(object key, object nvalue, bool add)
	{
	}

	private void putEntry(bucket[] newBuckets, object key, object nvalue, int hashcode)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public virtual void Remove(object key)
	{
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public virtual void OnDeserialization(object sender)
	{
	}
}
