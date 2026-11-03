using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[RequiredByNativeCode]
public struct PlayableOutput : IEquatable<PlayableOutput>
{
	private PlayableOutputHandle m_Handle = default;

	private static readonly PlayableOutput m_NullPlayableOutput;

	[VisibleToOtherModules]
	internal PlayableOutput(PlayableOutputHandle handle)
	{
	}

	public PlayableOutputHandle GetHandle()
	{
		return default;
	}

	public bool Equals(PlayableOutput other)
	{
		return false;
	}
}
