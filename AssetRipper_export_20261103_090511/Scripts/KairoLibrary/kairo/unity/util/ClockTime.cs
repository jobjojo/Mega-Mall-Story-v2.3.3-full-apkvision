using java.lang;

namespace kairo.unity.util;

public class ClockTime
{
	private class ClockTimeCounter
	{
		public long now_;

		public long lastUpdateTime_;

		public int precision_;

		public bool stop_;

		public JThread th_;

		public void SetTime(long time, int precision = 10)
		{
		}

		public void Run()
		{
		}
	}

	private static bool isSetTime_;

	private static bool isServerConnection_;

	private static ClockTimeCounter counter_;

	private static JThread thServer_;

	private static bool serverTimeUpdating_;

	public static void SetTime(long time, int precision = 10)
	{
	}

	public static long GetTime()
	{
		return 0L;
	}

	public static void Destroy()
	{
	}

	public static void UpdateServerTime()
	{
	}

	private static void _updateServerTime()
	{
	}
}
