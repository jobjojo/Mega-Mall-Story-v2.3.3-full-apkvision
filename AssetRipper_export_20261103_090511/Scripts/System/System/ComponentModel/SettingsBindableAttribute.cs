namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Property)]
public sealed class SettingsBindableAttribute : Attribute
{
	public static readonly SettingsBindableAttribute Yes;

	public static readonly SettingsBindableAttribute No;

	public bool Bindable { get; }

	public SettingsBindableAttribute(bool bindable)
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
