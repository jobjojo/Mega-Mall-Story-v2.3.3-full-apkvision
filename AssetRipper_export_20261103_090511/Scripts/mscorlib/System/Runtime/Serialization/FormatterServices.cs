using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

[ComVisible(true)]
public static class FormatterServices
{
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable;

	private static bool unsafeTypeForwardersIsEnabled;

	private static bool unsafeTypeForwardersIsEnabledInitialized;

	private static readonly Type[] advancedTypes;

	private static Binder s_binder;

	static FormatterServices()
	{
	}

	private static MemberInfo[] GetSerializableMembers(RuntimeType type)
	{
		return null;
	}

	private static bool CheckSerializable(RuntimeType type)
	{
		return false;
	}

	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type)
	{
		return null;
	}

	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount)
	{
		parentTypes = null;
		parentTypeCount = default;
		return false;
	}

	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context)
	{
		return null;
	}

	public static object GetUninitializedObject(Type type)
	{
		return null;
	}

	private static object nativeGetUninitializedObject(RuntimeType type)
	{
		return null;
	}

	private static bool GetEnableUnsafeTypeForwarders()
	{
		return false;
	}

	internal static bool UnsafeTypeForwardersIsEnabled()
	{
		return false;
	}

	internal static void SerializationSetValue(MemberInfo fi, object target, object value)
	{
	}

	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data)
	{
		return null;
	}

	public static object[] GetObjectData(object obj, MemberInfo[] members)
	{
		return null;
	}

	public static Type GetTypeFromAssembly(Assembly assem, string name)
	{
		return null;
	}

	internal static Assembly LoadAssemblyFromString(string assemblyName)
	{
		return null;
	}

	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName)
	{
		return null;
	}

	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom)
	{
		hasTypeForwardedFrom = default;
		return null;
	}

	internal static string GetClrTypeFullName(Type type)
	{
		return null;
	}

	private static string GetClrTypeFullNameForArray(Type type)
	{
		return null;
	}

	private static string GetClrTypeFullNameForNonArrayTypes(Type type)
	{
		return null;
	}
}
