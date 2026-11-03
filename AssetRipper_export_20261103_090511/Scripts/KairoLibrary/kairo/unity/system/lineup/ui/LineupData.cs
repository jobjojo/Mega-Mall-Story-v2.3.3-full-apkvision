using kairo.unity.ui;

namespace kairo.unity.system.lineup.ui;

public class LineupData
{
	internal int gameId_;

	internal string explain_;

	internal string url_;

	internal string file_;

	internal int priority_;

	internal int[][] ratio_;

	internal Image image_;

	public void Load(int gameId, string src)
	{
	}

	public bool LoadImage()
	{
		return false;
	}

	public void UnloadImage()
	{
	}

	public int GetGameId()
	{
		return 0;
	}

	public string GetExplain()
	{
		return null;
	}

	public string GetURL()
	{
		return null;
	}

	public int GetPriority()
	{
		return 0;
	}

	public string GetFileName()
	{
		return null;
	}

	public Image GetImage()
	{
		return null;
	}

	public int GetRatio()
	{
		return 0;
	}
}
