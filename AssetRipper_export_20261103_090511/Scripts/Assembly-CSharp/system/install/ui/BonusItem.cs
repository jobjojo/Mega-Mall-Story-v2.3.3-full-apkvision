using java.util;

namespace system.install.ui;

public class BonusItem
{
	private int gid_;

	private int bonusValue_;

	private long receivedTimeMillis_;

	private int state_;

	private int installDataGid_;

	public Vector<InstallManager.GameAppliState> gameAppliStateList_;

	public BonusItem(string installBonusInfo)
	{
	}

	public BonusItem(byte[] serverBonusInfo)
	{
	}

	public int GetGid()
	{
		return 0;
	}

	public int GetBonusValue()
	{
		return 0;
	}

	internal void ClampBonusValue(int max)
	{
	}

	public long GetReceivedTimeMillis()
	{
		return 0L;
	}

	public int GetState()
	{
		return 0;
	}

	public int GetInstallDataGid()
	{
		return 0;
	}
}
