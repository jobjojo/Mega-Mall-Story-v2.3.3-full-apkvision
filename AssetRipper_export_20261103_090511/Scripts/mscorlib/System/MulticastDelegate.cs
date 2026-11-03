using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public abstract class MulticastDelegate : Delegate
{
	private Delegate[] delegates;

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public sealed override bool Equals(object obj)
	{
		return false;
	}

	public sealed override int GetHashCode()
	{
		return 0;
	}

	protected override MethodInfo GetMethodImpl()
	{
		return null;
	}

	public sealed override Delegate[] GetInvocationList()
	{
		return null;
	}

	protected sealed override Delegate CombineImpl(Delegate follow)
	{
		return null;
	}

	private int LastIndexOf(Delegate[] haystack, Delegate[] needle)
	{
		return 0;
	}

	protected sealed override Delegate RemoveImpl(Delegate value)
	{
		return null;
	}
}
