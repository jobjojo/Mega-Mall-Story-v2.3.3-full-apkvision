using System;

namespace UnityEngine.Playables;

public struct FrameData
{
	[Flags]
	internal enum Flags
	{
		Evaluate = 1,
		SeekOccured = 2,
		Loop = 4,
		Hold = 8,
		EffectivePlayStateDelayed = 0x10,
		EffectivePlayStatePlaying = 0x20
	}

	internal ulong m_FrameID;

	internal double m_DeltaTime;

	internal float m_Weight;

	internal float m_EffectiveWeight;

	internal double m_EffectiveParentDelay;

	internal float m_EffectiveParentSpeed;

	internal float m_EffectiveSpeed;

	internal Flags m_Flags;

	internal PlayableOutput m_Output;
}
