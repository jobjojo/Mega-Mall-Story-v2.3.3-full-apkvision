namespace java.lang;

public class JDouble
{
	private double value_;

	public const double MAX_VALUE = double.MaxValue;

	public const double MIN_VALUE = double.MinValue;

	public const double NaN = double.NaN;

	public const double NEGATIVE_INFINITY = double.NegativeInfinity;

	public const double POSITIVE_INFINITY = double.PositiveInfinity;

	public static implicit operator double(JDouble s)
	{
		return 0.0;
	}

	public static implicit operator JDouble(double s)
	{
		return null;
	}

	public JDouble(double value)
	{
	}

	public double DoubleValue()
	{
		return 0.0;
	}

	public static JDouble ValueOf(string s)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public static string ToString(double d)
	{
		return null;
	}

	public static double ParseDouble(string s)
	{
		return 0.0;
	}

	public bool IsInfinite()
	{
		return false;
	}

	public static bool IsInfinite(double v)
	{
		return false;
	}

	public bool IsNaN()
	{
		return false;
	}

	public static bool IsNaN(double v)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
