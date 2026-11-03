using System;

namespace UnityEngine;

public class AndroidJavaObject : IDisposable
{
	private static bool enableDebugPrints;

	internal GlobalJavaObjectRef m_jobject;

	internal GlobalJavaObjectRef m_jclass;

	public AndroidJavaObject(string className, string[] args)
	{
	}

	public AndroidJavaObject(string className, AndroidJavaObject[] args)
	{
	}

	public AndroidJavaObject(string className, AndroidJavaClass[] args)
	{
	}

	public AndroidJavaObject(string className, AndroidJavaProxy[] args)
	{
	}

	public AndroidJavaObject(string className, AndroidJavaRunnable[] args)
	{
	}

	public AndroidJavaObject(string className, params object[] args)
	{
	}

	public AndroidJavaObject(IntPtr jobject)
	{
	}

	public AndroidJavaObject(IntPtr clazz, IntPtr constructorID, params object[] args)
	{
	}

	public void Dispose()
	{
	}

	public void Call<T>(string methodName, T[] args)
	{
	}

	public void Call<T>(IntPtr methodID, T[] args)
	{
	}

	public void Call(string methodName, params object[] args)
	{
	}

	public void Call(IntPtr methodID, params object[] args)
	{
	}

	public void CallStatic<T>(string methodName, T[] args)
	{
	}

	public void CallStatic<T>(IntPtr methodID, T[] args)
	{
	}

	public void CallStatic(string methodName, params object[] args)
	{
	}

	public void CallStatic(IntPtr methodID, params object[] args)
	{
	}

	public FieldType Get<FieldType>(string fieldName)
	{
		return default;
	}

	public FieldType Get<FieldType>(IntPtr fieldID)
	{
		return default;
	}

	public void Set<FieldType>(string fieldName, FieldType val)
	{
	}

	public void Set<FieldType>(IntPtr fieldID, FieldType val)
	{
	}

	public FieldType GetStatic<FieldType>(string fieldName)
	{
		return default;
	}

	public FieldType GetStatic<FieldType>(IntPtr fieldID)
	{
		return default;
	}

	public void SetStatic<FieldType>(string fieldName, FieldType val)
	{
	}

	public void SetStatic<FieldType>(IntPtr fieldID, FieldType val)
	{
	}

	public IntPtr GetRawObject()
	{
		return (IntPtr)0;
	}

	public IntPtr GetRawClass()
	{
		return (IntPtr)0;
	}

	public AndroidJavaObject CloneReference()
	{
		return null;
	}

	public ReturnType Call<ReturnType, T>(string methodName, T[] args)
	{
		return default;
	}

	public ReturnType Call<ReturnType, T>(IntPtr methodID, T[] args)
	{
		return default;
	}

	public ReturnType Call<ReturnType>(string methodName, params object[] args)
	{
		return default;
	}

	public ReturnType Call<ReturnType>(IntPtr methodID, params object[] args)
	{
		return default;
	}

	public ReturnType CallStatic<ReturnType, T>(string methodName, T[] args)
	{
		return default;
	}

	public ReturnType CallStatic<ReturnType, T>(IntPtr methodID, T[] args)
	{
		return default;
	}

	public ReturnType CallStatic<ReturnType>(string methodName, params object[] args)
	{
		return default;
	}

	public ReturnType CallStatic<ReturnType>(IntPtr methodID, params object[] args)
	{
		return default;
	}

	protected void DebugPrint(string msg)
	{
	}

	protected void DebugPrint(string call, string methodName, string signature, object[] args)
	{
	}

	private void _AndroidJavaObject(string className, params object[] args)
	{
	}

	private void _AndroidJavaObject(IntPtr constructorID, params object[] args)
	{
	}

	internal AndroidJavaObject()
	{
	}

	~AndroidJavaObject()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	protected void _Call(string methodName, params object[] args)
	{
	}

	protected void _Call(IntPtr methodID, params object[] args)
	{
	}

	protected ReturnType _Call<ReturnType>(string methodName, params object[] args)
	{
		return default;
	}

	protected ReturnType _Call<ReturnType>(IntPtr methodID, params object[] args)
	{
		return default;
	}

	protected FieldType _Get<FieldType>(string fieldName)
	{
		return default;
	}

	protected FieldType _Get<FieldType>(IntPtr fieldID)
	{
		return default;
	}

	protected void _Set<FieldType>(string fieldName, FieldType val)
	{
	}

	protected void _Set<FieldType>(IntPtr fieldID, FieldType val)
	{
	}

	protected void _CallStatic(string methodName, params object[] args)
	{
	}

	protected void _CallStatic(IntPtr methodID, params object[] args)
	{
	}

	protected ReturnType _CallStatic<ReturnType>(string methodName, params object[] args)
	{
		return default;
	}

	protected ReturnType _CallStatic<ReturnType>(IntPtr methodID, params object[] args)
	{
		return default;
	}

	protected FieldType _GetStatic<FieldType>(string fieldName)
	{
		return default;
	}

	protected FieldType _GetStatic<FieldType>(IntPtr fieldID)
	{
		return default;
	}

	protected void _SetStatic<FieldType>(string fieldName, FieldType val)
	{
	}

	protected void _SetStatic<FieldType>(IntPtr fieldID, FieldType val)
	{
	}

	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject)
	{
		return null;
	}

	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass)
	{
		return null;
	}

	internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject)
	{
		return default;
	}

	protected IntPtr _GetRawObject()
	{
		return (IntPtr)0;
	}

	protected IntPtr _GetRawClass()
	{
		return (IntPtr)0;
	}
}
