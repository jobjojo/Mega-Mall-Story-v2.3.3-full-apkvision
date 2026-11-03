using System.Xml;

namespace System.Configuration;

public abstract class ConfigurationSection : ConfigurationElement
{
	protected internal virtual void DeserializeSection(XmlReader reader)
	{
	}

	protected internal override bool IsModified()
	{
		return false;
	}

	protected internal override void ResetModified()
	{
	}

	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode)
	{
		return null;
	}
}
