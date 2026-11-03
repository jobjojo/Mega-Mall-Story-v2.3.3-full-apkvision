using System;
using System.Collections.Generic;
using System.Reflection;

namespace kairo.unity.util;

public class FieldInitializer
{
	private class Data
	{
		public string name_;

		public Type type_;

		public object value_;

		public Data(FieldInfo fi, object value)
		{
		}
	}

	private static bool backupAssembly_;

	private static Dictionary<Type, Data[]> staticFields_;

	private static Dictionary<object, Data[]> instanceFields_;

	public static void Execute(object obj)
	{
	}

	public static void Execute(Type type)
	{
	}

	public static void ExecuteAll()
	{
	}

	public static void BackupFields(object obj)
	{
	}

	public static void BackupFields(Type type)
	{
	}

	public static void BackupAllFields()
	{
	}

	private static Data[] backupFields(Type type, object obj)
	{
		return null;
	}

	public static void RestoreFields(object obj)
	{
	}

	public static void RestoreFields(Type type)
	{
	}

	public static void RestoreAllFields()
	{
	}

	private static void restoreFields(Type type, object obj, Data[] dataList)
	{
	}

	public static bool IsBackupFields(object obj)
	{
		return false;
	}

	public static bool IsBackupFields(Type type)
	{
		return false;
	}

	public static bool IsBackupAllFields()
	{
		return false;
	}

	private static Data MakeValue(FieldInfo fi, object obj = null)
	{
		return null;
	}

	private static void Restore(FieldInfo fi, Data value, object obj = null)
	{
	}

	private static bool Compare(FieldInfo fi, Data value, object obj = null)
	{
		return false;
	}
}
