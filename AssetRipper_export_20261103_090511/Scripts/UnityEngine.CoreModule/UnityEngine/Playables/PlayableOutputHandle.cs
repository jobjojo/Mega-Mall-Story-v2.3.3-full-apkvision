using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[UsedByNativeCode]
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle>
{
	internal IntPtr m_Handle;

	internal uint m_Version;

	private static readonly PlayableOutputHandle m_Null;

	public static PlayableOutputHandle Null => default;

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
	{
		return false;
	}

	public override bool Equals(object p)
	{
		return false;
	}

	public bool Equals(PlayableOutputHandle other)
	{
		return false;
	}

	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
	{
		return false;
	}
}
