using System.Threading;

namespace kairo.unity.ui;

public class SplashScreen
{
	private long beginTime_;

	private int bkVSyncCount_;

	private int bkTargetFrameRate_;

	internal static ThreadStart OnFinishedMethod { get; set; }

	internal bool IsDisposed { get; private set; }

	public static SplashScreen Start()
	{
		return null;
	}

	public void Draw()
	{
	}
}
