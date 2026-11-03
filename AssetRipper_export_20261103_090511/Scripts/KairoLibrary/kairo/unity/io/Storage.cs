using java.util;

namespace kairo.unity.io;

public class Storage
{
	private const int FILENAME_MAX = 8;

	private const int FILEEXT_MAX = 3;

	public const int MEDIA_MEMORY = 0;

	public const int MEDIA_DATAFOLDER = 1;

	public const int MEDIA_HEAP = 2;

	public const int MEDIA_RESOURCE = 3;

	protected const int MEDIA_RECORDSTORE = 4;

	public const int ACCESS_PLATFORM = 2;

	public const int ACCESS_SERIES = 4;

	public const int ACCESS_UIM = 1;

	public const int SHARE_APPLICATION = 8;

	public const int SHARE_CONTENTS_PROVIDER = 16;

	protected static int access_;

	protected static int share_;

	private static string root_;

	private string folder_;

	private int media_;

	private bool security_;

	private static Vector heapName_;

	private static Vector heapData_;

	public static void Setup(int access, int share, string root)
	{
	}

	protected Storage(string folder, int media, bool security)
	{
	}

	protected Storage(string folder, int media, bool security, string assemblyName)
	{
	}

	protected Storage(object Null, int media, bool security)
	{
	}

	public static Storage Open(int media, bool security, string assemblyName = null)
	{
		return null;
	}

	public static string GetFolder(int media)
	{
		return null;
	}

	public void Close()
	{
	}

	private static bool _filenameCheck(string filename)
	{
		return false;
	}

	public byte[] Read(string filename)
	{
		return null;
	}

	public void Write(string filename, byte[] data)
	{
	}

	public void Delete(string filename)
	{
	}

	public bool Exists(string filename)
	{
		return false;
	}

	public int GetSize(string filename)
	{
		return 0;
	}

	public string[] GetFiles()
	{
		return null;
	}

	private int _SearchHeapFile(string filename)
	{
		return 0;
	}

	public static byte[] Read(int media, bool security, string filename)
	{
		return null;
	}

	public static void Write(int media, bool security, string filename, byte[] data)
	{
	}

	public static bool Exists(int media, string filename)
	{
		return false;
	}

	public static void Delete(int media, string filename)
	{
	}
}
