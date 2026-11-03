using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables;

[RequiredByNativeCode]
[StaticAccessor("CameraPlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
[NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct CameraPlayable : IEquatable<CameraPlayable>
{
	private PlayableHandle m_Handle;

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(CameraPlayable other)
	{
		return false;
	}
}
