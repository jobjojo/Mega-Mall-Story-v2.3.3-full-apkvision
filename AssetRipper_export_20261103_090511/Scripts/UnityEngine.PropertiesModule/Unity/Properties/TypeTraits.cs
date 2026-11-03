using System;
using System.Diagnostics;

namespace Unity.Properties;

public static class TypeTraits
{
	public static bool IsContainer(Type type)
	{
		return false;
	}
}
public static class TypeTraits<T>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static readonly bool IsMultidimensionalArray;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static readonly bool IsEnumFlags;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static readonly bool IsPrimitiveOrString;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static readonly bool IsUnityObject;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static readonly bool IsLazyLoadReference;

	public static bool IsValueType { get; }

	public static bool IsPrimitive { get; }

	public static bool IsInterface { get; }

	public static bool IsAbstract { get; }

	public static bool IsArray { get; }

	public static bool IsEnum { get; }

	public static bool IsNullable { get; }

	public static bool IsObject { get; }

	public static bool IsString { get; }

	public static bool IsContainer { get; }

	public static bool CanBeNull { get; }

	public static bool IsAbstractOrInterface { get; }

	static TypeTraits()
	{
	}
}
