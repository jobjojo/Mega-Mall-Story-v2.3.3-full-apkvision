using kairo.unity.util;

namespace system.install.ui;

public class IbHelper
{
	public delegate void OnIbBonusFinished(IbResult result, BonusItem bonus);

	public const int RESPONSE_RESULT_OK = 0;

	public const int RESPONSE_RESULT_USER_CANCELED = 1;

	public const int RESPONSE_RESULT_ERROR = 2;

	public const int RESPONSE_RESULT_BONUS_ALREADY_RECEIVED = 3;

	public const int IBHELPER_BAD_RESPONSE = -1;

	public const int IBHELPER_ACTIVITY_NOT_FOUND_EXCEPTION = -2;

	public const int IBHELPER_USER_CANCELLED = -3;

	public const int IBHELPER_UNKNOWN_INSTALL_BONUS_RESPONSE = -4;

	public const int IBHELPER_UNKNOWN_ERROR = -5;

	public static readonly SecureString INTENT_ACTION_INSTALL_BONUS;

	public static readonly SecureString INTENT_EXTRA_RESPONSE_CODE;

	public static readonly SecureString INTENT_EXTRA_INSTALL_BONUS_DATA_VERSION;

	public static readonly SecureString INTENT_EXTRA_INSTALL_BONUS_DATA;

	private bool debugLog_;

	private string debugTag_;

	private int requestCode_;

	private OnIbBonusFinished bonusListener_;

	public void EnableDebugLogging(bool enable)
	{
	}

	public void LaunchBonusFlow(SecureString data, int requestCode, OnIbBonusFinished listener, string extraData)
	{
	}

	internal void LogDebug(string msg)
	{
	}

	internal void LogError(string msg)
	{
	}
}
