using System.Collections.Generic;
using UnityEngine;
using java.io;

namespace kairo.unity.io;

public class AssetReader
{
	protected static string country_;

	protected static string language_;

	protected static int dpi_;

	private static long[] crcTable_;

	private static bool encrypt_;

	protected static readonly string[] DPI_FOLDERS;

	protected const int DPI_LDPI = 0;

	protected const int DPI_MDPI = 1;

	protected const int DPI_HDPI = 2;

	protected const int DPI_XHDPI = 3;

	internal static Dictionary<string, bool> filelist_;

	private AssetReader()
	{
	}

	private static void _init()
	{
	}

	public static InputStream GetInputStream(string file)
	{
		return null;
	}

	private static InputStream _getInputStream(string file)
	{
		return null;
	}

	public static string[] GetAccessFilesList(string file)
	{
		return null;
	}

	private static InputStream _open(string file)
	{
		return null;
	}

	private static byte[] _getData(string file)
	{
		return null;
	}

	private static TextAsset _getTextAsset(string file)
	{
		return null;
	}

	public static byte[] GetData(string file)
	{
		return null;
	}

	public static byte[] GetCustomResource(string customFolder, string file)
	{
		return null;
	}

	public static bool Exist(string file)
	{
		return false;
	}

	private static bool exist(string file)
	{
		return false;
	}

	public static void SetSecurity(long[] crcTable, bool encrypt)
	{
	}
}
