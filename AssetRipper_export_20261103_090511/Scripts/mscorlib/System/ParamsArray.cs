namespace System;

internal readonly struct ParamsArray
{
	private static readonly object[] s_oneArgArray;

	private static readonly object[] s_twoArgArray;

	private static readonly object[] s_threeArgArray;

	private readonly object _arg0 = null;

	private readonly object _arg1 = null;

	private readonly object _arg2 = null;

	private readonly object[] _args = null;

	public int Length => 0;

	public object this[int index] => null;

	public ParamsArray(object arg0)
	{
	}

	public ParamsArray(object arg0, object arg1)
	{
	}

	public ParamsArray(object arg0, object arg1, object arg2)
	{
	}

	public ParamsArray(object[] args)
	{
	}

	private object GetAtSlow(int index)
	{
		return null;
	}
}
