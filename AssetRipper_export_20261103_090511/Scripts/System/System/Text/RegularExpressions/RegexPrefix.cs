namespace System.Text.RegularExpressions;

internal readonly struct RegexPrefix
{
	internal bool CaseInsensitive { get; } = false;

	internal static RegexPrefix Empty { get; }

	internal string Prefix { get; } = null;

	internal RegexPrefix(string prefix, bool ci)
	{
	}
}
