namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public class CategoryAttribute : Attribute
{
	private bool localized;

	private string categoryValue;

	public string Category => null;

	public CategoryAttribute(string category)
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

	protected virtual string GetLocalizedString(string value)
	{
		return null;
	}
}
