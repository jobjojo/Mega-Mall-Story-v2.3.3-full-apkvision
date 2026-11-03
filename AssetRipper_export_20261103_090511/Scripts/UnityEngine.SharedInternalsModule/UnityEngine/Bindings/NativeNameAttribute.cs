using System;

namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
[VisibleToOtherModules]
internal class NativeNameAttribute : Attribute
{
	public string Name { set; }

	public NativeNameAttribute(string name)
	{
	}
}
