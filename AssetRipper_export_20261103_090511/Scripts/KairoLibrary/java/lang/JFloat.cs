namespace java.lang;

public class JFloat
{
	private float value_;

	public const float MAX_VALUE = float.MaxValue;

	public const float MIN_VALUE = float.MinValue;

	public const float NaN = float.NaN;

	public const float NEGATIVE_INFINITY = float.NegativeInfinity;

	public const float POSITIVE_INFINITY = float.PositiveInfinity;

	public static implicit operator float(JFloat s)
	{
		return 0f;
	}

	public static implicit operator JFloat(float s)
	{
		return null;
	}

	public JFloat(float value)
	{
	}

	public JFloat(double value)
	{
	}

	public float FloatValue()
	{
		return 0f;
	}

	public static JFloat ValueOf(string s)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public static string ToString(float f)
	{
		return null;
	}

	public static float ParseFloat(string s)
	{
		return 0f;
	}

	public bool IsInfinite()
	{
		return false;
	}

	public static bool IsInfinite(float v)
	{
		return false;
	}

	public bool IsNaN()
	{
		return false;
	}

	public static bool IsNaN(float v)
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
