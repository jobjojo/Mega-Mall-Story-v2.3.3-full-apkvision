using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public struct RuntimeFieldHandle : ISerializable
{
	private IntPtr value = (IntPtr)0;

	public IntPtr Value => (IntPtr)0;

	internal RuntimeFieldHandle(IntPtr v)
	{
	}

	private RuntimeFieldHandle(SerializationInfo info, StreamingContext context)
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

	private static void SetValueInternal(FieldInfo fi, object obj, object value)
	{
	}

	internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized)
	{
	}

	internal unsafe static void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType)
	{
	}
}
