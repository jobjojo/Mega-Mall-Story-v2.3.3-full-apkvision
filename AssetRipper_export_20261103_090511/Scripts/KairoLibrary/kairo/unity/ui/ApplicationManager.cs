using System;
using System.Collections.Generic;
using System.Reflection;
using kairo.unity.plugin;
using kairo.unity.util;

namespace kairo.unity.ui;

public class ApplicationManager
{
	private class AssemblyData
	{
		public class TypeData
		{
			public string Name;

			public Dictionary<string, object> Fields;

			public TypeData(Type type)
			{
			}
		}

		public string Name;

		public Dictionary<string, TypeData> Types;

		public AssemblyData(Assembly assembly)
		{
		}
	}

	private static Type firstEntry_;

	private static Assembly currentAssembly_;

	private static string currentAssemblyName_;

	private static int bootArg_;

	private static BootFlags bootFlag_;

	private static IRootPlugin rootPlugin_;

	private static string rootFolderBackup_;

	private static Dictionary<string, SecureByteArray> encryptionKeyTable_;

	private static Dictionary<string, AssemblyData> assemblyTable_;

	public static bool IsRootApplication => false;

	public static Assembly Current => null;

	public static string currentAssemblyName => null;

	public static int BootArg => 0;

	public static BootFlags BootFlag => (BootFlags)0;

	static ApplicationManager()
	{
	}

	public static bool CheckBackupedStaticFields(Assembly asm = null)
	{
		return false;
	}

	internal static void BackupStaticFields(Assembly asm = null)
	{
	}

	internal static void RestoreStaticFields(Assembly asm = null)
	{
	}

	private static object CopyValue(object o)
	{
		return null;
	}

	public static void RegisterEncryptionKey(string assemblyName)
	{
	}

	public static void RegisterEncryptionKey(string assemblyName, SecureByteArray key)
	{
	}

	public static SecureByteArray GetEncryptionKey(string assemblyName)
	{
		return null;
	}

	public static string SearchKeyAssembly(SecureByteArray key)
	{
		return null;
	}

	public static void Boot(string assemblyName, BootFlags bootFlags = BootFlags.Default)
	{
	}

	public static void Boot(string assemblyName, int arg, BootFlags bootFlags = BootFlags.Default)
	{
	}

	public static Dictionary<string, object> GetGamePlayData(string assemblyName, params string[] args)
	{
		return null;
	}

	public static byte[] ReadSystemRecord(string assemblyName)
	{
		return null;
	}

	public static void WriteSystemRecord(string assemblyName, byte[] data)
	{
	}

	private static IContainerPlugin BeginContainerPlugin(string assemblyName)
	{
		return null;
	}

	private static void EndAssemblyCall()
	{
	}

	private static IContainerPlugin GetContainerPlugin(string assemblyName)
	{
		return null;
	}

	public static T InvokeRootPlugin<T>(Func<IRootPlugin, T> func)
	{
		return default;
	}

	private static IRootPlugin GetRootPlugin()
	{
		return null;
	}

	private static void ReleaseAllResource()
	{
	}

	public static void ResetBootFlag()
	{
	}
}
