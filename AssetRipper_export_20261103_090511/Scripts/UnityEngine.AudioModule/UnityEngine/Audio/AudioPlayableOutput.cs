using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/AudioSource.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
public struct AudioPlayableOutput
{
	private PlayableOutputHandle m_Handle;
}
