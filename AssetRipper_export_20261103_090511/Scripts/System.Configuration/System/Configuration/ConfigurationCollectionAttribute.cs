namespace System.Configuration;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public sealed class ConfigurationCollectionAttribute : Attribute
{
	public ConfigurationCollectionAttribute(Type itemType)
	{
	}
}
