namespace kairo.unity.system.lineup.ui;

public class LineupManager
{
	protected static LineupManager instance_;

	private string appliLinkUrl_;

	private LineupData[] lineupList_;

	private int[] showCount_;

	protected LineupData[] showLineups_;

	protected LineupManager()
	{
	}

	public static LineupManager GetInstance()
	{
		return null;
	}

	public void Init()
	{
	}

	public void Load(byte[] data)
	{
	}

	public byte[] Write()
	{
		return null;
	}

	private void LoadLineupList(byte[] data)
	{
	}

	public void Start(int num)
	{
	}

	public void UnloadImage()
	{
	}

	public bool CheckShowableLineup()
	{
		return false;
	}

	public LineupData[] GetShowableLineups()
	{
		return null;
	}

	public LineupData[] GetLineups()
	{
		return null;
	}

	internal static void PutPreferences(string key, byte[] data)
	{
	}

	internal static byte[] GetPreferences(string key)
	{
		return null;
	}

	internal static bool ExistPreferences(string key)
	{
		return false;
	}
}
