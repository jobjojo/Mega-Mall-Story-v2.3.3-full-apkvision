using System;
using System.Collections.Generic;
using kairo.unity.graphics;
using kairo.unity.ui;

namespace kairo.unity.util;

public class Log
{
	public class MeshLog
	{
		public string Image;

		public float X;

		public float Y;

		public float Z;
	}

	protected static LogListener listener_;

	private static Dictionary<string, int> drawCallLog_;

	private static List<MeshLog> meshLog_;

	internal static bool IsLoggingDrawCall;

	internal static bool IsLoggingMesh;

	private const string PREF_LOG = "@PREF_LOG";

	private Log()
	{
	}

	public static void Print(string text)
	{
	}

	public static void Println(string text)
	{
	}

	public static string Info(string text, Exception t = null)
	{
		return null;
	}

	public static string Info(Exception t)
	{
		return null;
	}

	public static void Write(string text)
	{
	}

	public static string Read()
	{
		return null;
	}

	public static void Delete()
	{
	}

	public static string Error(string text, Exception t = null)
	{
		return null;
	}

	public static string Error(Exception t)
	{
		return null;
	}

	private static void DebugLog(Exception t)
	{
	}

	private static void DebugLog(string text)
	{
	}

	public static void SetListener(LogListener listener)
	{
	}

	protected static string GetThrowableName(Exception t)
	{
		return null;
	}

	protected static string GetThrowableLog(string text, Exception t)
	{
		return null;
	}

	public static void StartLogDrawCall()
	{
	}

	internal static Dictionary<string, int> EndLogDrawCall()
	{
		return null;
	}

	internal static void AddLogDrawCall(Image image, int count = 1)
	{
	}

	internal static void AddLogDrawCall(Material material, int count = 1)
	{
	}

	internal static void AddLogDrawCall(string name, int count = 1)
	{
	}

	public static void StartLogMesh()
	{
	}

	internal static void AddLogMesh(Image image, float x, float y, float z)
	{
	}

	internal static List<MeshLog> EndLogMesh()
	{
		return null;
	}
}
