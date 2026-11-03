using System.Collections.Generic;
using java.lang;

namespace kairo.unity.analytics;

public class AnalyticsTracker
{
	private enum HitType
	{
		PageView = 0,
		ScreenView = 1,
		Event = 2,
		Transaction = 3,
		Item = 4,
		Social = 5,
		Exception = 6,
		Timing = 7
	}

	private class AnalyticsData
	{
		public string Url;

		public int Retry;

		public long Date;

		public AnalyticsData()
		{
		}

		public AnalyticsData(string url)
		{
		}
	}

	private static readonly string[] HIT_TYPES;

	private const string ANALYTICS_KEY = "_AnalyticsTracker";

	private static List<AnalyticsData> analyticsBuffer_;

	private static object lock_;

	private static JThread thread_;

	private static bool isSetup_;

	public static void TrackPageView(bool packageName, string id, params string[] p)
	{
	}

	public static void DispatchPageView()
	{
	}

	protected static void Run()
	{
	}

	private static string Encode(string url)
	{
		return null;
	}

	private static string MakeClientId()
	{
		return null;
	}

	private static string GetApplicationName()
	{
		return null;
	}

	internal static void Save()
	{
	}

	internal static void Setup()
	{
	}
}
