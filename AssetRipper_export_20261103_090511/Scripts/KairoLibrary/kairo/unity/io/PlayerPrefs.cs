namespace kairo.unity.io;

public sealed class PlayerPrefs
{
	public static bool IsFileSystem()
	{
		return false;
	}

	public static void DeleteAll()
	{
	}

	public static void DeleteKey(string key)
	{
	}

	public static float GetFloat(string key)
	{
		return 0f;
	}

	public static float GetFloat(string key, float defaultValue)
	{
		return 0f;
	}

	public static int GetInt(string key)
	{
		return 0;
	}

	public static int GetInt(string key, int defaultValue)
	{
		return 0;
	}

	public static string GetString(string key)
	{
		return null;
	}

	public static string GetString(string key, string defaultValue)
	{
		return null;
	}

	public static bool HasKey(string key)
	{
		return false;
	}

	public static void Save()
	{
	}

	public static void SetFloat(string key, float value)
	{
	}

	public static void SetInt(string key, int value)
	{
	}

	public static void SetString(string key, string value)
	{
	}

	private static string GetKey(string key)
	{
		return null;
	}
}
