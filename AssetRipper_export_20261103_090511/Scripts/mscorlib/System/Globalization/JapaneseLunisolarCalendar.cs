namespace System.Globalization;

[Serializable]
public class JapaneseLunisolarCalendar : EastAsianLunisolarCalendar
{
	public const int JapaneseEra = 1;

	internal GregorianCalendarHelper helper;

	internal const int MIN_LUNISOLAR_YEAR = 1960;

	internal const int MAX_LUNISOLAR_YEAR = 2049;

	internal const int MIN_GREGORIAN_YEAR = 1960;

	internal const int MIN_GREGORIAN_MONTH = 1;

	internal const int MIN_GREGORIAN_DAY = 28;

	internal const int MAX_GREGORIAN_YEAR = 2050;

	internal const int MAX_GREGORIAN_MONTH = 1;

	internal const int MAX_GREGORIAN_DAY = 22;

	internal static DateTime minDate;

	internal static DateTime maxDate;

	private static readonly int[,] yinfo;

	public override DateTime MinSupportedDateTime => default;

	public override DateTime MaxSupportedDateTime => default;

	protected override int DaysInYearBeforeMinSupportedYear => 0;

	internal override int MinCalendarYear => 0;

	internal override int MaxCalendarYear => 0;

	internal override DateTime MinDate => default;

	internal override DateTime MaxDate => default;

	internal override EraInfo[] CalEraInfo => null;

	internal override int BaseCalendarID => 0;

	internal override int ID => 0;

	public override int[] Eras => null;

	internal override int GetYearInfo(int LunarYear, int Index)
	{
		return 0;
	}

	internal override int GetYear(int year, DateTime time)
	{
		return 0;
	}

	internal override int GetGregorianYear(int year, int era)
	{
		return 0;
	}

	private static EraInfo[] TrimEras(EraInfo[] baseEras)
	{
		return null;
	}

	public override int GetEra(DateTime time)
	{
		return 0;
	}
}
