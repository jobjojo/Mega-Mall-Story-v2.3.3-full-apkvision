using System;
using System.Reflection;

namespace kairo.unity.util;

public static class ReflectionUtil
{
	public static T Invoke<T>(string typeFullName, string methodName, object[] args = null)
	{
		return default;
	}

	public static T Invoke<T>(object obj, string methodName, object[] args = null)
	{
		return default;
	}

	public static void Invoke(string typeFullName, string methodName, object[] args = null)
	{
	}

	public static void Invoke(object obj, string methodName, object[] args = null)
	{
	}

	public static void SetValue(string typeFullName, string fieldName, object value)
	{
	}

	public static T GetValue<T>(string typeFullName, string fieldName)
	{
		return default;
	}

	public static void SetValue(object obj, string fieldName, object value)
	{
	}

	public static T GetValue<T>(object obj, string fieldName)
	{
		return default;
	}

	public static object GetEnum(string typeFullName, int value)
	{
		return null;
	}

	private static FieldInfo GetField(string typeFullName, string fieldName)
	{
		return null;
	}

	private static FieldInfo GetField(Type type, string fieldName)
	{
		return null;
	}

	private static PropertyInfo GetProperty(string typeFullName, string propertyName)
	{
		return null;
	}

	private static PropertyInfo GetProperty(Type type, string propertyName)
	{
		return null;
	}

	private static MethodInfo GetMethod(string typeFullName, string methodName, object[] args)
	{
		return null;
	}

	private static MethodInfo GetMethod(Type type, string methodName, object[] args)
	{
		return null;
	}

	private static Type GetType(string typeFullName)
	{
		return null;
	}

	private static Assembly GetAssembly(string typeFullName)
	{
		return null;
	}
}
