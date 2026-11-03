using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public class StringInfo
{
	[OptionalField(VersionAdded = 2)]
	private string m_str;

	[NonSerialized]
	private int[] m_indexes;

	private int[] Indexes => null;

	public string String
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int LengthInTextElements => 0;

	public StringInfo()
	{
	}

	public StringInfo(string value)
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

	[ComVisible(false)]
	public override bool Equals(object value)
	{
		return false;
	}

	[ComVisible(false)]
	public override int GetHashCode()
	{
		return 0;
	}

	public string SubstringByTextElements(int startingTextElement)
	{
		return null;
	}

	public string SubstringByTextElements(int startingTextElement, int lengthInTextElements)
	{
		return null;
	}

	public static string GetNextTextElement(string str)
	{
		return null;
	}

	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount)
	{
		return 0;
	}

	public static string GetNextTextElement(string str, int index)
	{
		return null;
	}

	public static TextElementEnumerator GetTextElementEnumerator(string str)
	{
		return null;
	}

	public static TextElementEnumerator GetTextElementEnumerator(string str, int index)
	{
		return null;
	}

	public static int[] ParseCombiningCharacters(string str)
	{
		return null;
	}
}
