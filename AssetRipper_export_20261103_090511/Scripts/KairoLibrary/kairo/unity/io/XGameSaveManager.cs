using System;

namespace kairo.unity.io;

internal class XGameSaveManager
{
	private const string DEFAULT_BLOB_NAME = "data";

	private static ulong userId_;

	private static string[] files_;

	private static bool asyncWait_;

	private static Exception asyncError_;

	internal static int initializeResult_;

	public static void Initialize()
	{
	}

	private static void CheckUpdateProviderHandle()
	{
	}

	public static void Write(string containerName, byte[] data)
	{
	}

	public static void Write(string containerName, string name, byte[] data)
	{
	}

	public static byte[] Read(string containerName)
	{
		return null;
	}

	public static byte[] Read(string containerName, string name)
	{
		return null;
	}

	public static bool Exists(string containerName)
	{
		return false;
	}

	public static bool Exists(string containerName, string name)
	{
		return false;
	}

	public static int GetSize(string containerName)
	{
		return 0;
	}

	public static int GetSize(string containerName, string name)
	{
		return 0;
	}

	public static void Delete(string containerName)
	{
	}

	public static void Delete(string containerName, string name)
	{
	}

	public static string[] GetFiles()
	{
		return null;
	}

	private static void CloseGameSaveHandles()
	{
	}

	internal static void OnSuspend()
	{
	}

	internal static void OnResume()
	{
	}
}
