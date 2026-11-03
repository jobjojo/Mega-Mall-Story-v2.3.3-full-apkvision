using System;
using System.Reflection;

namespace Mono;

internal struct RuntimeGenericParamInfoHandle
{
	private unsafe RuntimeStructs.GenericParamInfo* value = null;

	internal Type[] Constraints => null;

	internal GenericParameterAttributes Attributes => GenericParameterAttributes.None;

	internal unsafe RuntimeGenericParamInfoHandle(IntPtr ptr)
	{
	}

	private Type[] GetConstraints()
	{
		return null;
	}

	private int GetConstraintsCount()
	{
		return 0;
	}
}
