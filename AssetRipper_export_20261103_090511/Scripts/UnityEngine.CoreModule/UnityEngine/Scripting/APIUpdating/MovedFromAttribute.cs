using System;

namespace UnityEngine.Scripting.APIUpdating;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public class MovedFromAttribute : Attribute
{
	internal MovedFromAttributeData data;

	public MovedFromAttribute(string sourceNamespace)
	{
	}
}
