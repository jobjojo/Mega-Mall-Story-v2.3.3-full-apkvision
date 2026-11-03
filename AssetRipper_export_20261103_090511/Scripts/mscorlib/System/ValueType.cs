using System.Runtime.InteropServices;

namespace System;

[Serializable]
[ComVisible(true)]
public abstract class ValueType
{
	private static bool InternalEquals(object o1, object o2, out object[] fields)
	{
		fields = null;
		return false;
	}

	internal static bool DefaultEquals(object o1, object o2)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	internal static int InternalGetHashCode(object o, out object[] fields)
	{
		fields = null;
		return 0;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
