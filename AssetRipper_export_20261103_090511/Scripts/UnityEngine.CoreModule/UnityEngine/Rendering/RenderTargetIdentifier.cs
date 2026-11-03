using System;

namespace UnityEngine.Rendering;

public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier>
{
	private BuiltinRenderTextureType m_Type;

	private int m_NameID;

	private int m_InstanceID;

	private IntPtr m_BufferPointer;

	private int m_MipLevel;

	private CubemapFace m_CubeFace;

	private int m_DepthSlice;

	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public bool Equals(RenderTargetIdentifier rhs)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}
}
