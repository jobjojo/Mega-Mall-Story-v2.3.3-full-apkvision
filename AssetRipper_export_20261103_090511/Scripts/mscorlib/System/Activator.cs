using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_Activator))]
public sealed class Activator
{
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
	{
		return null;
	}

	public static object CreateInstance(Type type, params object[] args)
	{
		return null;
	}

	public static object CreateInstance(Type type, object[] args, object[] activationAttributes)
	{
		return null;
	}

	public static object CreateInstance(Type type)
	{
		return null;
	}

	public static object CreateInstance(Type type, bool nonPublic)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CreateInstance(Type type, bool nonPublic, bool wrapExceptions)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T CreateInstance<T>()
	{
		return default;
	}
}
