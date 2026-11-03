using System;
using System.Diagnostics;

namespace Unity.Jobs.LowLevel.Unsafe;

[AttributeUsage(AttributeTargets.Interface)]
public sealed class JobProducerTypeAttribute : Attribute
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly Type ProducerType;

	public JobProducerTypeAttribute(Type producerType)
	{
	}
}
