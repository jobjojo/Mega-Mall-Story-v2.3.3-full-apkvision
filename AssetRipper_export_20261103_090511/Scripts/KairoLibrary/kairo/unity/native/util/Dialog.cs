using System.Diagnostics;

namespace kairo.unity.native.util;

public static class Dialog
{
	public delegate void OnClosed(string[] result);

	public static Process LastProcess { get; private set; }

	public static string[] ShowUnityDialog(params object[] args)
	{
		return null;
	}

	public static string[] ShowUnityDialog(OnClosed onClosed, params object[] args)
	{
		return null;
	}
}
