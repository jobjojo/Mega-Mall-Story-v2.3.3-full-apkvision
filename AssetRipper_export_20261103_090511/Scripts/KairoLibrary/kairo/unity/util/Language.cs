using System;
using System.Collections.Generic;
using System.Threading;
using java.util;
using kairo.unity.ui;

namespace kairo.unity.util;

public class Language
{
	private class LangPackFormat
	{
		public string File;

		public char LineCode;

		public char SegCode;

		public LangPackFormat(string file, char lineCode, char segCode)
		{
		}
	}

	private struct Position(int line, int segment)
	{
		public int Line = 0;

		public int Segment = 0;
	}

	private struct RecordPosition(int line, int segment, LangPackRecord record = null)
	{
		public int Line = 0;

		public int Segment = 0;

		public LangPackRecord Record = null;
	}

	private class LangPackRecord
	{
		public int Id;

		public string File;

		public List<Position> Positions;

		public List<string> From;

		public List<string> To;

		public bool RefOther;

		public LangPackRecord RefRecord;

		public LangPackRecord(int id, string file = null, string text = null)
		{
		}

		public void AddPosition(int line, int segment)
		{
		}
	}

	public class LanguagePackInfo
	{
		public string Author;

		public string Code;

		public string Title;

		public string Appli;

		public string Version;

		public string Scale;
	}

	private class NameElement
	{
		public string Id;

		public string Text;

		public string Footer;

		public NameElement(string id, string src)
		{
		}

		private bool IsLocalize(char c)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}

	private class TranslateCache
	{
		public Canvas.InputDevices device_;

		public string source_;

		public string result_;

		public string args_;

		public int frame_;
	}

	public enum Languages
	{
		Japanese = 0,
		English = 1,
		Chinese = 2,
		TraditionalChinese = 3,
		Korean = 4,
		Thai = 5,
		French = 6,
		German = 7,
		Italian = 8,
		Spanish = 9,
		Portuguese = 10,
		Russian = 11,
		Arabic = 12,
		Hindi = 13,
		Turkish = 14,
		Indonesia = 15,
		Other = 16
	}

	internal class ChanakyaCache
	{
		public string Text;

		public int Frame;

		public ChanakyaCache(string text)
		{
		}
	}

	public const int JAPANESE = 0;

	public const int ENGLISH = 1;

	protected static int language_;

	protected static int priorityLanguage_;

	private static string KAIRO_JAPANESE;

	private static string KAIRO_ENGLISH;

	protected static readonly string[] FOLDERS;

	protected static string[][] softlabelTable_;

	protected static string[][][] textTable_;

	private static string[][] BUILTIN_TRANSLATE_TABLE;

	private static string[][] BUILTIN_SOFTLABEL_TABLE;

	private static string[][] BUILTIN_MULTI_LANG_TABLE;

	public static string[][] BUILTIN_CONSOLE_TABLE;

	private static Dictionary<string, string> builtInMultiLangTable_;

	private static string builtInMultiLangCode_;

	private static Dictionary<string, string> consoleTextTable_;

	private static string[][][] builtInTextTable_;

	private static ThreadStart translateTableMethod_;

	private static LanguageConfig langConfig_;

	private static LangPackRecord[] langPackRecords_;

	private static Dictionary<string, List<RecordPosition>[]> langPackLines_;

	private static Dictionary<string, LangPackFormat> langPackFormats_;

	private static string langPackAuthor_;

	private static string langPackCode_;

	private static string langPackTitle_;

	private static int langPackScale_;

	private static string[] langPackFolders_;

	private static string langPackFile_;

	private static string[][] systemLangPackFiles_;

	private static string[][] disableLangPackFiles_;

	private static LanguageConfig.Settings[] systemLangPackSettings_;

	private static Dictionary<string, bool> langPackDefines_;

	private const string PREF_BASE_LANG_PACK = "_language_pack";

	private const string PREF_BASE_LANG_MATCH = "_language_pack_match";

	private const string PREF_BASE_LAST_LOCALE = "_language_pack_locale";

	private const string PREF_BASE_CUSTOM_LANG_LOCATION = "_language_pack_location";

	private const string PREF_BASE_CUSTOM_LANG_SEND = "_language_pack_send";

	private const string PREF_BASE_LANG_NEW = "_language_pack_new";

	private const string PREF_BASE_USER_CHANGED = "_language_pack_userchanged";

	private static string PREF_LANG_PACK;

	private static string PREF_LANG_MATCH;

	private static string PREF_LAST_LOCALE;

	private static string PREF_CUSTOM_LANG_LOCATION;

	private static string PREF_CUSTOM_LANG_SEND;

	private static string PREF_LANG_NEW;

	private static string PREF_USER_CHANGED;

	public const string CUSTOM_LANG_FILE = "_custom_lang_pack.csv";

	private static bool translateEnable_;

	private static List<TranslateCache> translateCacheTable_;

	[ThreadStatic]
	private static bool unuseResourceLanguage_;

	private static object lock_;

	private static bool initialized_;

	private static string JOYSTICK_EMULATION;

	private static string[][] forceTranslateTable_;

	private static bool forceTranslateEnable_;

	private static string[] HINDI_FROM;

	public static string[] HINDI_TO;

	private static int[] hindi_empty;

	private static bool hindi_empty_apply;

	private static Dictionary<string, ChanakyaCache> chanakyaCacheTable_;

	private static int chanakyaCacheCheckFrame_;

	private const int LANGUAGENEW_STATE_INIT = 0;

	private const int LANGUAGENEW_STATE_NONE = 1;

	private const int LANGUAGENEW_STATE_DISP = 2;

	private static int newState_;

	private static int newFrame_;

	public static bool TranslateEnable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal static bool InternalTranslateEnable { get; set; }

	internal static bool UseResourceLanguage
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal static bool UnicodeToChanakyaEnable { get; set; }

	public static void Init()
	{
	}

	private static void InitStaticFields()
	{
	}

	public static int Get()
	{
		return 0;
	}

	public static int Get(JLocale locale)
	{
		return 0;
	}

	public static bool Japanese()
	{
		return false;
	}

	public static bool JapanesePackage()
	{
		return false;
	}

	public static bool English()
	{
		return false;
	}

	public static Languages GetLanguage()
	{
		return Languages.Japanese;
	}

	public static bool IsJapaneseStyleCalendar()
	{
		return false;
	}

	public static bool IsWakachiStyle()
	{
		return false;
	}

	internal static bool IsJapaneseStyleTextLayout()
	{
		return false;
	}

	public static void SetSoftLabelTable(string[][] softlabelTable)
	{
	}

	public static void SetTextTable(string[][] textTable)
	{
	}

	internal static void ClearSoftLabelTable()
	{
	}

	internal static void ClearTextTable()
	{
	}

	private static string[][][] MakeTextTable(string[][] textTable)
	{
		return null;
	}

	private static string AdjustMacroScope(string src)
	{
		return null;
	}

	public static string TranslateSoftLabel(string softlabel)
	{
		return null;
	}

	public static string LT(string text, string arg = "")
	{
		return null;
	}

	public static string LT(string text, long arg)
	{
		return null;
	}

	public static string LT(string text, Exception e)
	{
		return null;
	}

	public static string TranslateText(string text, bool tabCheck = true)
	{
		return null;
	}

	private static string CallTranslateText(string text, bool tabCheck = true)
	{
		return null;
	}

	private static string _translateText(string text)
	{
		return null;
	}

	private static string _translateText2(string text)
	{
		return null;
	}

	public static string GetFolder(int language)
	{
		return null;
	}

	public static string GetFolder()
	{
		return null;
	}

	public static bool SetLanguagePack(string file, byte[] data = null, bool save = true)
	{
		return false;
	}

	public static string GetCustomLanguagePackLocation()
	{
		return null;
	}

	private static void LoadLanguagePack(byte[] data, byte[] partialData = null)
	{
	}

	internal static string[] GetLanguagePackFolders()
	{
		return null;
	}

	public static string[][] GetSystemLanguagePackFiles()
	{
		return null;
	}

	public static string GetLanguagePackFile()
	{
		return null;
	}

	public static string GetLanguageCode()
	{
		return null;
	}

	internal static byte[] ConvertLanguagePack(string file, byte[] data)
	{
		return null;
	}

	public static LanguagePackInfo GetLanguagePackInfo(byte[] data)
	{
		return null;
	}

	public static void MakeLangPackTemplate(bool japanese, int version, out string file, out string data)
	{
		file = null;
		data = null;
	}

	public static void MakeLangPackTemplate(bool japanese, int version, out string file, out string orgData, out string copyData, bool separate = true)
	{
		file = null;
		orgData = null;
		copyData = null;
	}

	private static Dictionary<string, List<LangPackRecord>> ReadTemplate(byte[] bin, out LangPackRecord[] records)
	{
		records = null;
		return null;
	}

	private static Dictionary<string, List<LangPackRecord>> ReadTemplate(string templateSource, out LangPackRecord[] records)
	{
		records = null;
		return null;
	}

	private static LangPackRecord[] ReadLangPackRecords(string langSource)
	{
		return null;
	}

	private static void OptimizeLanguagePack(string data, string templateSource, out string fileFooter, out string originalText, out string copyText, bool separate = true)
	{
		fileFooter = null;
		originalText = null;
		copyText = null;
	}

	private static string GetTitle(string code)
	{
		return null;
	}

	internal static LanguageConfig.Settings GetSettings()
	{
		return null;
	}

	public static bool IsLanguageSwitch()
	{
		return false;
	}

	public static bool IsLanguageCreate()
	{
		return false;
	}

	public static void RegistTranslateTable(ThreadStart method)
	{
	}

	public static void LoadTranslateTable()
	{
	}

	public static bool IsUSA()
	{
		return false;
	}

	private static string GetTranslateCache(string source, string args)
	{
		return null;
	}

	private static void SetTranslateCache(string source, string args, string result)
	{
	}

	internal static void RemoveExpiredTranslateCache(object sender, EventArgs e)
	{
	}

	private static bool TranslateBuiltInMultiLangText(string text, out string to)
	{
		to = null;
		return false;
	}

	internal static bool TranslateConsoleText(string text, out string to)
	{
		to = null;
		return false;
	}

	private static void MakeBuiltInMultiLangTable()
	{
	}

	public static void DrawDisplay_BUILTIN_TRANSLATE_TABLE(Graphics g, int viewW, int viewH, int frame)
	{
	}

	private static void StartForceTranslation()
	{
	}

	public static Dictionary<string, string> GetBuiltInLanguagePack(string code, bool jp = true)
	{
		return null;
	}

	public static string UnicodeToChanakya(string str)
	{
		return null;
	}

	private static string ReplaceOnce(string source, int begin, string find, string replace)
	{
		return null;
	}

	private static string conv(string str)
	{
		return null;
	}

	private static void CheckNewLanguage()
	{
	}

	private static void SetNewLanguageState(int state)
	{
	}

	public static void SaveNewLanguage()
	{
	}

	public static void DeleteNewLanguage()
	{
	}

	public static void DrawNewLanguage(Graphics g, int x, int y, int yFrame = -1, int sebFrame = -1)
	{
	}

	internal static bool IsJoystickEmulation()
	{
		return false;
	}

	internal static bool IsKeyboardEmulation()
	{
		return false;
	}

	internal static void ClearCache()
	{
	}

	public static bool IsShortWords()
	{
		return false;
	}
}
