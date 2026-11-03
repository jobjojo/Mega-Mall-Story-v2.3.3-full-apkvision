namespace System.Runtime.ConstrainedExecution;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Interface, Inherited = false)]
public sealed class ReliabilityContractAttribute : Attribute
{
	private readonly Consistency ConsistencyGuarantee;

	private readonly Cer Cer;

	public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
	{
	}
}
