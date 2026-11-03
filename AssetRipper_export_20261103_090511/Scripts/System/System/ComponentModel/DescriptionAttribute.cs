namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public class DescriptionAttribute : Attribute
{
	public static readonly DescriptionAttribute Default;

	public virtual string Description => null;

	protected string DescriptionValue { get; set; }

	public DescriptionAttribute()
	{
	}

	public DescriptionAttribute(string description)
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
