using System.Configuration;

namespace System.Net.Configuration;

public sealed class DefaultProxySection : ConfigurationSection
{
	protected override ConfigurationPropertyCollection Properties => null;

	protected override void Reset(ConfigurationElement parentElement)
	{
	}
}
