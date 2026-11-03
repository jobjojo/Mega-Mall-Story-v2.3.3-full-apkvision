using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using java.lang;
using kairo.unity.surface;
using kairo.unity.type;

namespace kairo.unity.ui;

public class WebBox : IDisposable
{
	public delegate void OnWebViewClosed();

	private class WebBoxBehaviour : MonoBehaviour
	{
		public OnWebViewClosed Callback;

		public WebBox WebBox;

		private void OnWebViewClose(string message)
		{
		}
	}

	public enum LoadingStates
	{
		None = 0,
		Loading = 1,
		Success = 2,
		Failure = 3
	}

	public delegate void OnLoadSuccessDelegate(string url);

	public delegate void OnLoadFailureDelegate(string url);

	public delegate void OnMessageDelegate(string msg);

	private WebBoxBehaviour behaviour_;

	private WebBoxFlags flag_;

	private const string GREE_NAME = "WebViewObject";

	private GameObject greeGameObject_;

	private Component greeWebViewObject_;

	private JThread th_;

	private bool disposed_;

	internal kairo.unity.type.Rect DisplayRect { get; private set; }

	internal SurfaceBase DisplaySurface { get; private set; }

	internal string Url { get; private set; }

	private bool Visibility { get; set; }

	internal bool Fullscreen { get; set; }

	internal Process Process { get; private set; }

	internal static List<KeyValuePair<int, WebBox>> WebList { get; private set; }

	public bool InvisibleLoading { get; set; }

	public bool ShowProgress { get; set; }

	public LoadingStates LoadingState { get; private set; }

	public OnLoadSuccessDelegate OnLoadSuccess { get; set; }

	public OnLoadFailureDelegate OnLoadFailure { get; set; }

	public OnMessageDelegate OnMessage { get; set; }

	private static bool IsOld(WebBoxFlags flag)
	{
		return false;
	}

	private static bool IsGree(WebBoxFlags flag)
	{
		return false;
	}

	public bool IsGree()
	{
		return false;
	}

	public static WebBox Create(OnWebViewClosed callback = null, WebBoxFlags flag = (WebBoxFlags)0)
	{
		return null;
	}

	public WebBox(OnWebViewClosed callback = null, WebBoxFlags flag = (WebBoxFlags)0)
	{
	}

	public void SetViewRect(SurfaceBase surface, int x, int y, int width, int height)
	{
	}

	public void SetViewRect(Graphics g, SurfaceBase surface, int x, int y, int width, int height)
	{
	}

	private void UpdateGreeMargin()
	{
	}

	public void LoadUrl(string url)
	{
	}

	private void WebEventHandler()
	{
	}

	private void OnLoaded(string s)
	{
	}

	private void OnError(string s)
	{
	}

	private void OnJS(string s)
	{
	}

	public void Dispose()
	{
	}

	public bool IsDispose()
	{
		return false;
	}

	public bool Visible()
	{
		return false;
	}

	public void SetVisible(bool visible)
	{
	}

	public void SetJavaScriptEnabled(bool enabled)
	{
	}

	public static void OpenAuthWebView(string url, WebBoxFlags flag = (WebBoxFlags)0)
	{
	}

	internal void Back()
	{
	}
}
