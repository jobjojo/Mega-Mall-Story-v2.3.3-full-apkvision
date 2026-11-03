using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
[RequiredByNativeCode]
[NativeClass("Unity::Component")]
public class Component : Object
{
	public Transform transform
	{
		[FreeFunction("GetTransform", HasExplicitThis = true, ThrowsException = true)]
		get
		{
			return null;
		}
	}

	public GameObject gameObject
	{
		[FreeFunction("GetGameObject", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	[FreeFunction(HasExplicitThis = true, ThrowsException = true)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
	{
	}

	public T GetComponent<T>()
	{
		return default;
	}

	[FreeFunction("SendMessage", HasExplicitThis = true)]
	public void SendMessage(string methodName, object value, SendMessageOptions options)
	{
	}

	[FreeFunction("BroadcastMessage", HasExplicitThis = true)]
	public void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options)
	{
	}
}
