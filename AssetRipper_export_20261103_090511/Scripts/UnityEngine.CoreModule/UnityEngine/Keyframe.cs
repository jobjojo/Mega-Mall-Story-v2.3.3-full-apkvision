using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode]
public struct Keyframe
{
	private float m_Time;

	private float m_Value;

	private float m_InTangent;

	private float m_OutTangent;

	private int m_WeightedMode;

	private float m_InWeight;

	private float m_OutWeight;
}
