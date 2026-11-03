using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class RegionInfo
{
	private static RegionInfo currentRegion;

	private int regionId;

	private string iso2Name;

	private string iso3Name;

	private string win3Name;

	private string englishName;

	private string nativeName;

	private string currencySymbol;

	private string isoCurrencySymbol;

	private string currencyEnglishName;

	private string currencyNativeName;

	public static RegionInfo CurrentRegion => null;

	[ComVisible(false)]
	public virtual string CurrencyEnglishName => null;

	public virtual string CurrencySymbol => null;

	[MonoTODO("DisplayName currently only returns the EnglishName")]
	public virtual string DisplayName => null;

	public virtual string EnglishName => null;

	[ComVisible(false)]
	public virtual int GeoId => 0;

	public virtual bool IsMetric => false;

	public virtual string ISOCurrencySymbol => null;

	[ComVisible(false)]
	public virtual string NativeName => null;

	[ComVisible(false)]
	public virtual string CurrencyNativeName => null;

	public virtual string Name => null;

	public virtual string ThreeLetterISORegionName => null;

	public virtual string ThreeLetterWindowsRegionName => null;

	public virtual string TwoLetterISORegionName => null;

	public RegionInfo(int culture)
	{
	}

	public RegionInfo(string name)
	{
	}

	private RegionInfo(CultureInfo ci)
	{
	}

	private bool GetByTerritory(CultureInfo ci)
	{
		return false;
	}

	private bool construct_internal_region_from_name(string name)
	{
		return false;
	}

	public override bool Equals(object value)
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

	internal static void ClearCachedData()
	{
	}
}
