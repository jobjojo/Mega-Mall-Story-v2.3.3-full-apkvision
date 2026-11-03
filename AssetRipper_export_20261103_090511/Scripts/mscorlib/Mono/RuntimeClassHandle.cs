using System;

namespace Mono;

internal struct RuntimeClassHandle
{
	private unsafe RuntimeStructs.MonoClass* value = null;

	internal unsafe RuntimeStructs.MonoClass* Value => null;

	internal unsafe RuntimeClassHandle(RuntimeStructs.MonoClass* value)
	{
	}

	internal unsafe RuntimeClassHandle(IntPtr ptr)
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

	internal unsafe static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass)
	{
		return (IntPtr)0;
	}

	internal RuntimeTypeHandle GetTypeHandle()
	{
		return default;
	}
}
