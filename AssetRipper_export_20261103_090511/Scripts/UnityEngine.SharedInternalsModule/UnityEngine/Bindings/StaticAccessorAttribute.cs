using System;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
internal class StaticAccessorAttribute : Attribute
{
	public string Name { set; }

	public StaticAccessorType Type { set; }

	[VisibleToOtherModules]
	internal StaticAccessorAttribute(string name)
	{
	}

	public StaticAccessorAttribute(string name, StaticAccessorType type)
	{
	}
}
