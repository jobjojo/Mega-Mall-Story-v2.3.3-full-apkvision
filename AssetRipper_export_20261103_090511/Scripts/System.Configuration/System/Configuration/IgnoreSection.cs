using System.Xml;

namespace System.Configuration;

public sealed class IgnoreSection : ConfigurationSection
{
	protected internal override ConfigurationPropertyCollection Properties => null;

	protected internal override void DeserializeSection(XmlReader xmlReader)
	{
	}

	protected internal override bool IsModified()
	{
		return false;
	}

	protected internal override void Reset(ConfigurationElement parentSection)
	{
	}

	protected internal override void ResetModified()
	{
	}

	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode)
	{
		return null;
	}
}
