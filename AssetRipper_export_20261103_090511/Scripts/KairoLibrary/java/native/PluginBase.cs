using UnityEngine;

namespace java.native;

public static class PluginBase
{
	public static void CallStatic(AndroidJavaClass javaClass, string methodName, params object[] args)
	{
	}

	public static void Call(AndroidJavaObject javaObject, string methodName, params object[] args)
	{
	}

	public static T CallStatic<T>(AndroidJavaClass javaClass, string methodName, params object[] args)
	{
		return default;
	}

	public static T Call<T>(AndroidJavaObject javaObject, string methodName, params object[] args)
	{
		return default;
	}

	public static T GetStatic<T>(AndroidJavaClass javaClass, string fieldName)
	{
		return default;
	}

	public static T Get<T>(AndroidJavaObject javaObject, string fieldName)
	{
		return default;
	}
}
