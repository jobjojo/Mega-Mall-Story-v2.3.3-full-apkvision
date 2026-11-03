using UnityEngine.Bindings;

namespace UnityEngine;

[StaticAccessor("AudioListenerBindings", StaticAccessorType.DoubleColon)]
[RequireComponent(typeof(Transform))]
public sealed class AudioListener : AudioBehaviour
{
}
