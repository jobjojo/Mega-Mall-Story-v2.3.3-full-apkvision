using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[UsedByNativeCode]
[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
public static class AndroidJNIHelper
{
	public static bool debug
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static IntPtr GetConstructorID(IntPtr javaClass)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetConstructorID(IntPtr javaClass, [DefaultValue(null)] string signature)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetMethodID(IntPtr javaClass, string methodName)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue(null)] string signature)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue(null)] string signature, [DefaultValue("false")] bool isStatic)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue(null)] string signature)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue(null)] string signature, [DefaultValue("false")] bool isStatic)
	{
		return (IntPtr)0;
	}

	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
	{
		return (IntPtr)0;
	}

	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy)
	{
		return (IntPtr)0;
	}

	public static IntPtr ConvertToJNIArray(Array array)
	{
		return (IntPtr)0;
	}

	public static jvalue[] CreateJNIArgArray(object[] args)
	{
		return null;
	}

	public static void CreateJNIArgArray(object[] args, Span<jvalue> jniArgs)
	{
	}

	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs)
	{
	}

	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs)
	{
	}

	public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic)
	{
		return (IntPtr)0;
	}

	public static string GetSignature(object obj)
	{
		return null;
	}

	public static string GetSignature(object[] args)
	{
		return null;
	}

	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
	{
		return default;
	}

	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic)
	{
		return (IntPtr)0;
	}

	public static string GetSignature<ReturnType>(object[] args)
	{
		return null;
	}

	private static IntPtr Box(jvalue val, string boxedClass, string signature)
	{
		return (IntPtr)0;
	}

	public static IntPtr Box(sbyte value)
	{
		return (IntPtr)0;
	}

	public static IntPtr Box(short value)
	{
		return (IntPtr)0;
	}

	public static IntPtr Box(int value)
	{
		return (IntPtr)0;
	}

	public static IntPtr Box(long value)
	{
		return (IntPtr)0;
	}

	public static IntPtr Box(float value)
	{
		return (IntPtr)0;
	}

	public static IntPtr Box(double value)
	{
		return (IntPtr)0;
	}

	public static IntPtr Box(char value)
	{
		return (IntPtr)0;
	}

	public static IntPtr Box(bool value)
	{
		return (IntPtr)0;
	}

	private static IntPtr GetUnboxMethod(IntPtr obj, string methodName, string signature)
	{
		return (IntPtr)0;
	}

	public static void Unbox(IntPtr obj, out sbyte value)
	{
		value = default;
	}

	public static void Unbox(IntPtr obj, out short value)
	{
		value = default;
	}

	public static void Unbox(IntPtr obj, out int value)
	{
		value = default;
	}

	public static void Unbox(IntPtr obj, out long value)
	{
		value = default;
	}

	public static void Unbox(IntPtr obj, out float value)
	{
		value = default;
	}

	public static void Unbox(IntPtr obj, out double value)
	{
		value = default;
	}

	public static void Unbox(IntPtr obj, out char value)
	{
		value = default;
	}

	public static void Unbox(IntPtr obj, out bool value)
	{
		value = default;
	}
}
