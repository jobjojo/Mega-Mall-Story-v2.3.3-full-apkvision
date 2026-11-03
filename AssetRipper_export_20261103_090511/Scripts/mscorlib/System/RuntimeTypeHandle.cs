using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System;

[Serializable]
[ComVisible(true)]
public struct RuntimeTypeHandle : ISerializable
{
	private IntPtr value = (IntPtr)0;

	public IntPtr Value => (IntPtr)0;

	internal RuntimeTypeHandle(IntPtr val)
	{
	}

	internal RuntimeTypeHandle(RuntimeType type)
	{
	}

	private RuntimeTypeHandle(SerializationInfo info, StreamingContext context)
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

	internal static TypeAttributes GetAttributes(RuntimeType type)
	{
		return TypeAttributes.NotPublic;
	}

	private static int GetMetadataToken(RuntimeType type)
	{
		return 0;
	}

	internal static int GetToken(RuntimeType type)
	{
		return 0;
	}

	private static Type GetGenericTypeDefinition_impl(RuntimeType type)
	{
		return null;
	}

	internal static Type GetGenericTypeDefinition(RuntimeType type)
	{
		return null;
	}

	internal static bool IsPrimitive(RuntimeType type)
	{
		return false;
	}

	internal static bool IsByRef(RuntimeType type)
	{
		return false;
	}

	internal static bool IsPointer(RuntimeType type)
	{
		return false;
	}

	internal static bool IsArray(RuntimeType type)
	{
		return false;
	}

	internal static bool IsSzArray(RuntimeType type)
	{
		return false;
	}

	internal static bool HasElementType(RuntimeType type)
	{
		return false;
	}

	internal static CorElementType GetCorElementType(RuntimeType type)
	{
		return CorElementType.End;
	}

	internal static bool HasInstantiation(RuntimeType type)
	{
		return false;
	}

	internal static bool IsComObject(RuntimeType type)
	{
		return false;
	}

	internal static bool IsInstanceOfType(RuntimeType type, object o)
	{
		return false;
	}

	internal static bool HasReferences(RuntimeType type)
	{
		return false;
	}

	internal static bool IsComObject(RuntimeType type, bool isGenericCOM)
	{
		return false;
	}

	internal static bool IsContextful(RuntimeType type)
	{
		return false;
	}

	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2)
	{
		return false;
	}

	internal static bool IsInterface(RuntimeType type)
	{
		return false;
	}

	internal static int GetArrayRank(RuntimeType type)
	{
		return 0;
	}

	internal static RuntimeAssembly GetAssembly(RuntimeType type)
	{
		return null;
	}

	internal static RuntimeType GetElementType(RuntimeType type)
	{
		return null;
	}

	internal static RuntimeModule GetModule(RuntimeType type)
	{
		return null;
	}

	internal static bool IsGenericVariable(RuntimeType type)
	{
		return false;
	}

	internal static RuntimeType GetBaseType(RuntimeType type)
	{
		return null;
	}

	internal static bool CanCastTo(RuntimeType type, RuntimeType target)
	{
		return false;
	}

	private static bool type_is_assignable_from(Type a, Type b)
	{
		return false;
	}

	internal static bool IsGenericTypeDefinition(RuntimeType type)
	{
		return false;
	}

	internal static IntPtr GetGenericParameterInfo(RuntimeType type)
	{
		return (IntPtr)0;
	}

	internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType)
	{
		return false;
	}

	internal static bool is_subclass_of(IntPtr childType, IntPtr baseType)
	{
		return false;
	}

	private static RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly)
	{
		return null;
	}

	internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName)
	{
		return null;
	}
}
