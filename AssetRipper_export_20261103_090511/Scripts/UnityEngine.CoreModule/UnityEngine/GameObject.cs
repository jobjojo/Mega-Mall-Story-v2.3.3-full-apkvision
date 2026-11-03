using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine;

[UsedByNativeCode]
[ExcludeFromPreset]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
public sealed class GameObject : Object
{
	public Transform transform
	{
		[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	public bool activeInHierarchy
	{
		[NativeMethod(Name = "IsActive")]
		get
		{
			return false;
		}
	}

	public GameObject gameObject => null;

	public T GetComponent<T>()
	{
		return default;
	}

	[NativeWritableSelf]
	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
	{
	}

	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = true, ThrowsException = true)]
	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	public Component GetComponentInChildren(Type type, bool includeInactive)
	{
		return null;
	}

	[ExcludeFromDocs]
	public T GetComponentInChildren<T>()
	{
		return default;
	}

	public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive)
	{
		return default;
	}

	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = true, ThrowsException = true)]
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList)
	{
		return null;
	}

	public T[] GetComponents<T>()
	{
		return null;
	}

	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = true)]
	private Component Internal_AddComponentWithType(Type componentType)
	{
		return null;
	}

	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	public Component AddComponent(Type componentType)
	{
		return null;
	}

	public T AddComponent<T>() where T : Component
	{
		return null;
	}

	[NativeMethod(Name = "SetSelfActive")]
	public void SetActive(bool value)
	{
	}

	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = true)]
	public void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options)
	{
	}

	public GameObject(string name)
	{
	}

	public GameObject()
	{
	}

	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	private static void Internal_CreateGameObject([Writable] GameObject self, string name)
	{
	}

	[FreeFunction(Name = "GameObjectBindings::Find")]
	public static GameObject Find(string name)
	{
		return null;
	}
}
