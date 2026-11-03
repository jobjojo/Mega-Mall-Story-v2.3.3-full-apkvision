using System;
using UnityEngine;

namespace kairo.unity.ad;

public class AdMobView : IDisposable
{
	private static AndroidJavaObject admob_;

	private static int adHeight_;

	public AdMobView(AndroidJavaObject admob)
	{
	}

	public void Start()
	{
	}

	public bool IsStart()
	{
		return false;
	}

	public bool IsLoad()
	{
		return false;
	}

	public void Dispose()
	{
	}

	public static int GetAdHeight()
	{
		return 0;
	}

	public static void SetAdmobPosition(int pos)
	{
	}
}
