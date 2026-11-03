using System;

namespace UnityEngine.InputSystem.Utilities;

public struct FourCC : IEquatable<FourCC>
{
	private int m_Code = 0;

	public FourCC(int code)
	{
	}

	public FourCC(char a, char b = ' ', char c = ' ', char d = ' ')
	{
	}

	public FourCC(string str)
	{
	}

	public static implicit operator int(FourCC fourCC)
	{
		return 0;
	}

	public static implicit operator FourCC(int i)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}

	public bool Equals(FourCC other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(FourCC left, FourCC right)
	{
		return false;
	}

	public static bool operator !=(FourCC left, FourCC right)
	{
		return false;
	}

	public static FourCC FromInt32(int i)
	{
		return default;
	}

	public static int ToInt32(FourCC fourCC)
	{
		return 0;
	}
}
