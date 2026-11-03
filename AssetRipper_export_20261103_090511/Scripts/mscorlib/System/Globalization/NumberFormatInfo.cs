using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider
{
	private static NumberFormatInfo invariantInfo;

	internal int[] numberGroupSizes;

	internal int[] currencyGroupSizes;

	internal int[] percentGroupSizes;

	internal string positiveSign;

	internal string negativeSign;

	internal string numberDecimalSeparator;

	internal string numberGroupSeparator;

	internal string currencyGroupSeparator;

	internal string currencyDecimalSeparator;

	internal string currencySymbol;

	internal string ansiCurrencySymbol;

	internal string nanSymbol;

	internal string positiveInfinitySymbol;

	internal string negativeInfinitySymbol;

	internal string percentDecimalSeparator;

	internal string percentGroupSeparator;

	internal string percentSymbol;

	internal string perMilleSymbol;

	[OptionalField(VersionAdded = 2)]
	internal string[] nativeDigits;

	[OptionalField(VersionAdded = 1)]
	internal int m_dataItem;

	internal int numberDecimalDigits;

	internal int currencyDecimalDigits;

	internal int currencyPositivePattern;

	internal int currencyNegativePattern;

	internal int numberNegativePattern;

	internal int percentPositivePattern;

	internal int percentNegativePattern;

	internal int percentDecimalDigits;

	[OptionalField(VersionAdded = 2)]
	internal int digitSubstitution;

	internal bool isReadOnly;

	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride;

	[OptionalField(VersionAdded = 2)]
	internal bool m_isInvariant;

	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsNumber;

	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsCurrency;

	private const NumberStyles InvalidNumberStyles = ~(NumberStyles.Any | NumberStyles.AllowHexSpecifier);

	public static NumberFormatInfo InvariantInfo => null;

	public int CurrencyDecimalDigits
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string CurrencyDecimalSeparator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsReadOnly => false;

	public int[] CurrencyGroupSizes
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int[] NumberGroupSizes
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int[] PercentGroupSizes
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string CurrencyGroupSeparator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string CurrencySymbol
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static NumberFormatInfo CurrentInfo => null;

	public string NaNSymbol
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int CurrencyNegativePattern
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int NumberNegativePattern
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int PercentPositivePattern
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int PercentNegativePattern
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string NegativeInfinitySymbol
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string NegativeSign
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int NumberDecimalDigits
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string NumberDecimalSeparator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string NumberGroupSeparator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int CurrencyPositivePattern
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string PositiveInfinitySymbol
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string PositiveSign
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int PercentDecimalDigits
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string PercentDecimalSeparator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string PercentGroupSeparator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string PercentSymbol
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string PerMilleSymbol
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[ComVisible(false)]
	public string[] NativeDigits
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[ComVisible(false)]
	public DigitShapes DigitSubstitution
	{
		get
		{
			return DigitShapes.Context;
		}
		set
		{
		}
	}

	public NumberFormatInfo()
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	private static void VerifyDecimalSeparator(string decSep, string propertyName)
	{
	}

	private static void VerifyGroupSeparator(string groupSep, string propertyName)
	{
	}

	private static void VerifyNativeDigits(string[] nativeDig, string propertyName)
	{
	}

	private static void VerifyDigitSubstitution(DigitShapes digitSub, string propertyName)
	{
	}

	internal NumberFormatInfo(CultureData cultureData)
	{
	}

	private void VerifyWritable()
	{
	}

	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider)
	{
		return null;
	}

	public object Clone()
	{
		return null;
	}

	internal static void CheckGroupSize(string propName, int[] groupSize)
	{
	}

	public object GetFormat(Type formatType)
	{
		return null;
	}

	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
	{
		return null;
	}

	internal static void ValidateParseStyleInteger(NumberStyles style)
	{
	}

	internal static void ValidateParseStyleFloatingPoint(NumberStyles style)
	{
	}
}
