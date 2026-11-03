using System.Collections.Generic;

namespace kairo.unity.util;

public class Trophy
{
	public class TrophyData
	{
		private int id_;

		public int grade_;

		public bool hide_;

		public string title_;

		public string explain_;

		public long getDate_;

		public void Load(string src)
		{
		}
	}

	public const int TROPHY_GRADE_BRONZE = 0;

	public const int TROPHY_GRADE_SILVER = 1;

	public const int TROPHY_GRADE_GOLD = 2;

	private const int TROPHY_GRADE_PLATINUM = 3;

	public const int TROPHY_GRADE_MAX = 4;

	private static int[] trophyPoints_;

	public const int PLATINUM_UNKNOWN = -1;

	public const int PLATINUM_DISABLE = 0;

	public const int PLATINUM_ENABLE = 1;

	private static int platinumState_;

	private static bool[] unlockWait_;

	private static TrophyData[] trophyDatas_;

	private static string[] STEAM_ACHIEVEMENT_IDS;

	private static Dictionary<string, bool> steamAchieveTable_;

	private static bool m_bRequestedStats;

	private static bool m_bStatsValid;

	private static bool m_bStoreStats;

	private static int LimitNum => 0;

	public static void Initialise()
	{
	}

	public static void Terminate()
	{
	}

	public static void SetData(int trophyMax)
	{
	}

	public static TrophyData[] GetData()
	{
		return null;
	}

	public static void SetPoints(int[] points)
	{
	}

	public static void Unlock(int trophyId, bool checkOnetime = true)
	{
	}

	public static bool shouldUnlock(int trophyId)
	{
		return false;
	}

	public static bool IsUnlock(int trophyId)
	{
		return false;
	}

	public static int GetGradePoint(int grade)
	{
		return 0;
	}

	public static int GetUnlockPoint()
	{
		return 0;
	}

	public static int GetUnlockPoint(int trophyId)
	{
		return 0;
	}

	private static int _getUnlockPoint(int trophyId)
	{
		return 0;
	}

	public static void StartAchievementSystem(string[] achievementIds)
	{
	}

	private static bool IsPlatinum(bool reCheck = false)
	{
		return false;
	}

	public static void Clear()
	{
	}

	public static void Lock(int trophyId)
	{
	}

	internal static string GetAchievementId(int trophyId)
	{
		return null;
	}

	internal static int GetAchievementIndex(string id)
	{
		return 0;
	}

	internal static void Update()
	{
	}

	private static bool IsEnable()
	{
		return false;
	}
}
