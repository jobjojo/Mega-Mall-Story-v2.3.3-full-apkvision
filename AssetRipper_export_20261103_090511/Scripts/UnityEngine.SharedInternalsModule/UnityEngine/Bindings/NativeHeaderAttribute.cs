using System;

namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
[VisibleToOtherModules]
internal class NativeHeaderAttribute : Attribute
{
	public string Header { set; }

	public NativeHeaderAttribute(string header)
	{
	}
}
