using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables;

[StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
[RequiredByNativeCode]
public struct MaterialEffectPlayable : IEquatable<MaterialEffectPlayable>
{
	private PlayableHandle m_Handle;

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(MaterialEffectPlayable other)
	{
		return false;
	}
}
