using System;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
internal class NativeMethodAttribute : Attribute
{
	public string Name { set; }

	public bool IsThreadSafe { set; }

	public bool IsFreeFunction { set; }

	public bool ThrowsException { set; }

	public bool HasExplicitThis { set; }

	public NativeMethodAttribute()
	{
	}

	public NativeMethodAttribute(string name)
	{
	}

	public NativeMethodAttribute(string name, bool isFreeFunction)
	{
	}

	public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe)
	{
	}
}
