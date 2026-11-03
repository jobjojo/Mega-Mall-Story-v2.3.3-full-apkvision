using System;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Parameter)]
internal class NotNullAttribute : Attribute
{
	public string Exception { set; }

	public NotNullAttribute(string exception = "ArgumentNullException")
	{
	}
}
