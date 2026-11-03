using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[NativeClass(null)]
[ExtensionOfNativeClass]
[RequiredByNativeCode]
public class ScriptableObject : Object
{
	public static ScriptableObject CreateInstance(Type type)
	{
		return null;
	}

	public static T CreateInstance<T>() where T : ScriptableObject
	{
		return null;
	}

	[NativeMethod(IsThreadSafe = true)]
	private static void CreateScriptableObject([Writable] ScriptableObject self)
	{
	}

	[NativeMethod(Name = "Scripting::CreateScriptableObjectWithType", IsFreeFunction = true, ThrowsException = true)]
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset)
	{
		return null;
	}
}
