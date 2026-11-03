using System.Collections.Generic;
using UnityEngine;

namespace java.native;

public static class JavaPlugin
{
	private static AndroidJavaClass Locale;

	private static AndroidJavaClass TimeZone;

	private static AndroidJavaClass Runtime;

	private static bool init_;

	private static Dictionary<string, int> utcOffsetTable_;

	public static void Init()
	{
	}

	public static string[] GetDefaultLocale()
	{
		return null;
	}

	public static string GetDefaultTimeZone()
	{
		return null;
	}

	public static int GetUtcOffset(string timezone)
	{
		return 0;
	}

	public static long FreeMemory()
	{
		return 0L;
	}

	public static long TotalMemory()
	{
		return 0L;
	}

	private static void CreateUtcOffsetTable()
	{
	}
}
