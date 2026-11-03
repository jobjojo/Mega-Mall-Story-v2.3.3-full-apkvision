namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class BrowsableAttribute : Attribute
{
	public static readonly BrowsableAttribute Yes;

	public static readonly BrowsableAttribute No;

	public static readonly BrowsableAttribute Default;

	public bool Browsable { get; }

	public BrowsableAttribute(bool browsable)
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
