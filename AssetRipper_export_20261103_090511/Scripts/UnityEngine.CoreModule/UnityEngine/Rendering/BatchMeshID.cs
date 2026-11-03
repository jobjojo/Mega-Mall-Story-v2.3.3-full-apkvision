using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[NativeClass("BatchMeshID")]
public struct BatchMeshID : IEquatable<BatchMeshID>
{
	public static readonly BatchMeshID Null;

	public uint value;

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(BatchMeshID other)
	{
		return false;
	}
}
