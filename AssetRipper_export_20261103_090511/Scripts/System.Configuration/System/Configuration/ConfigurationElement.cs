using System.Reflection;

namespace System.Configuration;

[DefaultMember("Item")]
public abstract class ConfigurationElement
{
	protected internal virtual ConfigurationPropertyCollection Properties => null;

	protected internal virtual bool IsModified()
	{
		return false;
	}

	protected internal virtual void Reset(ConfigurationElement parentElement)
	{
	}

	protected internal virtual void ResetModified()
	{
	}
}
