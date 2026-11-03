namespace kairo.unity.surface;

public struct TouchValue
{
	public int Value = 0;

	public bool Active = false;

	public static TouchValue Empty;

	public static bool operator true(TouchValue b)
	{
		return false;
	}

	public static bool operator false(TouchValue b)
	{
		return false;
	}

	public TouchValue(int value)
	{
	}

	public TouchValue(bool value)
	{
	}

	public static implicit operator int(TouchValue value)
	{
		return 0;
	}

	public static implicit operator TouchValue(int value)
	{
		return default;
	}

	public static implicit operator TouchValue(bool value)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}
}
