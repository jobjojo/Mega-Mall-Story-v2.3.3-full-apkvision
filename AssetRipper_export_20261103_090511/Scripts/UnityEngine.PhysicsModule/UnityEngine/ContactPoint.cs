using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Modules/Physics/MessageParameters.h")]
public struct ContactPoint
{
	internal Vector3 m_Point;

	internal Vector3 m_Normal;

	internal Vector3 m_Impulse;

	internal int m_ThisColliderInstanceID;

	internal int m_OtherColliderInstanceID;

	internal float m_Separation;
}
