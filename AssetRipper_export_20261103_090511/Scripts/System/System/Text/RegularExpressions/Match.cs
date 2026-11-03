namespace System.Text.RegularExpressions;

[Serializable]
public class Match : Group
{
	internal GroupCollection _groupcoll;

	internal Regex _regex;

	internal int _textbeg;

	internal int _textpos;

	internal int _textend;

	internal int _textstart;

	internal int[][] _matches;

	internal int[] _matchcount;

	internal bool _balancing;

	public static Match Empty { get; }

	public virtual GroupCollection Groups => null;

	internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos)
		: base(null, null, 0, null)
	{
	}

	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart)
	{
	}

	public Match NextMatch()
	{
		return null;
	}

	internal virtual ReadOnlySpan<char> GroupToStringImpl(int groupnum)
	{
		return default;
	}

	internal ReadOnlySpan<char> LastGroupToStringImpl()
	{
		return default;
	}

	internal virtual void AddMatch(int cap, int start, int len)
	{
	}

	internal virtual void BalanceMatch(int cap)
	{
	}

	internal virtual void RemoveMatch(int cap)
	{
	}

	internal virtual bool IsMatched(int cap)
	{
		return false;
	}

	internal virtual int MatchIndex(int cap)
	{
		return 0;
	}

	internal virtual int MatchLength(int cap)
	{
		return 0;
	}

	internal virtual void Tidy(int textpos)
	{
	}

	internal Match()
		: base(null, null, 0, null)
	{
	}
}
