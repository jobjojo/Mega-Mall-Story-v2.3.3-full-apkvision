using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mono.Interop;

namespace System.Globalization;

[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class CultureInfo : ICloneable, IFormatProvider
{
	private struct Data
	{
		public int ansi;

		public int ebcdic;

		public int mac;

		public int oem;

		public bool right_to_left;

		public byte list_sep;
	}

	private delegate void OnCultureInfoChangedDelegate(string language);

	private static CultureInfo invariant_culture_info;

	private static object shared_table_lock;

	private static CultureInfo default_current_culture;

	private bool m_isReadOnly;

	private int cultureID;

	[NonSerialized]
	private int parent_lcid;

	[NonSerialized]
	private int datetime_index;

	[NonSerialized]
	private int number_index;

	[NonSerialized]
	private int default_calendar_type;

	private bool m_useUserOverride;

	internal NumberFormatInfo numInfo;

	internal DateTimeFormatInfo dateTimeInfo;

	private TextInfo textInfo;

	internal string m_name;

	[NonSerialized]
	private string englishname;

	[NonSerialized]
	private string nativename;

	[NonSerialized]
	private string iso3lang;

	[NonSerialized]
	private string iso2lang;

	[NonSerialized]
	private string win3lang;

	[NonSerialized]
	private string territory;

	[NonSerialized]
	private string[] native_calendar_names;

	private CompareInfo compareInfo;

	[NonSerialized]
	private unsafe readonly void* textinfo_data;

	private int m_dataItem;

	private Calendar calendar;

	[NonSerialized]
	private CultureInfo parent_culture;

	[NonSerialized]
	private bool constructed;

	[NonSerialized]
	internal byte[] cached_serialized_form;

	[NonSerialized]
	internal CultureData m_cultureData;

	[NonSerialized]
	internal bool m_isInherited;

	internal const int InvariantCultureId = 127;

	private const int CalendarTypeBits = 8;

	internal const int LOCALE_INVARIANT = 127;

	private const string MSG_READONLY = "This instance is read only";

	private static CultureInfo s_DefaultThreadCurrentUICulture;

	private static CultureInfo s_DefaultThreadCurrentCulture;

	private static Dictionary<int, CultureInfo> shared_by_number;

	private static Dictionary<string, CultureInfo> shared_by_name;

	private static CultureInfo s_UserPreferredCultureInfoInAppX;

	internal static readonly bool IsTaiwanSku;

	internal CultureData _cultureData => null;

	internal bool _isInherited => false;

	public static CultureInfo InvariantCulture => null;

	public static CultureInfo CurrentCulture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static CultureInfo CurrentUICulture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string Territory => null;

	internal string _name => null;

	[ComVisible(false)]
	public CultureTypes CultureTypes => (CultureTypes)0;

	[ComVisible(false)]
	public string IetfLanguageTag => null;

	[ComVisible(false)]
	public virtual int KeyboardLayoutId => 0;

	public virtual int LCID => 0;

	public virtual string Name => null;

	public virtual string NativeName => null;

	internal string NativeCalendarName => null;

	public virtual Calendar Calendar => null;

	[MonoLimitation("Optional calendars are not supported only default calendar is returned")]
	public virtual Calendar[] OptionalCalendars => null;

	public virtual CultureInfo Parent => null;

	public virtual TextInfo TextInfo => null;

	public virtual string ThreeLetterISOLanguageName => null;

	public virtual string ThreeLetterWindowsLanguageName => null;

	public virtual string TwoLetterISOLanguageName => null;

	public bool UseUserOverride => false;

	public virtual CompareInfo CompareInfo => null;

	public virtual bool IsNeutralCulture => false;

	public virtual NumberFormatInfo NumberFormat
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual DateTimeFormatInfo DateTimeFormat
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string DisplayName => null;

	public virtual string EnglishName => null;

	public static CultureInfo InstalledUICulture => null;

	public bool IsReadOnly => false;

	internal int CalendarType => 0;

	public static CultureInfo DefaultThreadCurrentCulture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static CultureInfo DefaultThreadCurrentUICulture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string SortName => null;

	internal static CultureInfo UserDefaultUICulture => null;

	internal static CultureInfo UserDefaultCulture => null;

	internal bool HasInvariantCultureName => false;

	internal static CultureInfo ConstructCurrentCulture()
	{
		return null;
	}

	internal static CultureInfo ConstructCurrentUICulture()
	{
		return null;
	}

	[ComVisible(false)]
	public CultureInfo GetConsoleFallbackUICulture()
	{
		return null;
	}

	public void ClearCachedData()
	{
	}

	public virtual object Clone()
	{
		return null;
	}

	public override bool Equals(object value)
	{
		return false;
	}

	public static CultureInfo[] GetCultures(CultureTypes types)
	{
		return null;
	}

	private Data GetTextInfoData()
	{
		return default;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static CultureInfo ReadOnly(CultureInfo ci)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private void CheckNeutral()
	{
	}

	public virtual object GetFormat(Type formatType)
	{
		return null;
	}

	private void Construct()
	{
	}

	private bool construct_internal_locale_from_lcid(int lcid)
	{
		return false;
	}

	private bool construct_internal_locale_from_name(string name)
	{
		return false;
	}

	private static string get_current_locale_name()
	{
		return null;
	}

	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed)
	{
		return null;
	}

	private void ConstructInvariant(bool read_only)
	{
	}

	private TextInfo CreateTextInfo(bool readOnly)
	{
		return null;
	}

	public CultureInfo(int culture)
	{
	}

	public CultureInfo(int culture, bool useUserOverride)
	{
	}

	private CultureInfo(int culture, bool useUserOverride, bool read_only)
	{
	}

	public CultureInfo(string name)
	{
	}

	public CultureInfo(string name, bool useUserOverride)
	{
	}

	private CultureInfo(string name, bool useUserOverride, bool read_only)
	{
	}

	private CultureInfo()
	{
	}

	private static void insert_into_shared_tables(CultureInfo c)
	{
	}

	public static CultureInfo GetCultureInfo(int culture)
	{
		return null;
	}

	public static CultureInfo GetCultureInfo(string name)
	{
		return null;
	}

	[MonoTODO("Currently it ignores the altName parameter")]
	public static CultureInfo GetCultureInfo(string name, string altName)
	{
		return null;
	}

	public static CultureInfo GetCultureInfoByIetfLanguageTag(string name)
	{
		return null;
	}

	internal static CultureInfo CreateCulture(string name, bool reference)
	{
		return null;
	}

	public static CultureInfo CreateSpecificCulture(string name)
	{
		return null;
	}

	private bool ConstructLocaleFromName(string name)
	{
		return false;
	}

	private static CultureInfo CreateSpecificCultureFromNeutral(string name)
	{
		return null;
	}

	private static Calendar CreateCalendar(int calendarType)
	{
		return null;
	}

	private static Exception CreateNotFoundException(string name)
	{
		return null;
	}

	[PreserveSig]
	private static extern void InitializeUserPreferredCultureInfoInAppX(OnCultureInfoChangedDelegate onCultureInfoChangedInAppX);

	[PreserveSig]
	private static extern void SetUserPreferredCultureInfoInAppX(string name);

	[MonoPInvokeCallback(typeof(OnCultureInfoChangedDelegate))]
	private static void OnCultureInfoChangedInAppX(string language)
	{
	}

	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
	{
		return null;
	}

	internal static void SetCultureInfoForUserPreferredLanguageInAppX(CultureInfo cultureInfo)
	{
	}

	internal static void CheckDomainSafetyObject(object obj, object container)
	{
	}

	internal static bool VerifyCultureName(string cultureName, bool throwException)
	{
		return false;
	}

	internal static bool VerifyCultureName(CultureInfo culture, bool throwException)
	{
		return false;
	}
}
