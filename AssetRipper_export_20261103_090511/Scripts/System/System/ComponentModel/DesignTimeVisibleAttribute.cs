namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public sealed class DesignTimeVisibleAttribute : Attribute
{
	public static readonly DesignTimeVisibleAttribute Yes;

	public static readonly DesignTimeVisibleAttribute No;

	public static readonly DesignTimeVisibleAttribute Default;

	public bool Visible { get; }

	public DesignTimeVisibleAttribute(bool visible)
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
