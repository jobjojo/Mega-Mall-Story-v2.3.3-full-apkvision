using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[RequiredByNativeCode]
public struct Playable : IEquatable<Playable>
{
	private PlayableHandle m_Handle = default;

	private static readonly Playable m_NullPlayable;

	public static Playable Null => default;

	[VisibleToOtherModules]
	internal Playable(PlayableHandle handle)
	{
	}

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(Playable other)
	{
		return false;
	}
}
