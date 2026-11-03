using System;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[RequiredByNativeCode]
[ExcludeFromPreset]
public sealed class Mesh : Object
{
	[StaticAccessor("MeshDataBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	public struct MeshData
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_Ptr;
	}

	internal bool canAccess
	{
		[NativeMethod("CanAccessFromScript")]
		get
		{
			return false;
		}
	}

	public int vertexCount
	{
		[NativeMethod("GetVertexCount")]
		get
		{
			return 0;
		}
	}

	public int subMeshCount
	{
		[NativeMethod(Name = "GetSubMeshCount")]
		get
		{
			return 0;
		}
	}

	public Vector3[] vertices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector2[] uv
	{
		set
		{
		}
	}

	public Color[] colors
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int[] triangles
	{
		set
		{
		}
	}

	[FreeFunction("MeshScripting::CreateMesh")]
	private static void Internal_Create([Writable] Mesh mono)
	{
	}

	[RequiredByNativeCode]
	public Mesh()
	{
	}

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = true, ThrowsException = true)]
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
	{
	}

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = true)]
	private void PrintErrorCantAccessChannel(VertexAttribute ch)
	{
	}

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = true)]
	public bool HasVertexAttribute(VertexAttribute attr)
	{
		return false;
	}

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = true)]
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags)
	{
	}

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = true)]
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim)
	{
		return null;
	}

	[NativeMethod("Clear")]
	private void ClearImpl(bool keepVertexLayout)
	{
	}

	[NativeMethod("RecalculateBounds")]
	private void RecalculateBoundsImpl(MeshUpdateFlags flags)
	{
	}

	[NativeMethod("MarkDynamic")]
	private void MarkDynamicImpl()
	{
	}

	internal static int DefaultDimensionForChannel(VertexAttribute channel)
	{
		return 0;
	}

	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim)
	{
		return null;
	}

	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel)
	{
		return null;
	}

	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags)
	{
	}

	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = MeshUpdateFlags.Default)
	{
	}

	private void PrintErrorCantAccessIndices()
	{
	}

	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
	{
		return false;
	}

	private bool CheckCanAccessSubmeshTriangles(int submesh)
	{
		return false;
	}

	private void CheckIndicesArrayRange(int valuesLength, int start, int length)
	{
	}

	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex)
	{
	}

	[ExcludeFromDocs]
	public void SetTriangles(List<int> triangles, int submesh)
	{
	}

	public void SetTriangles(List<int> triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
	{
	}

	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
	{
	}

	[ExcludeFromDocs]
	public void Clear()
	{
	}

	[ExcludeFromDocs]
	public void RecalculateBounds()
	{
	}

	public void RecalculateBounds([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
	{
	}

	public void MarkDynamic()
	{
	}
}
