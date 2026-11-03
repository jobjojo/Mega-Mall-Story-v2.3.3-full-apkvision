using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[UsedByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
public struct PlayableHandle : IEquatable<PlayableHandle>
{
	internal IntPtr m_Handle;

	internal uint m_Version;

	private static readonly PlayableHandle m_Null;

	public static PlayableHandle Null => default;

	public static bool operator ==(PlayableHandle x, PlayableHandle y)
	{
		return false;
	}

	public override bool Equals(object p)
	{
		return false;
	}

	public bool Equals(PlayableHandle other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
	{
		return false;
	}
}
