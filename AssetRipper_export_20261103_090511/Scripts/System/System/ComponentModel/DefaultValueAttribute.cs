namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public class DefaultValueAttribute : Attribute
{
	private object _value;

	public virtual object Value => null;

	public DefaultValueAttribute(bool value)
	{
	}

	public DefaultValueAttribute(string value)
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
}
