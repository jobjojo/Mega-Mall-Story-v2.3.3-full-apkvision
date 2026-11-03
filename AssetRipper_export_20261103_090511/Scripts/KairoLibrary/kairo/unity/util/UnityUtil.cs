using System.Collections.Generic;
using UnityEngine;

namespace kairo.unity.util;

public static class UnityUtil
{
	private static Dictionary<string, bool> checkUnityVersionCache_;

	public static string bundleIdentifier
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool showUnitySplashScreen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string iPhoneBundleIdentifier
	{
		set
		{
		}
	}

	public static string AndroidBundleIdentifier => null;

	public static long GetMonoHeapSize()
	{
		return 0L;
	}

	public static long GetMonoUsedSize()
	{
		return 0L;
	}

	public static void SetScriptingBackend(int targetGroup, int scriptingImplementation)
	{
	}

	public static void SetAndroidArchitecture(int architecture)
	{
	}

	public static void SwitchActiveBuildTarget(int buildTarget)
	{
	}

	public static void SetiPhoneTargetOSVersion(int targetGroup, int osVersion)
	{
	}

	public static bool SetArchitecture(int targetGroup, int architecture)
	{
		return false;
	}

	public static void CaptureScreenshot(string path)
	{
	}

	public static byte[] EncodeToPNG(Texture2D tex)
	{
		return null;
	}

	public static bool LoadImage(Texture2D tex, byte[] data)
	{
		return false;
	}

	public static bool Resize(Texture2D tex, int width, int height)
	{
		return false;
	}

	public static bool CheckUnityVersion(string version)
	{
		return false;
	}
}
