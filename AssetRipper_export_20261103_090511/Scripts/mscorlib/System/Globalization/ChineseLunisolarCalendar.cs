using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
public class ChineseLunisolarCalendar : EastAsianLunisolarCalendar
{
	public const int ChineseEra = 1;

	internal const int MIN_LUNISOLAR_YEAR = 1901;

	internal const int MAX_LUNISOLAR_YEAR = 2100;

	internal const int MIN_GREGORIAN_YEAR = 1901;

	internal const int MIN_GREGORIAN_MONTH = 2;

	internal const int MIN_GREGORIAN_DAY = 19;

	internal const int MAX_GREGORIAN_YEAR = 2101;

	internal const int MAX_GREGORIAN_MONTH = 1;

	internal const int MAX_GREGORIAN_DAY = 28;

	internal static DateTime minDate;

	internal static DateTime maxDate;

	private static readonly int[,] yinfo;

	[ComVisible(false)]
	public override DateTime MinSupportedDateTime => default;

	[ComVisible(false)]
	public override DateTime MaxSupportedDateTime => default;

	protected override int DaysInYearBeforeMinSupportedYear => 0;

	internal override int MinCalendarYear => 0;

	internal override int MaxCalendarYear => 0;

	internal override DateTime MinDate => default;

	internal override DateTime MaxDate => default;

	internal override EraInfo[] CalEraInfo => null;

	internal override int ID => 0;

	internal override int BaseCalendarID => 0;

	[ComVisible(false)]
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

	[ComVisible(false)]
	public override int GetEra(DateTime time)
	{
		return 0;
	}
}
