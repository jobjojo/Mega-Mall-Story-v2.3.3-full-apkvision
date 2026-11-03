namespace System.Reflection;

public struct CustomAttributeNamedArgument
{
	private readonly Type _attributeType = null;

	private MemberInfo _lazyMemberInfo = null;

	public CustomAttributeTypedArgument TypedValue { get; } = default;

	public bool IsField { get; } = false;

	public string MemberName { get; } = null;

	public MemberInfo MemberInfo => null;

	internal CustomAttributeNamedArgument(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue)
	{
	}

	public CustomAttributeNamedArgument(MemberInfo memberInfo, object value)
	{
	}

	public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
	{
		return false;
	}

	public static bool operator !=(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
