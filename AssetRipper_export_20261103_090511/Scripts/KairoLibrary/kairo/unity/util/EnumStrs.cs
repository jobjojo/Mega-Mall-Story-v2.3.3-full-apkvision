using System;
using java.io;

namespace kairo.unity.util;

public class EnumStrs<T> : EnumArray<T, string> where T : struct, IComparable
{
	public EnumStrs()
	{
	}

	public EnumStrs(params string[] values)
	{
	}

	public EnumStrs(ref string[] values)
	{
	}

	public void Serialize(OutputStream stream)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public string[] ToArray()
	{
		return null;
	}
}
