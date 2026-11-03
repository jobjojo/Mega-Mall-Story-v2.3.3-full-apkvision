using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeClass("GraphicsBuffer")]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[UsedByNativeCode]
public sealed class ComputeBuffer
{
	internal IntPtr m_Ptr;
}
