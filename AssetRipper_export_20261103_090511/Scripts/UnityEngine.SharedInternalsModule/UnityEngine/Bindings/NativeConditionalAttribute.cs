using System;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
internal class NativeConditionalAttribute : Attribute
{
	public string Condition { set; }

	public bool Enabled { set; }

	public NativeConditionalAttribute(string condition)
	{
	}
}
