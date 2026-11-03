using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public struct RuntimeMethodHandle : ISerializable
{
	private IntPtr value = (IntPtr)0;

	public IntPtr Value => (IntPtr)0;

	internal RuntimeMethodHandle(IntPtr v)
	{
	}

	private RuntimeMethodHandle(SerializationInfo info, StreamingContext context)
	{
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format)
	{
		return null;
	}

	internal bool IsNullHandle()
	{
		return false;
	}
}
