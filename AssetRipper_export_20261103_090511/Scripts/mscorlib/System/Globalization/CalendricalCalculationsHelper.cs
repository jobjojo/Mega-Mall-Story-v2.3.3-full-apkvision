namespace System.Globalization;

internal class CalendricalCalculationsHelper
{
	private enum CorrectionAlgorithm
	{
		Default = 0,
		Year1988to2019 = 1,
		Year1900to1987 = 2,
		Year1800to1899 = 3,
		Year1700to1799 = 4,
		Year1620to1699 = 5
	}

	private struct EphemerisCorrectionAlgorithmMap(int year, CorrectionAlgorithm algorithm)
	{
		internal int _lowestYear = 0;

		internal CorrectionAlgorithm _algorithm = CorrectionAlgorithm.Default;
	}

	private const double FullCircleOfArc = 360.0;

	private const int HalfCircleOfArc = 180;

	private const double TwelveHours = 0.5;

	private const double Noon2000Jan01 = 730120.5;

	internal const double MeanTropicalYearInDays = 365.242189;

	private const double MeanSpeedOfSun = 1.0145616361111112;

	private const double LongitudeSpring = 0.0;

	private const double TwoDegreesAfterSpring = 2.0;

	private const int SecondsPerDay = 86400;

	private const int DaysInUniformLengthCentury = 36525;

	private const int SecondsPerMinute = 60;

	private const int MinutesPerDegree = 60;

	private static long StartOf1810;

	private static long StartOf1900Century;

	private static double[] Coefficients1900to1987;

	private static double[] Coefficients1800to1899;

	private static double[] Coefficients1700to1799;

	private static double[] Coefficients1620to1699;

	private static double[] LambdaCoefficients;

	private static double[] AnomalyCoefficients;

	private static double[] EccentricityCoefficients;

	private static double[] Coefficients;

	private static double[] CoefficientsA;

	private static double[] CoefficientsB;

	private static EphemerisCorrectionAlgorithmMap[] EphemerisCorrectionTable;

	private static double RadiansFromDegrees(double degree)
	{
		return 0.0;
	}

	private static double SinOfDegree(double degree)
	{
		return 0.0;
	}

	private static double CosOfDegree(double degree)
	{
		return 0.0;
	}

	private static double TanOfDegree(double degree)
	{
		return 0.0;
	}

	public static double Angle(int degrees, int minutes, double seconds)
	{
		return 0.0;
	}

	private static double Obliquity(double julianCenturies)
	{
		return 0.0;
	}

	internal static long GetNumberOfDays(DateTime date)
	{
		return 0L;
	}

	private static int GetGregorianYear(double numberOfDays)
	{
		return 0;
	}

	private static double Reminder(double divisor, double dividend)
	{
		return 0.0;
	}

	private static double NormalizeLongitude(double longitude)
	{
		return 0.0;
	}

	public static double AsDayFraction(double longitude)
	{
		return 0.0;
	}

	private static double PolynomialSum(double[] coefficients, double indeterminate)
	{
		return 0.0;
	}

	private static double CenturiesFrom1900(int gregorianYear)
	{
		return 0.0;
	}

	private static double DefaultEphemerisCorrection(int gregorianYear)
	{
		return 0.0;
	}

	private static double EphemerisCorrection1988to2019(int gregorianYear)
	{
		return 0.0;
	}

	private static double EphemerisCorrection1900to1987(int gregorianYear)
	{
		return 0.0;
	}

	private static double EphemerisCorrection1800to1899(int gregorianYear)
	{
		return 0.0;
	}

	private static double EphemerisCorrection1700to1799(int gregorianYear)
	{
		return 0.0;
	}

	private static double EphemerisCorrection1620to1699(int gregorianYear)
	{
		return 0.0;
	}

	private static double EphemerisCorrection(double time)
	{
		return 0.0;
	}

	public static double JulianCenturies(double moment)
	{
		return 0.0;
	}

	private static bool IsNegative(double value)
	{
		return false;
	}

	private static double CopySign(double value, double sign)
	{
		return 0.0;
	}

	private static double EquationOfTime(double time)
	{
		return 0.0;
	}

	private static double AsLocalTime(double apparentMidday, double longitude)
	{
		return 0.0;
	}

	public static double Midday(double date, double longitude)
	{
		return 0.0;
	}

	private static double InitLongitude(double longitude)
	{
		return 0.0;
	}

	public static double MiddayAtPersianObservationSite(double date)
	{
		return 0.0;
	}

	private static double PeriodicTerm(double julianCenturies, int x, double y, double z)
	{
		return 0.0;
	}

	private static double SumLongSequenceOfPeriodicTerms(double julianCenturies)
	{
		return 0.0;
	}

	private static double Aberration(double julianCenturies)
	{
		return 0.0;
	}

	private static double Nutation(double julianCenturies)
	{
		return 0.0;
	}

	public static double Compute(double time)
	{
		return 0.0;
	}

	public static double AsSeason(double longitude)
	{
		return 0.0;
	}

	private static double EstimatePrior(double longitude, double time)
	{
		return 0.0;
	}

	internal static long PersianNewYearOnOrBefore(long numberOfDays)
	{
		return 0L;
	}
}
