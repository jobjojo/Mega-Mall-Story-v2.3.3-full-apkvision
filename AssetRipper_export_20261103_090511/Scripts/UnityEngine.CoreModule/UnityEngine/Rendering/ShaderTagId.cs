using System;

namespace UnityEngine.Rendering;

public struct ShaderTagId(string name) : IEquatable<ShaderTagId>
{
	private int m_Id = 0;

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(ShaderTagId other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
