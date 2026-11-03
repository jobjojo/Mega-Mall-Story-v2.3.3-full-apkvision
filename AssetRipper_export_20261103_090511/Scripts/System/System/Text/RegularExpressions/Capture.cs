namespace System.Text.RegularExpressions;

public class Capture
{
	public int Index { get; private protected set; }

	public int Length { get; private protected set; }

	internal string Text { get; private protected set; }

	public string Value => null;

	internal Capture(string text, int index, int length)
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal ReadOnlySpan<char> GetLeftSubstring()
	{
		return default;
	}

	internal ReadOnlySpan<char> GetRightSubstring()
	{
		return default;
	}
}
