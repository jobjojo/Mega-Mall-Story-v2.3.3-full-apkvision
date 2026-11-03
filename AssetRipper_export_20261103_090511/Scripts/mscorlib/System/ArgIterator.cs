using System.Runtime.InteropServices;

namespace System;

[StructLayout((LayoutKind)3)]
public struct ArgIterator
{
	private IntPtr sig;

	private IntPtr args;

	private int next_arg;

	private int num_args;

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
