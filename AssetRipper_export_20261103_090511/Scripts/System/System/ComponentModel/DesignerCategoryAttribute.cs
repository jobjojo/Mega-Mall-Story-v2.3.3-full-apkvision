namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public sealed class DesignerCategoryAttribute : Attribute
{
	public static readonly DesignerCategoryAttribute Component;

	public static readonly DesignerCategoryAttribute Default;

	public static readonly DesignerCategoryAttribute Form;

	public static readonly DesignerCategoryAttribute Generic;

	public string Category { get; }

	public DesignerCategoryAttribute()
	{
	}

	public DesignerCategoryAttribute(string category)
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
