namespace System.Diagnostics;

[Serializable]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public sealed class ConditionalAttribute : Attribute
{
	private readonly string ConditionString;

	public ConditionalAttribute(string conditionString)
	{
	}
}
