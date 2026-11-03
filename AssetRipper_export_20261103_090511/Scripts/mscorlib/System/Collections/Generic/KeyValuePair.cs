namespace System.Collections.Generic;

public static class KeyValuePair
{
	internal static string PairToString(object key, object value)
	{
		return null;
	}
}
[Serializable]
public readonly struct KeyValuePair<TKey, TValue>(TKey key, TValue value)
{
	private readonly TKey key = default;

	private readonly TValue value = default;

	public TKey Key => default;

	public TValue Value => default;

	public override string ToString()
	{
		return null;
	}
}
