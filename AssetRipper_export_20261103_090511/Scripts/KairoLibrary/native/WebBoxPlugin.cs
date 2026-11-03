using UnityEngine;

namespace native;

public static class WebBoxPlugin
{
	private static AndroidJavaObject activity_;

	private static AndroidJavaObject customTabsIntent_;

	public static bool Create()
	{
		return false;
	}

	public static void SetViewRect(int x, int y, int width, int height)
	{
	}

	public static void LoadUrl(string url)
	{
	}

	public static void Dispose()
	{
	}

	public static bool Visible()
	{
		return false;
	}

	public static void SetVisible(bool visible)
	{
	}

	public static void SetJavaScriptEnabled(bool enabled)
	{
	}

	public static void OpenAuthWebView(string url)
	{
	}
}
