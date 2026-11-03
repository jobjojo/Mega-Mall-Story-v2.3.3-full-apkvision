using System;
using UnityEngine;
using kairo.unity.ui;

namespace kairo.unity.ad;

public class InterstitialAd : IDisposable
{
	public enum State
	{
		None = -1,
		Load = 0,
		Loaded = 1,
		Show = 2,
		Close = 3,
		Error = 10
	}

	private string adUnitId_;

	private static bool showLoading_;

	private AndroidJavaObject object_;

	private static bool showCountDown_;

	private static long showCountBegin_;

	private static bool isEnabledCountDown_;

	private const int COUNTDOWN_MILISECOND = 3000;

	public void SetAdUnitId(string adUnitId)
	{
	}

	public bool Load()
	{
		return false;
	}

	public void Show()
	{
	}

	public State GetState()
	{
		return State.Load;
	}

	public void Dispose()
	{
	}

	public bool IsLoaded()
	{
		return false;
	}

	public static void DisableShowLoading()
	{
	}

	public void SetEnabledCountDown(bool enabled)
	{
	}

	public static void DrawLoading(kairo.unity.ui.Graphics g)
	{
	}
}
