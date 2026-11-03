using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[UsedByNativeCode]
public struct BatchCullingContext
{
	public readonly NativeArray<Plane> cullingPlanes = default;

	public readonly NativeArray<CullingSplit> cullingSplits = default;

	public readonly LODParameters lodParameters = default;

	public readonly Matrix4x4 localToWorldMatrix = default;

	public readonly BatchCullingViewType viewType = BatchCullingViewType.Unknown;

	public readonly BatchCullingProjectionType projectionType = BatchCullingProjectionType.Unknown;

	public readonly BatchCullingFlags cullingFlags = BatchCullingFlags.None;

	public readonly BatchPackedCullingViewID viewID = default;

	public readonly uint cullingLayerMask = 0u;

	public readonly ulong sceneCullingMask = 0uL;

	[Obsolete("BatchCullingContext.isOrthographic is deprecated. Use BatchCullingContext.projectionType instead.")]
	public readonly byte isOrthographic = 0;

	public readonly int receiverPlaneOffset = 0;

	public readonly int receiverPlaneCount = 0;

	internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, int inReceiverPlaneOffset, int inReceiverPlaneCount)
	{
	}
}
