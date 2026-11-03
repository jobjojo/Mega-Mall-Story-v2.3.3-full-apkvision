using System;

namespace Mono;

internal struct SafeStringMarshal : IDisposable
{
	private readonly string str = null;

	private IntPtr marshaled_string = (IntPtr)0;

	public IntPtr Value => (IntPtr)0;

	private static IntPtr StringToUtf8_icall(ref string str)
	{
		return (IntPtr)0;
	}

	public static IntPtr StringToUtf8(string str)
	{
		return (IntPtr)0;
	}

	public static void GFree(IntPtr ptr)
	{
	}

	public SafeStringMarshal(string str)
	{
	}

	public void Dispose()
	{
	}
}
