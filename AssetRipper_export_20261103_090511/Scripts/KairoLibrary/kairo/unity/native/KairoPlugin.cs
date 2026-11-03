using System.Collections.Generic;
using UnityEngine;
using kairo.unity.form;
using kairo.unity.type;
using kairo.unity.ui;

namespace kairo.unity.native;

public static class KairoPlugin
{
	private static IApplication app_;

	private static AndroidJavaClass Config;

	private static AndroidJavaClass Utility;

	private static AndroidJavaClass VERSION;

	private static LanguageSelectForm languageDialog_;

	private static string[] languageResults_;

	public const int INPUT_IDOK = 1;

	public const int INPUT_IDCANCEL = 2;

	private static string fepTitle_;

	private static string fepText_;

	private static int fepMode_;

	private static string fepPositive_;

	private static string fepNegative_;

	private static int fepMaxLength_;

	private static string[] langPanelResult_;

	internal static int licenseCheckCount_;

	internal static int isLicenseV1_;

	private static string signature_;

	private static int sdk_;

	private static string release_;

	private static int isTablet_;

	private static int systemBarHeight_;

	private static int statusBarHeight_;

	private static int unityVarsion_;

	private static int statusBarPosition_;

	private static bool _fullscreen_param1;

	private static int lastCanvasWidth_;

	private static int lastCanvasHeight_;

	private static int appWidth_;

	private static int appHeight_;

	private static float scaleRatio_;

	private static int scaleRatioReqWidth_;

	private static int scaleRatioReqHeight_;

	private static int scaleRatioAppWidth_;

	private static int scaleRatioAppHeight_;

	private static int scaleRatioFrame_;

	private static float scaleRatioBase_;

	private static string packageName_;

	private static string[] languageCode_;

	public const int SAFEAREA_LEFT = 0;

	public const int SAFEAREA_TOP = 1;

	public const int SAFEAREA_RIGHT = 2;

	public const int SAFEAREA_BOTTOM = 3;

	public const int SAFEAREA_MAX = 4;

	internal static Alignment sensorHousingAlignment_;

	private static readonly string[] REGION_NAMES;

	public static void Init(int language, bool log, string licenseKey)
	{
	}

	public static void Finish()
	{
	}

	public static int LicenseCheck()
	{
		return 0;
	}

	public static int LicenseCheckForSugo()
	{
		return 0;
	}

	public static int LicenseCheckForAu()
	{
		return 0;
	}

	public static string GetSignature()
	{
		return null;
	}

	private static string _getSignature()
	{
		return null;
	}

	public static int GetSDK()
	{
		return 0;
	}

	private static int _getSDK()
	{
		return 0;
	}

	public static string GetReleaseNumber()
	{
		return null;
	}

	public static string GetRelease()
	{
		return null;
	}

	private static string _getRelease()
	{
		return null;
	}

	public static bool IsTablet()
	{
		return false;
	}

	private static bool _isTablet()
	{
		return false;
	}

	public static int GetSystemBarHeight()
	{
		return 0;
	}

	private static int _getSystemBarHeight()
	{
		return 0;
	}

	public static int GetStatusBarHeight()
	{
		return 0;
	}

	private static int _getStatusBarHeight()
	{
		return 0;
	}

	public static int GetUnityVarsion()
	{
		return 0;
	}

	public static int GetStatusBarPosition()
	{
		return 0;
	}

	private static int _getStatusBarPosition()
	{
		return 0;
	}

	public static void Fullscreen(bool enable)
	{
	}

	private static void _fullscreen(bool enable)
	{
	}

	public static bool IsFullscreen()
	{
		return false;
	}

	private static bool _isFullscreen()
	{
		return false;
	}

	public static int GetWidth()
	{
		return 0;
	}

	private static int _getWidth()
	{
		return 0;
	}

	public static int GetHeight()
	{
		return 0;
	}

	private static int _getHeight()
	{
		return 0;
	}

	public static int GetAppWidth()
	{
		return 0;
	}

	private static int _getAppWidth()
	{
		return 0;
	}

	public static int GetAppHeight()
	{
		return 0;
	}

	private static int _getAppHeight()
	{
		return 0;
	}

	internal static void UpdateAppSize()
	{
	}

	public static void ResetAppSize()
	{
	}

	internal static Size GetSteamScreenSize()
	{
		return default;
	}

	public static float GetScaleRatio(int width, int height)
	{
		return 0f;
	}

	private static float _getScaleRatioRun(int width, int height)
	{
		return 0f;
	}

	private static float _getScaleRatio(int width, int height)
	{
		return 0f;
	}

	public static string GetPackageName()
	{
		return null;
	}

	private static string _getPackageName()
	{
		return null;
	}

	public static float Get_iOSVersionF()
	{
		return 0f;
	}

	public static string Get_iOSVersionS()
	{
		return null;
	}

	public static int ShowDialog(int type, string title, string msg, string buttons = null)
	{
		return 0;
	}

	public static string ImeOnBlock(string text, int displayMode, int inputMode)
	{
		return null;
	}

	public static bool SetClockTime(long time, int precision)
	{
		return false;
	}

	public static long GetClockTime()
	{
		return 0L;
	}

	private static long _getClockTime()
	{
		return 0L;
	}

	public static int[] GetBatteryInfo()
	{
		return null;
	}

	private static int[] _getBatteryInfo()
	{
		return null;
	}

	public static string[] ShowFepPanel(string title, string text, int mode, string positive, string negative, int maxLength = 0)
	{
		return null;
	}

	public static void StartFepPanel(string title, string text, int mode, string positive, string negative, int maxLength = 0)
	{
	}

	public static bool IsFepPanelFinish()
	{
		return false;
	}

	public static string[] GetFepPanelResult()
	{
		return null;
	}

	public static void PutPreference(string key, byte[] data)
	{
	}

	public static byte[] GetPreference(string key)
	{
		return null;
	}

	public static void RemovePreference(string key)
	{
	}

	public static string[] GetPreferenceKeys()
	{
		return null;
	}

	public static void ShowToast(string text, int duration = 0)
	{
	}

	public static bool SaveToSd(string file, byte[] data)
	{
		return false;
	}

	public static bool SaveToSd(string file, byte[] data, out string save)
	{
		save = null;
		return false;
	}

	public static bool SaveToTmpCaptureDirectory(string file, byte[] data, out string save)
	{
		save = null;
		return false;
	}

	public static void DeleteTmpCaptureDirectory()
	{
	}

	public static bool CloseKairoClub()
	{
		return false;
	}

	public static void Vibrator(params long[] pattern)
	{
	}

	internal static bool SupportsDepth24()
	{
		return false;
	}

	public static bool IsInstalledApplication(string packageName)
	{
		return false;
	}

	public static string InstalledApplicationList()
	{
		return null;
	}

	public static string[] LaunchBonusFlow(string data, int requestCode)
	{
		return null;
	}

	public static void LaunchLobi(string data, int type, int number)
	{
	}

	private static AndroidJavaObject CreateLobiIntent(string data, int type, int number)
	{
		return null;
	}

	public static string GetInstallReferrer(string key = null)
	{
		return null;
	}

	public static void startInputPanel(string title, string text, int maxLength)
	{
	}

	public static bool isEndInputPanel()
	{
		return false;
	}

	public static string getResultInputPanel()
	{
		return null;
	}

	public static void jumpStore(string ID)
	{
	}

	public static void JumpStore(long appID)
	{
	}

	public static void jumpStoreKairosoft()
	{
	}

	public static void jumpNotificationSettings()
	{
	}

	public static bool CheckNotification()
	{
		return false;
	}

	public static void SendNotification(long delay, string text, string option = "")
	{
	}

	public static void ClearNotifications(bool notify = true, bool alarm = true)
	{
	}

	internal static void CancelNotifications(bool notify = true, bool ararm = true)
	{
	}

	public static string GetGCMRegistrationId()
	{
		return null;
	}

	public static void SetGCMRegistrationId(string regId)
	{
	}

	internal static bool CheckPlayServices()
	{
		return false;
	}

	internal static string[] GetNotificationData()
	{
		return null;
	}

	public static string[] GetNotificationDataDirect()
	{
		return null;
	}

	public static void RemoveNotificationData()
	{
	}

	internal static void SetNotificationFilter(int filterLevel)
	{
	}

	internal static int GetNotificationFilter()
	{
		return 0;
	}

	internal static void SetNotificationBackground(bool enable)
	{
	}

	public static void StartNotificationEnableDialog()
	{
	}

	internal static void ResetResolution()
	{
	}

	public static int IsPB()
	{
		return 0;
	}

	public static void RequestPermission(string permissionName, bool changeReboot = true)
	{
	}

	internal static void RequestPermission2(string permissionName)
	{
	}

	public static bool HasPermission(string permissionName)
	{
		return false;
	}

	public static bool CheckPermissionConfirmAfter(string permissionName)
	{
		return false;
	}

	public static void LaunchSetting()
	{
	}

	public static void StartLanguagePanel(string[] languages, int index, string customPackLocation, int mode = 0)
	{
	}

	public static void _startLanguagePanel(string[] languages, int index, string customPackLocation, int mode)
	{
	}

	public static bool IsLanguagePanelFinish()
	{
		return false;
	}

	public static string[] GetLanguagePanelResult()
	{
		return null;
	}

	public static bool FileExists(string path)
	{
		return false;
	}

	public static byte[] ReadFile(string path)
	{
		return null;
	}

	public static bool IsWeakDrawDevice()
	{
		return false;
	}

	public static bool IsWeakDrawDevice(string[] devNG)
	{
		return false;
	}

	public static bool IsDeviceSoundStopOnResume()
	{
		return false;
	}

	public static bool IsTapjoyRestriction()
	{
		return false;
	}

	public static Image MakeFontTexture(string text, int color, int size)
	{
		return null;
	}

	public static Image MakeFontTextureBold(string text, int color, int size, int outlineWidth, int ourlineQuality)
	{
		return null;
	}

	private static Image MakeFontTexture(byte[] data)
	{
		return null;
	}

	public static SizeF GetFontTextureSize(string text, int size)
	{
		return default;
	}

	public static void SafetyNetAttest(int ver, int pid)
	{
	}

	public static bool IsOwner()
	{
		return false;
	}

	public static long GetSerialNumberForUser()
	{
		return 0L;
	}

	public static string GetModel()
	{
		return null;
	}

	public static void QuestionDialog_PushNotify()
	{
	}

	public static string GetErrMsg()
	{
		return null;
	}

	public static void BackupCreate()
	{
	}

	public static bool BackupExists()
	{
		return false;
	}

	public static bool BackupRestore()
	{
		return false;
	}

	public static void TrophyInitialise()
	{
	}

	public static void TrophyTerminate()
	{
	}

	public static void TrophyUnlock(int trophyId)
	{
	}

	public static bool TrophyIsUnlock(int trophyId)
	{
		return false;
	}

	public static string[] GetLanguageCode(bool reCheck = false)
	{
		return null;
	}

	internal static void ShowShareChooser(string text, string url, string imagePath)
	{
	}

	public static int[] GetSafeArea(bool asymmetrical = false)
	{
		return null;
	}

	public static bool IsBezelless()
	{
		return false;
	}

	public static Alignment GetSensorHousing()
	{
		return Alignment.None;
	}

	internal static void StartAdvertisingId()
	{
	}

	internal static int CheckAdvertisingId()
	{
		return 0;
	}

	internal static string GetAdvertisingId()
	{
		return null;
	}

	public static bool LaunchApplication(string pkg, string args = "", bool notInstalledMarket = false)
	{
		return false;
	}

	internal static string GetLaunchArguments()
	{
		return null;
	}

	internal static void LogAndroidOnly(string text)
	{
	}

	public static int CopySaveDirectory(string src, string dst)
	{
		return 0;
	}

	public static bool ExistsSaveDirectory(string dirName)
	{
		return false;
	}

	private static void CopyDirectory(string src, string dst)
	{
	}

	public static void ShowDetailsSettings()
	{
	}

	public static bool IsPassUser()
	{
		return false;
	}

	public static int GetRegionIndex()
	{
		return 0;
	}

	public static string GetRegionName()
	{
		return null;
	}

	public static bool HasIntent()
	{
		return false;
	}

	public static string GetIntentAction()
	{
		return null;
	}

	public static string GetIntentPackage()
	{
		return null;
	}

	public static string GetIntentScheme()
	{
		return null;
	}

	public static Bundle GetIntentExtras()
	{
		return null;
	}

	public static void setEmptyIntent()
	{
	}

	public static void SetResult(int resultCode, string[][] extras = null)
	{
	}

	private static byte[] PackRecords(Dictionary<string, object> records)
	{
		return null;
	}

	public static void InsertSQL(string table, Dictionary<string, object> records)
	{
	}

	public static void UpdateSQL(string table, Dictionary<string, object> records, string where, string[] whereArgs)
	{
	}

	public static void DeleteSQL(string table, string where, string[] whereArgs)
	{
	}

	public static bool ExistsSQL(string table, string where)
	{
		return false;
	}

	public static Dictionary<string, object>[] SelectSQL(string table, string get, string where)
	{
		return null;
	}

	public static bool IsInstalledKairoClub()
	{
		return false;
	}

	public static string GetAccount()
	{
		return null;
	}

	public static byte[] GetCloudData()
	{
		return null;
	}

	public static void SetCloudData(byte[] data)
	{
	}

	public static void iCloudLoadStart(string key)
	{
	}

	public static int iCloudLoadingCount()
	{
		return 0;
	}

	public static void iCloudLoadEnded()
	{
	}

	public static void iCloudSave(string key, byte[] dat)
	{
	}

	public static bool iCloudCheckUpdateSync()
	{
		return false;
	}

	public static void StartArcadeSplash()
	{
	}

	public static bool IsEndArcadeSplash()
	{
		return false;
	}

	internal static void SetParam(string key, string value)
	{
	}

	internal static string GetParam(string key)
	{
		return null;
	}

	public static void AuthenticateNativeUser()
	{
	}

	public static bool IsAuthenticateNativeUser()
	{
		return false;
	}

	public static string GetAuthenticateNativeUserName()
	{
		return null;
	}

	public static Image GetAuthenticateNativeUserImage()
	{
		return null;
	}

	public static void ShowScores()
	{
	}

	public static void SendScore(string scoreID, long score)
	{
	}

	public static void StartRankingLoad(string scoreIDs)
	{
	}

	public static int IsEndRankingLoad()
	{
		return 0;
	}

	public static string GetResultRankingLoad()
	{
		return null;
	}

	public static void AchievementShow()
	{
	}

	public static void AchievementSend(string achievementID, int progress)
	{
	}

	public static void AchievementLoad()
	{
	}

	public static void AchievementResetAll()
	{
	}

	public static long GetServerResponseTime()
	{
		return 0L;
	}

	public static void Share(string text, string url, string textureUrl)
	{
	}
}
