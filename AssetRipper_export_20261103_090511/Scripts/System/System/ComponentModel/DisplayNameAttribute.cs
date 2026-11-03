namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
public class DisplayNameAttribute : Attribute
{
	public static readonly DisplayNameAttribute Default;

	public virtual string DisplayName => null;

	protected string DisplayNameValue { get; set; }

	public DisplayNameAttribute()
	{
	}

	public DisplayNameAttribute(string displayName)
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
