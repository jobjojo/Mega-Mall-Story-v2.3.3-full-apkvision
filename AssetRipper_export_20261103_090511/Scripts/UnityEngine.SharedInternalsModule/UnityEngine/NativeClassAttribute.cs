using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
[VisibleToOtherModules]
internal sealed class NativeClassAttribute : Attribute
{
	private string QualifiedNativeName { set; }

	private string Declaration { set; }

	public NativeClassAttribute(string qualifiedCppName)
	{
	}

	public NativeClassAttribute(string qualifiedCppName, string declaration)
	{
	}
}
