using System;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Method)]
internal sealed class NativeWritableSelfAttribute : Attribute
{
	public bool WritableSelf { set; }
}
