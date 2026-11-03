using System.Collections;

namespace System.Runtime.Serialization;

public sealed class SerializationInfoEnumerator : IEnumerator
{
	private readonly string[] _members;

	private readonly object[] _data;

	private readonly Type[] _types;

	private readonly int _numItems;

	private int _currItem;

	private bool _current;

	object IEnumerator.Current => null;

	public SerializationEntry Current => default;

	public string Name => null;

	public object Value => null;

	public Type ObjectType => null;

	internal SerializationInfoEnumerator(string[] members, object[] info, Type[] types, int numItems)
	{
	}

	public bool MoveNext()
	{
		return false;
	}

	public void Reset()
	{
	}
}
