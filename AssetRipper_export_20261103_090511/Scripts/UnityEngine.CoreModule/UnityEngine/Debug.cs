using System;
using System.Diagnostics;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
public class Debug
{
	internal static readonly ILogger s_DefaultLogger;

	internal static ILogger s_Logger;

	public static ILogger unityLogger => null;

	public static bool isDebugBuild => false;

	[ThreadSafe]
	public unsafe static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
	{
		return 0;
	}

	public static void Log(object message)
	{
	}

	public static void LogError(object message)
	{
	}

	public static void LogError(object message, Object context)
	{
	}

	public static void LogException(Exception exception)
	{
	}

	public static void LogException(Exception exception, Object context)
	{
	}

	public static void LogWarning(object message)
	{
	}

	public static void LogWarning(object message, Object context)
	{
	}

	[Conditional("UNITY_ASSERTIONS")]
	public static void Assert(bool condition)
	{
	}

	[RequiredByNativeCode]
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj)
	{
		return false;
	}

	[RequiredByNativeCode]
	internal static bool IsLoggingEnabled()
	{
		return false;
	}
}
