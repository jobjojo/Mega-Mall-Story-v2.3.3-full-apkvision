using System.Collections.Generic;

namespace System.IO;

public static class Directory
{
	public static DirectoryInfo CreateDirectory(string path)
	{
		return null;
	}

	public static bool Exists(string path)
	{
		return false;
	}

	public static string[] GetFiles(string path)
	{
		return null;
	}

	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return null;
	}

	public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
	{
		return null;
	}

	public static string[] GetDirectories(string path)
	{
		return null;
	}

	public static string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
	{
		return null;
	}

	internal static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
	{
		return null;
	}

	public static IEnumerable<string> EnumerateFileSystemEntries(string path)
	{
		return null;
	}

	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
	{
		return null;
	}

	internal static string InternalGetDirectoryRoot(string path)
	{
		return null;
	}

	public static string GetCurrentDirectory()
	{
		return null;
	}

	public static void Delete(string path, bool recursive)
	{
	}

	internal static string InsecureGetCurrentDirectory()
	{
		return null;
	}
}
