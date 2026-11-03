using System.Runtime.CompilerServices;

namespace System;

internal ref struct ByReference<T>(ref T value)
{
	private IntPtr _value = (IntPtr)0;

	public ref T Value
	{
		[Intrinsic]
		get
		{
			throw null;
		}
	}
}
