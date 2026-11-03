using System.Text;

namespace System.IO;

public static class File
{
	public static void Copy(string sourceFileName, string destFileName)
	{
	}

	public static void Copy(string sourceFileName, string destFileName, bool overwrite)
	{
	}

	public static void Delete(string path)
	{
	}

	public static bool Exists(string path)
	{
		return false;
	}

	public static FileStream OpenRead(string path)
	{
		return null;
	}

	public static FileStream OpenWrite(string path)
	{
		return null;
	}

	public static string ReadAllText(string path)
	{
		return null;
	}

	private static string InternalReadAllText(string path, Encoding encoding)
	{
		return null;
	}

	public static void WriteAllText(string path, string contents, Encoding encoding)
	{
	}

	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	private static byte[] ReadAllBytesUnknownLength(FileStream fs)
	{
		return null;
	}

	public static void WriteAllBytes(string path, byte[] bytes)
	{
	}

	private static void InternalWriteAllBytes(string path, byte[] bytes)
	{
	}

	public static string[] ReadAllLines(string path)
	{
		return null;
	}

	private static string[] InternalReadAllLines(string path, Encoding encoding)
	{
		return null;
	}
}
