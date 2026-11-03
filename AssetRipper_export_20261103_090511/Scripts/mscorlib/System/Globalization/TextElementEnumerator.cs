using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public class TextElementEnumerator : IEnumerator
{
	private string str;

	private int index;

	private int startIndex;

	[NonSerialized]
	private int strLen;

	[NonSerialized]
	private int currTextElementLen;

	[OptionalField(VersionAdded = 2)]
	private UnicodeCategory uc;

	[OptionalField(VersionAdded = 2)]
	private int charLen;

	private int endIndex;

	private int nextTextElementLen;

	public object Current => null;

	public int ElementIndex => 0;

	internal TextElementEnumerator(string str, int startIndex, int strLen)
	{
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	public bool MoveNext()
	{
		return false;
	}

	public string GetTextElement()
	{
		return null;
	}

	public void Reset()
	{
	}

	internal TextElementEnumerator()
	{
	}
}
