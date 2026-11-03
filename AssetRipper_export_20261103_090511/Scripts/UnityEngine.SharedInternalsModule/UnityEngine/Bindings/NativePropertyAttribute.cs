using System;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Property)]
internal class NativePropertyAttribute : NativeMethodAttribute
{
	public TargetType TargetType { set; }

	public NativePropertyAttribute()
	{
	}

	public NativePropertyAttribute(string name)
	{
	}

	public NativePropertyAttribute(string name, bool isFree, TargetType targetType)
	{
	}

	public NativePropertyAttribute(string name, bool isFree, TargetType targetType, bool isThreadSafe)
	{
	}
}
