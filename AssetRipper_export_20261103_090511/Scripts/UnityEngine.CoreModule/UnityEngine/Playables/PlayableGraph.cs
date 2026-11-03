using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
public struct PlayableGraph
{
	internal IntPtr m_Handle;

	internal uint m_Version;
}
