using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[Serializable]
[NativeHeader("Runtime/Export/Hashing/Hash128.bindings.h")]
[NativeHeader("Runtime/Utilities/Hash128.h")]
[UsedByNativeCode]
public struct Hash128(ulong u64_0, ulong u64_1) : IComparable, IComparable<Hash128>, IEquatable<Hash128>
{
	internal ulong u64_0 = 0uL;

	internal ulong u64_1 = 0uL;

	public int CompareTo(Hash128 rhs)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	[FreeFunction("Hash128ToString", IsThreadSafe = true)]
	private static string Hash128ToStringImpl(Hash128 hash)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Hash128 obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public static bool operator ==(Hash128 hash1, Hash128 hash2)
	{
		return false;
	}

	public static bool operator <(Hash128 x, Hash128 y)
	{
		return false;
	}

	public static bool operator >(Hash128 x, Hash128 y)
	{
		return false;
	}

	private static string Hash128ToStringImpl_Injected(ref Hash128 hash)
	{
		return null;
	}
}
