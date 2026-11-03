namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
public sealed class DesignerSerializationVisibilityAttribute : Attribute
{
	public static readonly DesignerSerializationVisibilityAttribute Content;

	public static readonly DesignerSerializationVisibilityAttribute Hidden;

	public static readonly DesignerSerializationVisibilityAttribute Visible;

	public static readonly DesignerSerializationVisibilityAttribute Default;

	public DesignerSerializationVisibility Visibility { get; }

	public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
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
