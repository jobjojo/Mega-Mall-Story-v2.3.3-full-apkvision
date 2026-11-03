using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
public class CustomAttributeData
{
	private class LazyCAttrData
	{
		internal Assembly assembly;

		internal IntPtr data;

		internal uint data_length;
	}

	private ConstructorInfo ctorInfo;

	private IList<CustomAttributeTypedArgument> ctorArgs;

	private IList<CustomAttributeNamedArgument> namedArgs;

	private LazyCAttrData lazyData;

	[ComVisible(true)]
	public virtual ConstructorInfo Constructor => null;

	[ComVisible(true)]
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments => null;

	public virtual IList<CustomAttributeNamedArgument> NamedArguments => null;

	public Type AttributeType => null;

	protected CustomAttributeData()
	{
	}

	internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length)
	{
	}

	internal CustomAttributeData(ConstructorInfo ctorInfo)
	{
	}

	internal CustomAttributeData(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs)
	{
	}

	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs)
	{
		ctorArgs = null;
		namedArgs = null;
	}

	private void ResolveArguments()
	{
	}

	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target)
	{
		return null;
	}

	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
	{
		return null;
	}

	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target)
	{
		return null;
	}

	public static IList<CustomAttributeData> GetCustomAttributes(Module target)
	{
		return null;
	}

	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private static T[] UnboxValues<T>(object[] values)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
