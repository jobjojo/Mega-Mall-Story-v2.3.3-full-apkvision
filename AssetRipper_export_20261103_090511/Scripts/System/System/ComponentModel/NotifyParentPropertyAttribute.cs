namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Property)]
public sealed class NotifyParentPropertyAttribute : Attribute
{
	public static readonly NotifyParentPropertyAttribute Yes;

	public static readonly NotifyParentPropertyAttribute No;

	public static readonly NotifyParentPropertyAttribute Default;

	private bool notifyParent;

	public bool NotifyParent => false;

	public NotifyParentPropertyAttribute(bool notifyParent)
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
