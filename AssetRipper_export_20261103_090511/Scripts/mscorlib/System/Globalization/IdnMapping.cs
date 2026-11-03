namespace System.Globalization;

public sealed class IdnMapping
{
	private bool allow_unassigned;

	private bool use_std3;

	private Punycode puny;

	public bool AllowUnassigned
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool UseStd3AsciiRules
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public string GetAscii(string unicode)
	{
		return null;
	}

	public string GetAscii(string unicode, int index)
	{
		return null;
	}

	public string GetAscii(string unicode, int index, int count)
	{
		return null;
	}

	private string Convert(string input, int index, int count, bool toAscii)
	{
		return null;
	}

	private string ToAscii(string s, int offset)
	{
		return null;
	}

	private void VerifyLength(string s, int offset)
	{
	}

	private string NamePrep(string s, int offset)
	{
		return null;
	}

	private void VerifyProhibitedCharacters(string s, int offset)
	{
	}

	private void VerifyStd3AsciiRules(string s, int offset)
	{
	}

	public string GetUnicode(string ascii)
	{
		return null;
	}

	public string GetUnicode(string ascii, int index)
	{
		return null;
	}

	public string GetUnicode(string ascii, int index, int count)
	{
		return null;
	}

	private string ToUnicode(string s, int offset)
	{
		return null;
	}
}
