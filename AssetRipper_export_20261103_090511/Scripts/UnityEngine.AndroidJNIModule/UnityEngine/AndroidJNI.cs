using System;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine;

[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
public static class AndroidJNI
{
	[StaticAccessor("jni", StaticAccessorType.DoubleColon)]
	[ThreadSafe]
	public static IntPtr GetJavaVM()
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static int AttachCurrentThread()
	{
		return 0;
	}

	[ThreadSafe]
	public static int DetachCurrentThread()
	{
		return 0;
	}

	[ThreadSafe]
	public static int GetVersion()
	{
		return 0;
	}

	[ThreadSafe]
	public static IntPtr FindClass(string name)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr FromReflectedMethod(IntPtr refMethod)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr FromReflectedField(IntPtr refField)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetSuperclass(IntPtr clazz)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2)
	{
		return false;
	}

	[ThreadSafe]
	public static int Throw(IntPtr obj)
	{
		return 0;
	}

	[ThreadSafe]
	public static int ThrowNew(IntPtr clazz, string message)
	{
		return 0;
	}

	[ThreadSafe]
	public static IntPtr ExceptionOccurred()
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void ExceptionDescribe()
	{
	}

	[ThreadSafe]
	public static void ExceptionClear()
	{
	}

	[ThreadSafe]
	public static void FatalError(string message)
	{
	}

	[ThreadSafe]
	public static int PushLocalFrame(int capacity)
	{
		return 0;
	}

	[ThreadSafe]
	public static IntPtr PopLocalFrame(IntPtr ptr)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewGlobalRef(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void DeleteGlobalRef(IntPtr obj)
	{
	}

	[ThreadSafe]
	internal static void QueueDeleteGlobalRef(IntPtr obj)
	{
	}

	[ThreadSafe]
	internal static uint GetQueueGlobalRefsCount()
	{
		return 0u;
	}

	[ThreadSafe]
	public static IntPtr NewWeakGlobalRef(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void DeleteWeakGlobalRef(IntPtr obj)
	{
	}

	[ThreadSafe]
	public static IntPtr NewLocalRef(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void DeleteLocalRef(IntPtr obj)
	{
	}

	[ThreadSafe]
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2)
	{
		return false;
	}

	[ThreadSafe]
	public static int EnsureLocalCapacity(int capacity)
	{
		return 0;
	}

	[ThreadSafe]
	public static IntPtr AllocObject(IntPtr clazz)
	{
		return (IntPtr)0;
	}

	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return (IntPtr)0;
	}

	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetObjectClass(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static bool IsInstanceOf(IntPtr obj, IntPtr clazz)
	{
		return false;
	}

	[ThreadSafe]
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
	{
		return (IntPtr)0;
	}

	public static IntPtr NewString(string chars)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	private static IntPtr NewStringFromStr(string chars)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewString(char[] chars)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewStringUTF(string bytes)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static string GetStringChars(IntPtr str)
	{
		return null;
	}

	[ThreadSafe]
	public static int GetStringLength(IntPtr str)
	{
		return 0;
	}

	[ThreadSafe]
	public static int GetStringUTFLength(IntPtr str)
	{
		return 0;
	}

	[ThreadSafe]
	public static string GetStringUTFChars(IntPtr str)
	{
		return null;
	}

	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return null;
	}

	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return null;
	}

	[ThreadSafe]
	public unsafe static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return null;
	}

	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return (IntPtr)0;
	}

	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return (IntPtr)0;
	}

	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return false;
	}

	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return false;
	}

	[ThreadSafe]
	public unsafe static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return false;
	}

	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	[Obsolete("AndroidJNI.CallByteMethod is obsolete. Use AndroidJNI.CallSByteMethod method instead")]
	public static byte CallByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return '\0';
	}

	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return '\0';
	}

	[ThreadSafe]
	public unsafe static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return '\0';
	}

	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0f;
	}

	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0f;
	}

	[ThreadSafe]
	public unsafe static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0f;
	}

	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0.0;
	}

	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0.0;
	}

	[ThreadSafe]
	public unsafe static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0.0;
	}

	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0L;
	}

	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0L;
	}

	[ThreadSafe]
	public unsafe static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0L;
	}

	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
	}

	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
	}

	[ThreadSafe]
	public unsafe static void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
	}

	[ThreadSafe]
	public static string GetStringField(IntPtr obj, IntPtr fieldID)
	{
		return null;
	}

	[ThreadSafe]
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
	{
		return false;
	}

	[Obsolete("AndroidJNI.GetByteField is obsolete. Use AndroidJNI.GetSByteField method instead")]
	public static byte GetByteField(IntPtr obj, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static char GetCharField(IntPtr obj, IntPtr fieldID)
	{
		return '\0';
	}

	[ThreadSafe]
	public static short GetShortField(IntPtr obj, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static int GetIntField(IntPtr obj, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static long GetLongField(IntPtr obj, IntPtr fieldID)
	{
		return 0L;
	}

	[ThreadSafe]
	public static float GetFloatField(IntPtr obj, IntPtr fieldID)
	{
		return 0f;
	}

	[ThreadSafe]
	public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
	{
		return 0.0;
	}

	[ThreadSafe]
	public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
	{
	}

	[ThreadSafe]
	public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
	{
	}

	[ThreadSafe]
	public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
	{
	}

	[Obsolete("AndroidJNI.SetByteField is obsolete. Use AndroidJNI.SetSByteField method instead")]
	public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val)
	{
	}

	[ThreadSafe]
	public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val)
	{
	}

	[ThreadSafe]
	public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
	{
	}

	[ThreadSafe]
	public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
	{
	}

	[ThreadSafe]
	public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
	{
	}

	[ThreadSafe]
	public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
	{
	}

	[ThreadSafe]
	public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
	{
	}

	[ThreadSafe]
	public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
	{
	}

	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return null;
	}

	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return null;
	}

	[ThreadSafe]
	public unsafe static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return null;
	}

	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return (IntPtr)0;
	}

	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return (IntPtr)0;
	}

	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return false;
	}

	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return false;
	}

	[ThreadSafe]
	public unsafe static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return false;
	}

	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	[Obsolete("AndroidJNI.CallStaticByteMethod is obsolete. Use AndroidJNI.CallStaticSByteMethod method instead")]
	public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return '\0';
	}

	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return '\0';
	}

	[ThreadSafe]
	public unsafe static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return '\0';
	}

	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0f;
	}

	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0f;
	}

	[ThreadSafe]
	public unsafe static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0f;
	}

	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0.0;
	}

	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0.0;
	}

	[ThreadSafe]
	public unsafe static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0.0;
	}

	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0L;
	}

	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0L;
	}

	[ThreadSafe]
	public unsafe static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0L;
	}

	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
	}

	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
	}

	[ThreadSafe]
	public unsafe static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
	}

	[ThreadSafe]
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
	{
		return null;
	}

	[ThreadSafe]
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
	{
		return false;
	}

	[Obsolete("AndroidJNI.GetStaticByteField is obsolete. Use AndroidJNI.GetStaticSByteField method instead")]
	public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
	{
		return '\0';
	}

	[ThreadSafe]
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
	{
		return 0L;
	}

	[ThreadSafe]
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
	{
		return 0f;
	}

	[ThreadSafe]
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
	{
		return 0.0;
	}

	[ThreadSafe]
	public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
	{
	}

	[ThreadSafe]
	public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
	{
	}

	[ThreadSafe]
	public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
	{
	}

	[Obsolete("AndroidJNI.SetStaticByteField is obsolete. Use AndroidJNI.SetStaticSByteField method instead")]
	public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val)
	{
	}

	[ThreadSafe]
	public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val)
	{
	}

	[ThreadSafe]
	public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
	{
	}

	[ThreadSafe]
	public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
	{
	}

	[ThreadSafe]
	public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
	{
	}

	[ThreadSafe]
	public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
	{
	}

	[ThreadSafe]
	public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
	{
	}

	[ThreadSafe]
	public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
	{
	}

	[ThreadSafe]
	private static IntPtr ConvertToBooleanArray(bool[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToBooleanArray(bool[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	public static IntPtr ToByteArray(byte[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToSByteArray(sbyte[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToSByteArray(sbyte* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToCharArray(char[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToCharArray(char* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToShortArray(short[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToShortArray(short* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToIntArray(int[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToIntArray(int* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToLongArray(long[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToLongArray(long* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToFloatArray(float[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToFloatArray(float* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToDoubleArray(double[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToDoubleArray(double* array, int length)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToObjectArray(IntPtr[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static bool[] FromBooleanArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	public static byte[] FromByteArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static sbyte[] FromSByteArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static char[] FromCharArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static short[] FromShortArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static int[] FromIntArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static long[] FromLongArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static float[] FromFloatArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static double[] FromDoubleArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static IntPtr[] FromObjectArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static int GetArrayLength(IntPtr array)
	{
		return 0;
	}

	[ThreadSafe]
	public static IntPtr NewBooleanArray(int size)
	{
		return (IntPtr)0;
	}

	[Obsolete("AndroidJNI.NewByteArray is obsolete. Use AndroidJNI.NewSByteArray method instead")]
	public static IntPtr NewByteArray(int size)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewSByteArray(int size)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewCharArray(int size)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewShortArray(int size)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewIntArray(int size)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewLongArray(int size)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewFloatArray(int size)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewDoubleArray(int size)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static bool GetBooleanArrayElement(IntPtr array, int index)
	{
		return false;
	}

	[Obsolete("AndroidJNI.GetByteArrayElement is obsolete. Use AndroidJNI.GetSByteArrayElement method instead")]
	public static byte GetByteArrayElement(IntPtr array, int index)
	{
		return 0;
	}

	[ThreadSafe]
	public static sbyte GetSByteArrayElement(IntPtr array, int index)
	{
		return 0;
	}

	[ThreadSafe]
	public static char GetCharArrayElement(IntPtr array, int index)
	{
		return '\0';
	}

	[ThreadSafe]
	public static short GetShortArrayElement(IntPtr array, int index)
	{
		return 0;
	}

	[ThreadSafe]
	public static int GetIntArrayElement(IntPtr array, int index)
	{
		return 0;
	}

	[ThreadSafe]
	public static long GetLongArrayElement(IntPtr array, int index)
	{
		return 0L;
	}

	[ThreadSafe]
	public static float GetFloatArrayElement(IntPtr array, int index)
	{
		return 0f;
	}

	[ThreadSafe]
	public static double GetDoubleArrayElement(IntPtr array, int index)
	{
		return 0.0;
	}

	[ThreadSafe]
	public static IntPtr GetObjectArrayElement(IntPtr array, int index)
	{
		return (IntPtr)0;
	}

	[Obsolete("AndroidJNI.SetBooleanArrayElement(IntPtr, int, byte) is obsolete. Use AndroidJNI.SetBooleanArrayElement(IntPtr, int, bool) method instead")]
	public static void SetBooleanArrayElement(IntPtr array, int index, byte val)
	{
	}

	[ThreadSafe]
	public static void SetBooleanArrayElement(IntPtr array, int index, bool val)
	{
	}

	[Obsolete("AndroidJNI.SetByteArrayElement is obsolete. Use AndroidJNI.SetSByteArrayElement method instead")]
	public static void SetByteArrayElement(IntPtr array, int index, sbyte val)
	{
	}

	[ThreadSafe]
	public static void SetSByteArrayElement(IntPtr array, int index, sbyte val)
	{
	}

	[ThreadSafe]
	public static void SetCharArrayElement(IntPtr array, int index, char val)
	{
	}

	[ThreadSafe]
	public static void SetShortArrayElement(IntPtr array, int index, short val)
	{
	}

	[ThreadSafe]
	public static void SetIntArrayElement(IntPtr array, int index, int val)
	{
	}

	[ThreadSafe]
	public static void SetLongArrayElement(IntPtr array, int index, long val)
	{
	}

	[ThreadSafe]
	public static void SetFloatArrayElement(IntPtr array, int index, float val)
	{
	}

	[ThreadSafe]
	public static void SetDoubleArrayElement(IntPtr array, int index, double val)
	{
	}

	[ThreadSafe]
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj)
	{
	}

	[ThreadSafe]
	public unsafe static IntPtr NewDirectByteBuffer(byte* buffer, long capacity)
	{
		return (IntPtr)0;
	}

	public static IntPtr NewDirectByteBuffer(NativeArray<byte> buffer)
	{
		return (IntPtr)0;
	}

	public static IntPtr NewDirectByteBuffer(NativeArray<sbyte> buffer)
	{
		return (IntPtr)0;
	}

	private static IntPtr NewDirectByteBufferFromNativeArray<T>(NativeArray<T> buffer) where T : struct
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static sbyte* GetDirectBufferAddress(IntPtr buffer)
	{
		return null;
	}

	[ThreadSafe]
	public static long GetDirectBufferCapacity(IntPtr buffer)
	{
		return 0L;
	}

	private static NativeArray<T> GetDirectBuffer<T>(IntPtr buffer) where T : struct
	{
		return default;
	}

	public static NativeArray<byte> GetDirectByteBuffer(IntPtr buffer)
	{
		return default;
	}

	public static NativeArray<sbyte> GetDirectSByteBuffer(IntPtr buffer)
	{
		return default;
	}

	public static int RegisterNatives(IntPtr clazz, JNINativeMethod[] methods)
	{
		return 0;
	}

	[ThreadSafe]
	private static IntPtr RegisterNativesAllocate(int length)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	private static void RegisterNativesSet(IntPtr natives, int idx, string name, string signature, IntPtr fnPtr)
	{
	}

	[ThreadSafe]
	private static int RegisterNativesAndFree(IntPtr clazz, IntPtr natives, int n)
	{
		return 0;
	}

	[ThreadSafe]
	public static int UnregisterNatives(IntPtr clazz)
	{
		return 0;
	}
}
