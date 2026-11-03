using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public readonly struct IntPtr : ISerializable, IEquatable<IntPtr>
{
	private unsafe readonly void* m_value = null;

	public static readonly IntPtr Zero;

	public static int Size
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return 0;
		}
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public unsafe IntPtr(int value)
	{
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public unsafe IntPtr(long value)
	{
	}

	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public unsafe IntPtr(void* value)
	{
	}

	private unsafe IntPtr(SerializationInfo info, StreamingContext context)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
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

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public int ToInt32()
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public long ToInt64()
	{
		return 0L;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[CLSCompliant(false)]
	public unsafe void* ToPointer()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(string format)
	{
		return null;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static bool operator ==(IntPtr value1, IntPtr value2)
	{
		return false;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static bool operator !=(IntPtr value1, IntPtr value2)
	{
		return false;
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static explicit operator IntPtr(int value)
	{
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static explicit operator IntPtr(long value)
	{
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	[CLSCompliant(false)]
	public unsafe static explicit operator IntPtr(void* value)
	{
		return (IntPtr)0;
	}

	public static explicit operator int(IntPtr value)
	{
		return 0;
	}

	public static explicit operator long(IntPtr value)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public unsafe static explicit operator void*(IntPtr value)
	{
		return null;
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static IntPtr Add(IntPtr pointer, int offset)
	{
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static IntPtr operator +(IntPtr pointer, int offset)
	{
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static IntPtr operator -(IntPtr pointer, int offset)
	{
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal bool IsNull()
	{
		return false;
	}

	bool IEquatable<IntPtr>.Equals(IntPtr other)
	{
		return false;
	}
}
