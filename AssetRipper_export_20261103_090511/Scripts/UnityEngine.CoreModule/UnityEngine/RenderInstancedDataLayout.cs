using System.Diagnostics;

namespace UnityEngine;

internal readonly struct RenderInstancedDataLayout
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly int size;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly int offsetObjectToWorld;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly int offsetPrevObjectToWorld;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly int offsetRenderingLayerMask;
}
