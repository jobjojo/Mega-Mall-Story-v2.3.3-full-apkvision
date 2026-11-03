using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
public static class Random
{
	public static int Range(int minInclusive, int maxExclusive)
	{
		return 0;
	}

	[FreeFunction]
	private static int RandomRangeInt(int minInclusive, int maxExclusive)
	{
		return 0;
	}
}
