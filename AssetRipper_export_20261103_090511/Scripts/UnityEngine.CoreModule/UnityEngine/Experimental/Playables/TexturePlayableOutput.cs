using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables;

[StaticAccessor("TexturePlayableOutputBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
[RequiredByNativeCode]
[NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
public struct TexturePlayableOutput
{
	private PlayableOutputHandle m_Handle;
}
