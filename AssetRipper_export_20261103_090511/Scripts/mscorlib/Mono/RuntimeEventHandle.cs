using System;

namespace Mono;

internal struct RuntimeEventHandle
{
	private IntPtr value = (IntPtr)0;

	public IntPtr Value => (IntPtr)0;

	internal RuntimeEventHandle(IntPtr v)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
