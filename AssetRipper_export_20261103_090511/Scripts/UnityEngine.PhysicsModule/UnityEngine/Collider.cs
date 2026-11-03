using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/Physics/Collider.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode]
public class Collider : Component
{
}
