namespace System;

[Serializable]
[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public sealed class AttributeUsageAttribute : Attribute
{
	private AttributeTargets _attributeTarget;

	private bool _allowMultiple;

	private bool _inherited;

	internal static AttributeUsageAttribute Default;

	public bool AllowMultiple
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Inherited
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public AttributeUsageAttribute(AttributeTargets validOn)
	{
	}
}
