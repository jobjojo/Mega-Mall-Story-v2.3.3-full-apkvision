using System.Runtime.CompilerServices;

namespace System.Threading;

public static class Volatile
{
	private struct VolatileObject
	{
		public object Value;
	}

	[Intrinsic]
	public static T Read<T>(ref T location) where T : class
	{
		return null;
	}

	[Intrinsic]
	public static void Write<T>(ref T location, T value) where T : class
	{
	}
}
