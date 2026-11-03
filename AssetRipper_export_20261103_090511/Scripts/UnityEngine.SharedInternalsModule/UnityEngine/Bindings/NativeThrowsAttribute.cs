using System;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
internal class NativeThrowsAttribute : Attribute
{
	public bool ThrowsException { set; }
}
