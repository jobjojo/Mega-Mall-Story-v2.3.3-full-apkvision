namespace System.Text.RegularExpressions;

[Serializable]
public class Group : Capture
{
	internal static readonly Group s_emptyGroup;

	internal readonly int[] _caps;

	internal int _capcount;

	private readonly string Name;

	public bool Success => false;

	internal Group(string text, int[] caps, int capcount, string name)
		: base(null, 0, 0)
	{
	}

	internal Group()
		: base(null, 0, 0)
	{
	}
}
