using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
[RequiredByNativeCode(GenerateProxy = true)]
public class Object
{
	private IntPtr m_CachedPtr;

	internal static int OffsetOfInstanceIDInCPlusPlusObject;

	private const string objectIsNullMessage = "The Object you want to instantiate is null.";

	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public HideFlags hideFlags
	{
		get
		{
			return HideFlags.None;
		}
		set
		{
		}
	}

	public int GetInstanceID()
	{
		return 0;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public static implicit operator bool(Object exists)
	{
		return false;
	}

	private static bool CompareBaseObjects(Object lhs, Object rhs)
	{
		return false;
	}

	private static bool IsNativeObjectAlive(Object o)
	{
		return false;
	}

	private IntPtr GetCachedPtr()
	{
		return (IntPtr)0;
	}

	public static T Instantiate<T>(T original) where T : Object
	{
		return null;
	}

	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = true, ThrowsException = true)]
	public static void Destroy(Object obj, [DefaultValue("0.0F")] float t)
	{
	}

	[ExcludeFromDocs]
	public static void Destroy(Object obj)
	{
	}

	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = true, ThrowsException = true)]
	public static void DestroyImmediate(Object obj, [DefaultValue("false")] bool allowDestroyingAssets)
	{
	}

	[ExcludeFromDocs]
	public static void DestroyImmediate(Object obj)
	{
	}

	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
	[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
	public static Object[] FindObjectsOfType(Type type, bool includeInactive)
	{
		return null;
	}

	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = true)]
	public static void DontDestroyOnLoad([NotNull("NullExceptionObject")] Object target)
	{
	}

	public static T[] FindObjectsOfType<T>() where T : Object
	{
		return null;
	}

	private static void CheckNullArgument(object arg, string message)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static bool operator ==(Object x, Object y)
	{
		return false;
	}

	public static bool operator !=(Object x, Object y)
	{
		return false;
	}

	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = true, IsThreadSafe = true)]
	private static int GetOffsetOfInstanceIDInCPlusPlusObject()
	{
		return 0;
	}

	[NativeMethod(Name = "CloneObject", IsFreeFunction = true, ThrowsException = true)]
	private static Object Internal_CloneSingle([NotNull("NullExceptionObject")] Object data)
	{
		return null;
	}

	[FreeFunction("UnityEngineObjectBindings::ToString")]
	private static string ToString(Object obj)
	{
		return null;
	}

	[FreeFunction("UnityEngineObjectBindings::GetName")]
	private static string GetName([NotNull("NullExceptionObject")] Object obj)
	{
		return null;
	}

	[FreeFunction("UnityEngineObjectBindings::SetName")]
	private static void SetName([NotNull("NullExceptionObject")] Object obj, string name)
	{
	}
}
