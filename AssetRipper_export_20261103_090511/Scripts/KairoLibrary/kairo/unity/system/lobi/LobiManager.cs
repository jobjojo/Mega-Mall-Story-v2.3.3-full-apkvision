using kairo.unity.util;

namespace kairo.unity.system.lobi;

public abstract class LobiManager
{
	protected static LobiManager instance_;

	public const int TYPE_CHAT = 0;

	public const int TYPE_RANKING = 1;

	private SecureString country_;

	public static LobiManager GetInstance()
	{
		return null;
	}

	protected abstract long[][] GetScoreList();

	private byte[] WriteSendData(int type, int number)
	{
		return null;
	}

	public void Open(int type, int number)
	{
	}

	protected abstract bool IsGlobal();

	public bool IsEnabled()
	{
		return false;
	}
}
