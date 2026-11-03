using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[UsedByNativeCode]
public class Behaviour : Component
{
	[NativeProperty]
	[RequiredByNativeCode]
	public bool enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeProperty]
	public bool isActiveAndEnabled
	{
		[NativeMethod("IsAddedToManager")]
		get
		{
			return false;
		}
	}
}
