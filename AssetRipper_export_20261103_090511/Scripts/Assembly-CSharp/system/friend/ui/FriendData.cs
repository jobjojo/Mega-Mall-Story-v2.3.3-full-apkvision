using java.util;
using kairo.unity.ui;
using kairo.unity.util;
using system.form;

namespace system.friend.ui;

public abstract class FriendData
{
	internal static FriendData instance_;

	public int FRIEND_MAX;

	public string INTRODUCTION_APPLY_SUBJECT;

	public string INTRODUCTION_APPLY_TEXT;

	public string INTRODUCTION_SUBJECT;

	public string INTRODUCTION_TEXT;

	public SecureProperty friSave_;

	public const int FRISAVEP_END = 0;

	public static readonly SecureProperty[] defFriSaveP_;

	public const int FRISAVEI_FLAG = 0;

	public const int FRISAVEI_MINUTE_MY = 1;

	public const int FRISAVEI_MINUTE_PREVIOUS = 2;

	public const int FRISAVEI_MINUTE_DIFF = 3;

	public const int FRISAVEI_MINUTE_TOTAL = 4;

	public const int FRISAVEI_SAVE_VERSION = 5;

	public const int FRISAVEI_END = 6;

	public static readonly int[] defFriSaveI_;

	public const int FRISAVE_FLAG_ABOUT_FRIEND = 1;

	public const int FRISAVEL_END = 0;

	public static readonly long[] defFriSaveL_;

	public const int FRISAVES_FRIEND_NAME = 0;

	public const int FRISAVES_END = 1;

	public static readonly string[] defFriSaveS_;

	public const int FRISAVEB_FRIEND_HISTORY = 0;

	public const int FRISAVEB_NEW_FRIEND = 1;

	public const int FRISAVEB_END = 2;

	public static readonly byte[][] defFriSaveB_;

	public int PLAY_BONUS_INTERVAL_MINUTE;

	public int PLAY_BONUS_MAX;

	public int PLAY_NEW_FRIEND_BONUS;

	public Vector friendList_;

	public Vector applyList_;

	public Vector newFriendList_;

	private Friend randomFriend_;

	private bool friendDataUpdated_;

	public bool alreadyCheckPlayTimeBonus_;

	public bool alreadyCheckNewFriendBonus_;

	public SecureInt previousUpdateMinute_;

	private Vector friendHistory_;

	private long playTimeBegin_;

	private long playTimeSec_;

	internal FriendData()
	{
	}

	public static FriendData GetInstance()
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

	private void PackFriendBinalyData()
	{
	}

	private void UnpackFriendBinalyData()
	{
	}

	public void CgiRegistFriend(string name, long minute)
	{
	}

	public virtual Vector CgiGetFriendList()
	{
		return null;
	}

	public Friend CgiSearchFriend(string friendId)
	{
		return null;
	}

	public void CgiApplyFriend(string friendId)
	{
	}

	public void CgiApproveFriend(string friendId)
	{
	}

	public void CgiRefuseFriend(string friendId)
	{
	}

	public Friend CgiRandomFriend()
	{
		return null;
	}

	public string GetFriendName()
	{
		return null;
	}

	public string GetFriendID()
	{
		return null;
	}

	public void SetFriendName(string name)
	{
	}

	public bool CheckRegistFriend()
	{
		return false;
	}

	public int GetPlayBonus()
	{
		return 0;
	}

	public void RefreshFriendList()
	{
	}

	public bool UpdateRandomFriend()
	{
		return false;
	}

	public bool ExistRandomFriend()
	{
		return false;
	}

	public Friend GetRandomFriend()
	{
		return null;
	}

	private static void DrawGradation(Graphics g, int dx, int dy, int sx, int sy, int w, int h, int sr, int sg, int sb, int dr, int dg, int db)
	{
	}

	public static void ActionSendMail(string subject, string text)
	{
	}

	public bool IsFriendDataUpdated()
	{
		return false;
	}

	public void InitializeData()
	{
	}

	public static bool IsEffectiveRegistName(string name)
	{
		return false;
	}

	public static bool IsEffectiveRegistName(string name, int max)
	{
		return false;
	}

	public FriendForm GetCurrentForm()
	{
		return null;
	}

	public FriendForm GetCurrentForm(Friend friend)
	{
		return null;
	}

	public void UpdatePlayTime()
	{
	}

	public abstract void PlayBonus(int value);
}
