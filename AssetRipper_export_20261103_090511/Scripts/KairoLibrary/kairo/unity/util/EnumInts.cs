using System;
using java.io;

namespace kairo.unity.util;

public class EnumInts<T> : EnumArray<T, int> where T : struct, IComparable
{
	public EnumInts()
	{
	}

	public EnumInts(params int[] values)
	{
	}

	public EnumInts(ref int[] values)
	{
	}

	public void Serialize(OutputStream stream)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}
