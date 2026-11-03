using System.Runtime.InteropServices;

namespace System.IO;

[ComVisible(true)]
public static class Path
{
	[Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
	public static readonly char[] InvalidPathChars;

	public static readonly char AltDirectorySeparatorChar;

	public static readonly char DirectorySeparatorChar;

	public static readonly char PathSeparator;

	internal static readonly string DirectorySeparatorStr;

	public static readonly char VolumeSeparatorChar;

	internal static readonly char[] PathSeparatorChars;

	private static readonly bool dirEqualsVolume;

	internal static readonly char[] trimEndCharsWindows;

	internal static readonly char[] trimEndCharsUnix;

	public static string ChangeExtension(string path, string extension)
	{
		return null;
	}

	public static string Combine(string path1, string path2)
	{
		return null;
	}

	internal static string CleanPath(string s)
	{
		return null;
	}

	public static string GetDirectoryName(string path)
	{
		return null;
	}

	public static ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path)
	{
		return default;
	}

	public static string GetExtension(string path)
	{
		return null;
	}

	public static string GetFileName(string path)
	{
		return null;
	}

	public static string GetFileNameWithoutExtension(string path)
	{
		return null;
	}

	public static string GetFullPath(string path)
	{
		return null;
	}

	internal static string GetFullPathInternal(string path)
	{
		return null;
	}

	internal static string InsecureGetFullPath(string path)
	{
		return null;
	}

	internal static bool IsDirectorySeparator(char c)
	{
		return false;
	}

	public static string GetPathRoot(string path)
	{
		return null;
	}

	public static string GetTempPath()
	{
		return null;
	}

	private static string get_temp_path()
	{
		return null;
	}

	public static bool IsPathRooted(ReadOnlySpan<char> path)
	{
		return false;
	}

	public static bool IsPathRooted(string path)
	{
		return false;
	}

	public static char[] GetInvalidPathChars()
	{
		return null;
	}

	private static int findExtension(string path)
	{
		return 0;
	}

	static Path()
	{
	}

	private static string CanonicalizePath(string path)
	{
		return null;
	}

	public static string Combine(params string[] paths)
	{
		return null;
	}

	public static string Combine(string path1, string path2, string path3)
	{
		return null;
	}

	public static ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path)
	{
		return default;
	}

	public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2)
	{
		return null;
	}

	public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3)
	{
		return null;
	}

	public static bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten)
	{
		charsWritten = default;
		return false;
	}

	private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second)
	{
		return null;
	}

	private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third)
	{
		return null;
	}
}
