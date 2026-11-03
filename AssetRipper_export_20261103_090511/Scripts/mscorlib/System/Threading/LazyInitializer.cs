namespace System.Threading;

public static class LazyInitializer
{
	public static T EnsureInitialized<T>(ref T target) where T : class
	{
		return null;
	}

	private static T EnsureInitializedCore<T>(ref T target) where T : class
	{
		return null;
	}

	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) where T : class
	{
		return null;
	}

	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) where T : class
	{
		return null;
	}
}
