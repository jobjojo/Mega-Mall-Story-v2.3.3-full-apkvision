using UnityEngine;

namespace native;

public static class AppPlugin
{
	private static AndroidJavaClass Config;

	private static AndroidJavaClass Utility;

	static AppPlugin()
	{
	}

	public static void Init(int language, bool log, string licenseKey)
	{
	}

	public static void Finish()
	{
	}

	public static int ShowPurchaseLog(string title, int num, string text, bool log)
	{
		return 0;
	}

	public static void LaunchMailer(string subject, string text)
	{
	}
}
