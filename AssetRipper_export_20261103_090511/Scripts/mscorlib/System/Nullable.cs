using System.Runtime.Versioning;

namespace System;

[Serializable]
[NonVersionable]
public struct Nullable<T>(T value) where T : struct
{
	private readonly bool hasValue = false;

	internal T value = default;

	public bool HasValue
	{
		[NonVersionable]
		get
		{
			return false;
		}
	}

	public T Value => default;

	[NonVersionable]
	public T GetValueOrDefault()
	{
		return default;
	}

	[NonVersionable]
	public T GetValueOrDefault(T defaultValue)
	{
		return default;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	private static object Box(T? o)
	{
		return null;
	}

	private static T? Unbox(object o)
	{
		return null;
	}

	private static T? UnboxExact(object o)
	{
		return null;
	}
}
public static class Nullable
{
	public static Type GetUnderlyingType(Type nullableType)
	{
		return null;
	}
}
