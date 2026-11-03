using System.Collections.Generic;
using java.lang;

namespace kairo.unity.io;

public class Http
{
	private class HttpThread
	{
		public JThread thread_;

		public HttpObject http_;

		public bool connect_;
	}

	public const int HTTP_OK = 0;

	public const int HTTP_NOMYMENU = -1;

	public const int HTTP_NG = -98;

	public const int HTTP_PERMISSION = -99;

	private static HttpObject http_;

	private static object lock_;

	private static List<HttpThread> httpThreads_;

	private static string[][] HTTP_TO_HTTPS;

	internal static bool IsRetryEnable { get; set; }

	protected Http()
	{
	}

	public static byte[] Connect(string url, byte[] send, bool check)
	{
		return null;
	}

	public static byte[][] Connect(string url, byte[] send, bool check, bool split)
	{
		return null;
	}

	public static void Interrupt()
	{
	}

	public static int GetErrorCode()
	{
		return 0;
	}

	public static string GetErrorText()
	{
		return null;
	}

	public static string GetErrorText2()
	{
		return null;
	}

	public static string GetErrorUrl()
	{
		return null;
	}

	public static int PopErrorCode()
	{
		return 0;
	}

	public static string PopErrorText()
	{
		return null;
	}

	public static string PopErrorUrl()
	{
		return null;
	}

	private static HttpThread MakeHttp()
	{
		return null;
	}

	private static HttpThread GetHttp()
	{
		return null;
	}

	internal static string GetHttpsUrl(string url)
	{
		return null;
	}
}
