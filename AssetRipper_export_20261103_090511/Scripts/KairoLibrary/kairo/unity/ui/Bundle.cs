using System.Collections.Generic;

namespace kairo.unity.ui;

public class Bundle
{
	internal Dictionary<string, string> data_;

	public Dictionary<string, string>.KeyCollection Keys => null;

	public Bundle()
	{
	}

	public Bundle(string data)
	{
	}

	private static int GetBundleString(string src, int index, out string result)
	{
		result = null;
		return 0;
	}

	public float GetFloat(string key)
	{
		return 0f;
	}

	public float GetFloat(string key, float defaultValue)
	{
		return 0f;
	}

	public int GetInt(string key)
	{
		return 0;
	}

	public int GetInt(string key, int defaultValue)
	{
		return 0;
	}

	public long GetLong(string key)
	{
		return 0L;
	}

	public long GetLong(string key, long defaultValue)
	{
		return 0L;
	}

	public string GetString(string key)
	{
		return null;
	}

	public string GetString(string key, string defaultValue)
	{
		return null;
	}

	public bool ContainsKey(string key)
	{
		return false;
	}

	public bool IsEmpty()
	{
		return false;
	}
}
