namespace java.util;

public class JLocale
{
	public static readonly JLocale CANADA;

	public static readonly JLocale CANADA_FRENCH;

	public static readonly JLocale CHINA;

	public static readonly JLocale CHINESE;

	public static readonly JLocale ENGLISH;

	public static readonly JLocale FRANCE;

	public static readonly JLocale FRENCH;

	public static readonly JLocale GERMAN;

	public static readonly JLocale GERMANY;

	public static readonly JLocale ITALIAN;

	public static readonly JLocale ITALY;

	public static readonly JLocale JAPAN;

	public static readonly JLocale JAPANESE;

	public static readonly JLocale KOREA;

	public static readonly JLocale KOREAN;

	public static readonly JLocale PRC;

	public static readonly JLocale ROOT;

	public static readonly JLocale SIMPLIFIED_CHINESE;

	public static readonly JLocale TAIWAN;

	public static readonly JLocale TRADITIONAL_CHINESE;

	public static readonly JLocale UK;

	public static readonly JLocale US;

	private static JLocale defaultLocale;

	private string language_;

	private string country_;

	public static bool operator ==(JLocale obj1, JLocale obj2)
	{
		return false;
	}

	public static bool operator !=(JLocale obj1, JLocale obj2)
	{
		return false;
	}

	protected JLocale(string language)
	{
	}

	protected JLocale(string language, string country)
	{
	}

	public static JLocale GetDefault()
	{
		return null;
	}

	public string GetLanguage()
	{
		return null;
	}

	public string GetCountry()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
