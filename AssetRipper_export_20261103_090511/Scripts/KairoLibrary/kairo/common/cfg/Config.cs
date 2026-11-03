using System;

namespace kairo.common.cfg;

public class Config
{
	public const int APPLITYPE_DOCOMO = 0;

	public const int APPLITYPE_SOFTBANK = 1;

	public const int APPLITYPE_ANDROID = 2;

	public const int APPLITYPE_IPHONE = 3;

	public const int APPLITYPE_STEAM = 4;

	public static int APPLI_TYPE;

	public const int BUILDTYPE_NORMAL = 0;

	public const int BUILDTYPE_AMAZON = 1;

	public const int BUILDTYPE_AU = 2;

	public const int BUILDTYPE_SUGO = 3;

	public const int BUILDTYPE_HATCH = 4;

	public const int BUILDTYPE_ARCADE = 5;

	public static int BUILD_TYPE;

	public static int APPLI_VERSION;

	public static int REGIST_WAIT;

	public static bool DEBUG;

	public static bool PTW;

	public static bool POST_MARK;

	public static bool USE_HEAP_STORAGE;

	public static bool USE_MEMORY;

	public static bool USE_MEXA_UNIT1;

	public static bool COUNT_ENABLE;

	public static bool PRINT;

	public static bool USE_UNUSE_CHECK;

	public static bool NUMPADCONTROL;

	public static bool FAST_BRIGHTNESS;

	public static int LANGUAGE;

	public static bool TRANSLATE;

	public static string BASE64_PUBLIC_KEY;

	public static bool UNITY_EDITOR;

	public static string AD_UNIT_ID;

	public static int AD_SIZE;

	public static int AD_LOCATION;

	public static bool FULLSCREEN;

	public static bool ICLOUD;

	public static bool ICLOUD_V2;

	public static bool LOCALIZE_FONT_SCALE;

	public static bool LOWDEPTH_TEST;

	public static bool LANDSCAPE_GAME;

	public static bool MULTI_USER_ENABLE;

	public static bool SAVEDATA_LOCALIZE;

	public static string ROOT_FOLDER;

	public static bool MULTIPLE_PACKAGE;

	public static bool FRAMEWORK;

	public static bool MU_VC_APPEND_JA;

	public static bool FAST_LOADER;

	public static bool HTTPS;

	public static bool CLOCK_RECEIVER_ENABLE;

	public static bool GOOGLE_PLAY_SERVICES;

	public static bool JUMP_TO_PLAY_STORE;

	public static bool SCREEN_ROTATION;

	public static bool ASIA_FONT_SCALE;

	public static bool LANG_EN_ENABLE;

	public static bool LANG_CN_ENABLE;

	public static bool LANG_TW_ENABLE;

	public static bool LANG_HK_ENABLE;

	public static bool LANG_KR_ENABLE;

	public static bool LANG_TH_ENABLE;

	public static bool LANG_FR_ENABLE;

	public static bool LANG_DE_ENABLE;

	public static bool LANG_IT_ENABLE;

	public static bool LANG_ES_ENABLE;

	public static bool LANG_PT_ENABLE;

	public static bool LANG_RU_ENABLE;

	public static bool LANG_AR_ENABLE;

	public static bool LANG_HI_ENABLE;

	public static bool LANG_TR_ENABLE;

	public static bool LANG_ID_ENABLE;

	public static bool USE_STEAM;

	public static bool USE_FORMEDITOR;

	public static string MAINPRODUCT_ID;

	public static bool USE_ADVERTISING_ID;

	public static string BUILD_TIMESTAMP;

	public static bool PURCHASE_CONSUMABLE;

	public static int TOUCH_EFFECT_FPS;

	public const int SAFEAREA_B_NONE = 0;

	public const int SAFEAREA_B_PORTRAIT = 1;

	public const int SAFEAREA_B_LANDSCAPE = 2;

	public const int SAFEAREA_B_ALL = 3;

	public static int SAFEAREA_TYPE_BOTTOM;

	public static bool LOG_COMPRESS;

	public static bool LOG_TAPJOY;

	public static bool LOG_STORE;

	public static bool TRACE_URL;

	public static bool DEBUG_UID;

	public static string UID;

	public static bool REGIST_ENABLE;

	public static bool TRIAL_VERSION;

	public static bool ADMOB_ENABLE;

	public static bool DEBUG_CMD;

	public static bool DEBUG_SEND_SC;

	public static bool DEBUG_CMD_DEV;

	public static bool SHOW_DEBUG;

	public static bool SHOW_FPS;

	public static bool SHOW_MEM;

	public static bool MUTE_SE;

	public static bool FPS_UNLIMITED;

	public static bool SHOW_GUIDEPOINT;

	public static bool DEBUG_SLOW;

	public static bool DEBUG_FAST;

	public static bool DEBUG_MONEYUP;

	public static bool JOYSTICK_ENABLE;

	public static string KAIRO_ACOUNT_SERVER;

	public static string NUMB_SERVER;

	public static string KAIRO_NOTIFICATION_SERVER;

	public static string OLD_SAVENAME;

	public static int drawImageCount_;

	public static int drawStringCount_;

	public static int drawShapeCount_;

	public static int drawImageArea_;

	public static int drawSourceImageArea_;

	public static int createImageArea_;

	public static int checkCount_;

	public static int PID;

	public static string PID_NAME;

	private static string CGI_COMMON_QUERY;

	public static string APPLI_NAME;

	public static string APPLI_TITLE;

	public static string OUTPUT_CSV_NAME;

	public static string URL_REGIST;

	public static string URL_RANKING;

	public static string URL_REGIST_SCORE;

	public static string URL_GET_SCORE;

	public static string URL_DATA;

	public static string URL_SITE;

	public static string URL_VERSIONUP;

	public static string URL_SP;

	public static string URL_PACKAGE;

	public static string URL_REVIEW;

	public static string URL_PHP;

	public static string APP_ID;

	public static bool INTERNET;

	public static bool GUI_INPUTPANEL;

	public static bool GUI_DIALOG;

	public static bool FORM_LANGUAGESELECT;

	public static bool SPOUT_SWITCH;

	public static string CSV_ID;

	public static string CSV_NAMES;

	public const int RATINGCERT_CERO = 0;

	public const int RATINGCERT_IARC = 1;

	public const int RATINGCERT_PS4_UNION = 2;

	public static int RATING_CERTIFICATION;

	private static int editorPlatform_;

	private static readonly string[] SKIP_OVERRIDE_STATIC_FIELD_NAMES;

	private static bool[] checkVRAM_result;

	private static string platform_;

	public static Platforms Platform => Platforms.Android;

	protected Config()
	{
	}

	public static void Create(Type config)
	{
	}

	private static string GetConfigValue(string key)
	{
		return null;
	}

	public static void Init(string sourceUrl)
	{
	}

	public static bool CheckVRAM()
	{
		return false;
	}

	public static string GetPlatform()
	{
		return null;
	}

	public static string ConvertExtension(string file)
	{
		return null;
	}

	public static bool IsConsole()
	{
		return false;
	}

	public static bool IsPS4()
	{
		return false;
	}

	public static bool IsXboxConsole()
	{
		return false;
	}

	public static bool IsXboxDesktop()
	{
		return false;
	}

	public static bool IsXbox()
	{
		return false;
	}

	public static bool IsMacEditor()
	{
		return false;
	}
}
