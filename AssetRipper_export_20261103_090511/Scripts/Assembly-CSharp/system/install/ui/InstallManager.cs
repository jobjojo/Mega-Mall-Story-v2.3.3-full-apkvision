using form;
using java.io;
using java.util;
using kairo.unity.ui;
using kairo.unity.util;
using main;

namespace system.install.ui;

public abstract class InstallManager
{
	internal class InstallDataInfo
	{
		internal int gid_;

		internal long gottenTime_;

		internal InstallDataInfo()
		{
		}

		internal InstallDataInfo(int gid, long timeMillis)
		{
		}
	}

	public class GameAppliState
	{
		public const int FLAG_INSTALL_KCP_RECEIVED = 1;

		public int gid_;

		public int flag_;

		public void Serialize(OutputStream os)
		{
		}

		public void Deserialize(InputStream stream)
		{
		}
	}

	internal static InstallManager instance_;

	public const bool KAIROLAND_BONUS = true;

	public const int REQUEST_CODE = 11000;

	public const int LAYOUT_TYPE_ONEDAY_ONCE = 0;

	public const int LAYOUT_PIRATE_TASTE = 0;

	public const int LAYOUT_SOCIAL_TASTE_FOR_CARD_CHANGE = 0;

	public const int LAYOUT_SOCIAL_TASTE_FOR_SOCIAL = 0;

	public const int LAYOUT_CARD_CHANGE_TASTE = 0;

	public const int LAYOUT_SOCIAL_TASTE_DAY_OF_WEEK = 0;

	public const int LAYOUT_SOCIAL_TASTE_FOR_WIZARD_QUEST = 0;

	public const int LAYOUT_KAIRO_POINT_TASTE = 99;

	internal static int LAYOUT_ID;

	public static string BONUS_NAME;

	internal static int BONUS_MAX;

	public const int STATE_NONE = -1;

	public const int STATE_RECEIVE = 0;

	public const int STATE_PROVISION = 1;

	internal SecureProperty installSave_;

	public const int INSTALLSAVEP_END = 0;

	public static readonly SecureProperty[] defInstallSaveP_;

	public const int INSTALLSAVEI_FALG = 0;

	public const int INSTALLSAVEI_END = 1;

	public static readonly int[] defInstallSaveI_;

	public const int INSTALLSAVEL_END = 0;

	public static readonly long[] defInstallSaveL_;

	public const int INSTALLSAVES_SEND_APPLI = 0;

	public const int INSTALLSAVES_END = 1;

	public static readonly string[] defInstallSaveS_;

	public const int INSTALLSAVEB_INSTALL_BONUS = 0;

	public const int INSTALLSAVEB_GAME_APPLI_STATE_LIST = 1;

	public const int INSTALLSAVEB_END = 4;

	public static readonly byte[][] defInstallSaveB_;

	internal static IApplication app_;

	internal static FormManager fm_;

	internal static AppData apdat_;

	internal sbyte hasReceivedToday_;

	internal long lastReceivedTimeMillis_;

	private IbHelper helper_;

	private IbResult ibResult_;

	private BonusItem ibBonus_;

	private int state_;

	private Vector<InstallDataInfo> installList_;

	private Vector<GameAppliState> gameAppliStateList_;

	private const sbyte YES = 0;

	private const sbyte NO = 1;

	internal virtual int[][] GetBonusItemRateTable()
	{
		return null;
	}

	internal InstallManager()
	{
	}

	public virtual void Init()
	{
	}

	public static InstallManager GetInstance()
	{
		return null;
	}

	public byte[] WriteSendData(string objId = null)
	{
		return null;
	}

	public bool LaunchBonusFlow()
	{
		return false;
	}

	public virtual bool ExecuteApplyBonus(BonusItem item)
	{
		return false;
	}

	private InstallDataInfo SearchInstallDataInfo(int gid)
	{
		return null;
	}

	public virtual void Provisioning(BonusItem item)
	{
	}

	private IbHelper GetIbHelper()
	{
		return null;
	}

	public void Load(byte[] data)
	{
	}

	public byte[] Write()
	{
		return null;
	}

	public void NewGame(bool take)
	{
	}

	public void LoadGame(byte[] data)
	{
	}

	public byte[] WriteGame()
	{
		return null;
	}

	private void PackInstallDataInfo(OutputStream os)
	{
	}

	private void UnpackInstallDataInfo(InputStream stream)
	{
	}

	private byte[] PackInstallBinalyData()
	{
		return null;
	}

	private void UnpackInstallBonusBinalyData()
	{
	}

	private void PackGameAppliStateList(ByteArrayOutputStream baos)
	{
	}

	private byte[] PackGameAppliStateList()
	{
		return null;
	}

	private void UnpackGameAppliStateList()
	{
	}

	internal void LogDebug(string msg)
	{
	}

	internal void LogError(string msg)
	{
	}

	public void SetIbResult(int result, string message)
	{
	}

	public void SetIbBonus(BonusItem itm)
	{
	}

	public string GetUserObjectId()
	{
		return null;
	}

	public bool EnableTodayBonus()
	{
		return false;
	}

	public bool EnableBonusItemData(BonusItem item)
	{
		return false;
	}

	public long getNextDay0HourSec(long time)
	{
		return 0L;
	}

	public JCalendar getNextDay0Hour(long timeMillis)
	{
		return null;
	}
}
