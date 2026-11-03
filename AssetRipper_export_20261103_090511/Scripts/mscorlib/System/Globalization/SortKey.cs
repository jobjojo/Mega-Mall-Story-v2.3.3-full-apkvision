using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class SortKey
{
	private readonly string source;

	private readonly byte[] key;

	private readonly CompareOptions options;

	private readonly int lcid;

	public virtual string OriginalString => null;

	public virtual byte[] KeyData => null;

	public static int Compare(SortKey sortkey1, SortKey sortkey2)
	{
		return 0;
	}

	internal SortKey(int lcid, string source, CompareOptions opt)
	{
	}

	internal SortKey(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength)
	{
	}

	internal SortKey(string localeName, string str, CompareOptions options, byte[] keyData)
	{
	}

	public override bool Equals(object value)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	internal SortKey()
	{
	}
}
