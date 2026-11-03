using kairo.unity.type;

namespace kairo.unity.math;

public struct Hit
{
	private bool assign_ = false;

	public PointF CrossPoint { get; internal set; } = default;

	public float DeltaTime { get; internal set; } = 0f;

	public bool IsHit => false;

	public Hit(bool isHit)
	{
	}

	public Hit(PointF cross, float deltaTime = 1f)
	{
	}

	public Hit(float x, float y, float h, float deltaTime)
	{
	}

	public static explicit operator bool(Hit hit)
	{
		return false;
	}

	public static implicit operator Hit(bool hit)
	{
		return default;
	}

	public static bool operator true(Hit b)
	{
		return false;
	}

	public static bool operator false(Hit b)
	{
		return false;
	}

	public static bool operator !(Hit b)
	{
		return false;
	}
}
