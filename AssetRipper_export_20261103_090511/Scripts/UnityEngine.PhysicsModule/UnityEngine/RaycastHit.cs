using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/Physics/RaycastHit.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Interfaces/IRaycast.h")]
[NativeHeader("PhysicsScriptingClasses.h")]
public struct RaycastHit
{
	[NativeName("point")]
	internal Vector3 m_Point;

	[NativeName("normal")]
	internal Vector3 m_Normal;

	[NativeName("faceID")]
	internal uint m_FaceID;

	[NativeName("distance")]
	internal float m_Distance;

	[NativeName("uv")]
	internal Vector2 m_UV;

	[NativeName("collider")]
	internal int m_Collider;
}
