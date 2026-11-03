namespace analytics;

public class AnalyticsTracker
{
	private const string PROPERTY_ID = "UA-35228877-2";

	public static void TrackPageView(bool packageName, params string[] p)
	{
	}

	public static void TrackPageViewId(bool packageName, string id, params string[] p)
	{
	}

	public static void DispatchPageView()
	{
	}
}
