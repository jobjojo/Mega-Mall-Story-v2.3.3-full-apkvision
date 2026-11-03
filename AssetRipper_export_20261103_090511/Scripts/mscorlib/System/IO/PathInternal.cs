namespace System.IO;

internal static class PathInternal
{
	private static readonly bool s_isCaseSensitive;

	internal static bool IsCaseSensitive => false;

	internal static int GetRootLength(ReadOnlySpan<char> path)
	{
		return 0;
	}

	internal static bool IsDirectorySeparator(char c)
	{
		return false;
	}

	internal static bool EndsInDirectorySeparator(ReadOnlySpan<char> path)
	{
		return false;
	}

	internal static bool StartsWithDirectorySeparator(ReadOnlySpan<char> path)
	{
		return false;
	}

	internal static string TrimEndingDirectorySeparator(string path)
	{
		return null;
	}

	internal static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path)
	{
		return default;
	}

	internal static bool IsRoot(ReadOnlySpan<char> path)
	{
		return false;
	}

	private static bool GetIsCaseSensitive()
	{
		return false;
	}

	public static bool IsPartiallyQualified(string path)
	{
		return false;
	}
}
