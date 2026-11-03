namespace kairo.unity.system.social;

public class Achievement
{
	public class AchievementData
	{
		private int id_;

		public string key_;

		public long getDate_;

		public void Load(string src)
		{
		}
	}

	public const int ACHIEVEMENT_GRADE_BRONZE = 0;

	public const int ACHIEVEMENT_GRADE_SILVER = 1;

	public const int ACHIEVEMENT_GRADE_GOLD = 2;

	public const int ACHIEVEMENT_GRADE_MAX = 3;

	private static AchievementData[] achievementDatas_;

	public static void SetData(string[] achievements)
	{
	}

	public static AchievementData[] GetData()
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

	public static void LoadAll()
	{
	}

	public static void ResetAll()
	{
	}

	public static void Unlock(int achievementId, int progress, bool checkOnetime = true)
	{
	}

	public static string GetKey(int achievementId)
	{
		return null;
	}

	public static int GetUnlockPoint()
	{
		return 0;
	}

	public static int GetUnlockPoint(int achievementId)
	{
		return 0;
	}

	private static int _getUnlockPoint(int achievementId)
	{
		return 0;
	}
}
