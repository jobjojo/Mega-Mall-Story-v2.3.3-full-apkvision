using UnityEngine;
using kairo.unity.ui;

namespace kairo.unity.native;

public class AdMobPlugin
{
	private static IApplication app_;

	private static AndroidJavaClass AdMobView;

	private static AndroidJavaClass Interstitial;

	internal static int AdSize;

	internal static bool weakOmit_;

	public static void SetWeakOmit(bool flag)
	{
	}

	public static void Init()
	{
	}

	public static void ResetAdMobView()
	{
	}

	public static AndroidJavaObject CreateAdMobView(int adSize, string adUnitId, int location = 1)
	{
		return null;
	}

	public static void RemoveAdMobView(AndroidJavaObject obj)
	{
	}

	public static void Start(AndroidJavaObject obj)
	{
	}

	public static bool IsStart(AndroidJavaObject obj)
	{
		return false;
	}

	private static bool _isStart(AndroidJavaObject obj)
	{
		return false;
	}

	public static bool IsLoad(AndroidJavaObject obj)
	{
		return false;
	}

	private static bool _isLoad(AndroidJavaObject obj)
	{
		return false;
	}

	internal static AndroidJavaObject LoadInterstitialAd(string adUnitId)
	{
		return null;
	}

	internal static int GetInterstitialAdState(AndroidJavaObject obj)
	{
		return 0;
	}

	internal static void ShowInterstitialAd(AndroidJavaObject obj)
	{
	}
}
