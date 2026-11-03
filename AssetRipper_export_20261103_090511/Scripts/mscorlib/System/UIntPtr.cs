using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[CLSCompliant(false)]
[ComVisible(true)]
public readonly struct UIntPtr : ISerializable, IEquatable<UIntPtr>
{
	public static readonly UIntPtr Zero;

	private unsafe readonly void* _pointer = null;

	public static int Size => 0;

	public unsafe UIntPtr(ulong value)
	{
	}

	public unsafe UIntPtr(uint value)
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

	public override string ToString()
	{
		return null;
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public static bool operator ==(UIntPtr value1, UIntPtr value2)
	{
		return false;
	}

	public static bool operator !=(UIntPtr value1, UIntPtr value2)
	{
		return false;
	}

	public static explicit operator UIntPtr(ulong value)
	{
		return (UIntPtr)0u;
	}

	public static explicit operator UIntPtr(uint value)
	{
		return (UIntPtr)0u;
	}

	bool IEquatable<UIntPtr>.Equals(UIntPtr other)
	{
		return false;
	}
}
