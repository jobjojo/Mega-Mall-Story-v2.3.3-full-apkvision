namespace kairo.unity.system.social;

public class Leaderboard
{
	public class LeaderboardData
	{
		private int id_;

		public string key_;

		public string title_;

		public int score_;

		public int ranking_;

		public long date_;

		public bool enable_;

		public void Load(string src)
		{
		}
	}

	private static LeaderboardData[] leaderboardDatas_;

	public const int RESULT_CONNECTING = -1;

	public const int RESULT_ERROR = -2;

	public const int RESULT_ERROR_OS = -3;

	public const int RESULT_ERROR_NODATA = -4;

	public const int RESULT_ERROR_CLOSE = -5;

	public static void SetData(string[] leaderboards)
	{
	}

	public static LeaderboardData[] GetData()
	{
		return null;
	}

	public static bool IsLogin()
	{
		return false;
	}

	public static void Show()
	{
	}

	public static bool StartRankingLoad()
	{
		return false;
	}

	public static int IsEndRankingLoad()
	{
		return 0;
	}

	public static string GetResultRankingLoad()
	{
		return null;
	}

	public static void Send(int leaderboardId, long score)
	{
	}

	public static string GetKey(int leaderboardId)
	{
		return null;
	}

	public static string GetAllKey()
	{
		return null;
	}
}
